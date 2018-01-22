using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class AltaReservaAlojamiento : Form
    {
        public Habitacion HabSeleccionada;
        public DateTime FechaIni;
        public DateTime FechaFin;
        public Cliente ClienteResponsable;
        Alojamiento NuevoAlojamiento;

        public AltaReservaAlojamiento()
        {
            InitializeComponent();
            FechaIni = dtp_fechaDesde.Value;
            dtp_fechaHasta.Value = DateTime.Now.AddDays(1);
            FechaFin = dtp_fechaHasta.Value;
            btn_Aceptar.Enabled = false;
            btn_Confirmar.Enabled = false;

            groupBox4.Enabled = false;
            groupBox3.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label14.Visible = true;
            btn_Confirmar.Image = Properties.Resources.Boton_Ok_Seleccion_3;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            label14.Visible = false;
            btn_Confirmar.Image = Properties.Resources.Boton_Ok_2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            //button4.BackColor = Color.Yellow 255, 255, 128};
        }

        private void btn_VerificarDisponibilidad_Click(object sender, EventArgs e)
        {
            if (FechaIni.CompareTo(FechaFin) == -1)
            {
                TablaDisponibilidad TablaDisp = new TablaDisponibilidad(FechaIni, FechaFin);
                TablaDisp.ShowDialog();

                if (TablaDisp.HabSeleccionada != null)
                {
                    tbx_NroHab.Text = Convert.ToString(TablaDisp.HabSeleccionada.HabitacionId);
                    this.HabSeleccionada = TablaDisp.HabSeleccionada;

                    if (!new ControladorAlojamiento().ExclusividadSegunCapacidad(FechaIni, FechaFin, 20))//si es falso que entre
                    {
                        MessageBox.Show("Atención: No se permite la exclusividad de la Habitación porque para las fechas deseadas se supera el límite de exclusividad de la capacidad del Hotel.");
                        ck_Exclusividad.Enabled = false;
                    }
                    else
                    {
                        ck_Exclusividad.Enabled = new ControladorHabitacion().VerificarSolicitdExclusividad(this.HabSeleccionada) == HabSeleccionada.Capacidad();
                    }

                    groupBox4.Enabled = true;
                   
                    groupBox2.Enabled = true;

                    //sino produce excepcion
                    cont_CuposDobles.Value = 0;
                    cont_CuposSimples.Value = 0;

                    //sino evade controles respoecto al responsable
                    dGV_ClienteResponsable.Rows.Clear();
                    contador_Titular.Value = 0;
                    contador_Directo.Value = 0;
                    contador_NoDirecto.Value = 0;
                    contador_Exceptuado.Value = 0;
                    contador_Convenio.Value = 0;
                }
            }
            else
                MessageBox.Show("Las fechas seleccionadas no corresponden. Seleccione de nuevo.");
        }

        //boton agregar responsable
        private void button2_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.setEnableAltas(false); 
            BuscarClienteForm.ShowDialog();
            try
            {
                if (BuscarClienteForm.ClienteSeleccionado != null)
                {
                    this.ClienteResponsable = BuscarClienteForm.ClienteSeleccionado;

                    if (this.ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.Titular)
                    {
                        MessageBox.Show("Atención: El Cliente Responsable que eligió no es Titular, según las reglas de negocio. Queda a su criterio continuar con la carga.");
                    }

                    if (ClienteResponsable.TarifaCliente.TarifaClienteId == TipoCliente.TitularExceptuado)
                    {
                        MessageBox.Show("Atención: Debido a que el Cliente Responsable es de Tipo Exceptuado, no es posible soliticar la exclusividad de la Habitación. Si cambia dicho Cliente podrá solicitar la exclusividad.");
                        HabSeleccionada.SetExclusividad(false);
                        ck_Exclusividad.Enabled = false;
                        ck_Exclusividad.Checked = false;
                    }
                    else
                    {
                        ck_Exclusividad.Enabled = true;
                    }

                    new ControladorCliente().ControlClienteActivo(this.ClienteResponsable, EstadoAlojamiento.Reservado, FechaIni, FechaFin);

                    dGV_ClienteResponsable.Rows.Clear();
                    dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.Telefono);
                    btn_Confirmar.Enabled = true;
                    groupBox3.Enabled = true;
                }
            }
            catch (Exception E)
            {
               MessageBox.Show(E.Message);
            }
        }

        /// <summary>
        /// Realizar control de excepciones 
        /// </summary>
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClienteResponsable != null) //requisito
                {
                    string contadores =
                                        (contador_Titular.Value).ToString() +
                                        (contador_Directo.Value).ToString() +
                                        (contador_NoDirecto.Value).ToString() +
                                        (contador_Exceptuado.Value).ToString() +
                                        (contador_Convenio.Value);

                    this.NuevoAlojamiento = new Alojamiento(contadores, HabSeleccionada, ClienteResponsable, FechaIni, FechaFin, Convert.ToByte(cont_CuposSimples.Value), Convert.ToByte(cont_CuposDobles.Value), HabSeleccionada.Exclusiva);

                    new ControladorCliente().ControlCuposConClientes(ClienteResponsable, contadores, cont_CuposSimples.Value, cont_CuposDobles.Value);

                    this.NuevoAlojamiento.CalcularCostoBase(new ControladorCliente().DevolverListaTarifas());

                    txb_CostoBase.Text = NuevoAlojamiento.MontoTotal.ToString();
                    txb_Deposito.Text = NuevoAlojamiento.Deposito.ToString();

                    groupBox4.Enabled = false;
                    groupBox3.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = false;

                    btn_Confirmar.Enabled = false;
                    btn_Aceptar.Enabled = true; 
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                new ControladorAlojamiento().RegistrarAloj(this.NuevoAlojamiento);
                //this.NuevoAlojamiento = new ControladorAlojamiento().BuscarAlojamientoPorID(NuevoAlojamiento.AlojamientoId);
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Alojamiento Registrado con Éxito", TipoMensaje.ReservaExitosa, NuevoAlojamiento.AlojamientoId);
                ventanaEmergente.ShowDialog();
                Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void ck_Exclusividad_CheckedChanged(object sender, EventArgs e)
        {
            this.HabSeleccionada.SetExclusividad(this.ck_Exclusividad.Checked);
        }

        #region Ingreso de Fechas en Calendario
        //Cuando se lanze estos dos eventos, obligar a que realice una verificacion de disponibilidad o algo similar
        private void dtp_fechaDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                new ControladorAlojamiento().ControlPlazoRereva(dtp_fechaDesde.Value.Date);
                this.FechaIni = dtp_fechaDesde.Value;
                btn_Confirmar.Enabled = false;
                groupBox4.Enabled = false;
                groupBox3.Enabled = false;
                groupBox2.Enabled = false;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                this.FechaIni = DateTime.Now.Date;
            }
        }

        private void dtp_fechaHasta_ValueChanged(object sender, EventArgs e)
        {
            this.FechaFin = dtp_fechaHasta.Value;
            btn_Confirmar.Enabled = false;
            groupBox4.Enabled = false;
            groupBox3.Enabled = false;
            groupBox2.Enabled = false;
        }
        #endregion

        private void cont_CuposSimples_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                new ControladorHabitacion().VerificarCuposSimplesIngresados(this.HabSeleccionada, cont_CuposSimples.Value);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                cont_CuposSimples.Value--;
            }
        }

        private void cont_CuposDobles_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                new ControladorHabitacion().VerificarCuposDoblesIngresados(this.HabSeleccionada, cont_CuposDobles.Value);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                cont_CuposDobles.Value--;
            }
        }

        private void contador_Exceptuado_ValueChanged(object sender, EventArgs e)
        {
            if (contador_Exceptuado.Value != 0 && ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.TitularExceptuado)
            {
                MessageBox.Show("Atención: Debido a que selecciono un Cliente de Tipo Exceptuado, no es posible soliticar la exclusividad de la Habitación. Si reduce el contador a 'cero' para dicho Cliente podrá solicitar la exclusividad.");
                HabSeleccionada.SetExclusividad(false);
                ck_Exclusividad.Enabled = false;
                ck_Exclusividad.Checked = false;
            }
            else if(ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.TitularExceptuado) //para evitar duplicacion de aviso
            {
                MessageBox.Show("Atención: Ahora es posible elegir la exclusividad de Habitación.");
                ck_Exclusividad.Enabled = true;
            }
        }
    }
}
