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
                }
            }
            else
                MessageBox.Show("Las fechas seleccionadas no corresponden. Seleccione de nuevo.");
        }

        //boton agregar responsable
        private void button2_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.ShowDialog();
            this.ClienteResponsable = BuscarClienteForm.iClienteSeleccionado;
            dGV_ClienteResponsable.Rows.Clear();
            dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.Telefono);
        }

        /// <summary>
        /// Realizar control de excepciones 
        /// </summary>
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            decimal[] contadores = new decimal[] { contador_Titular.Value, contador_Directo.Value, contador_NoDirecto.Value, contador_Exceptuado.Value, contador_Convenio.Value };
            var auxListClientes = new ControladorAlojamiento().GenerarTiposClientesReserva(contadores,ClienteResponsable);

            this.NuevoAlojamiento = new Alojamiento(auxListClientes, HabSeleccionada, ClienteResponsable, FechaIni, FechaFin, Convert.ToByte(cont_CuposSimples.Value), Convert.ToByte(cont_CuposDobles.Value), HabSeleccionada.Exclusiva);
            this.NuevoAlojamiento.CalcularCostoBase();

            txb_CostoBase.Text = NuevoAlojamiento.MontoTotal.ToString();
            txb_Deposito.Text = NuevoAlojamiento.Deposito.ToString();
            btn_Aceptar.Enabled = true;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            new ControladorAlojamiento().RegistrarReservaAloj(this.NuevoAlojamiento);
            MessageBox.Show("Reserva Registrada con Éxito");
            Close();
        }

        private void ck_Exclusividad_CheckedChanged(object sender, EventArgs e)
        {
            this.HabSeleccionada.SetExclusividad(this.ck_Exclusividad.Checked);
        }

        #region Ingreso de Fechas en Calendario
        //Cuando se lanze estos dos eventos, obligar a que realice una verificacion de disponibilidad o algo similar
        private void dtp_fechaDesde_ValueChanged(object sender, EventArgs e)
        {
            this.FechaIni = dtp_fechaDesde.Value;
        }

        private void dtp_fechaHasta_ValueChanged(object sender, EventArgs e)
        {
            this.FechaFin = dtp_fechaHasta.Value;
        } 
        #endregion
    }
}
