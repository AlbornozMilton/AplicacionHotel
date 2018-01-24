﻿using System;
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
    public partial class AltaAlojamientoSinReserva : Form
    {
        public Habitacion HabSeleccionada;
        public DateTime FechaIni;
        public DateTime FechaFin;
        public Cliente ClienteResponsable;
        public Alojamiento NuevoAlojamiento;
        public List<Cliente> Acompañantes = new List<Cliente>();
        List<Cliente> auxListaCliReserva = new List<Cliente>(); //clientes de la reserva


        public AltaAlojamientoSinReserva()
        {
            InitializeComponent();
            txb_fechaActual.Text = DateTime.Today.ToString("dd/MM/yy");
            txb_fechaActual.Enabled = false;
            btn_Aceptar.Enabled = false;
            btn_AgregarAcompañante.Enabled = false;
            btn_quitarCliente.Enabled = false;
            txb_CostoBase.Enabled = false;

            dtp_fechaDesde.Value = DateTime.Now;
            dtp_fechaDesde.Enabled = false;
            FechaIni = dtp_fechaDesde.Value;
            dtp_fechaHasta.Value = DateTime.Now.AddDays(1);
            FechaFin = dtp_fechaHasta.Value;
            txb_IdAloj.Enabled = false;
        }

        private void btn_VerificarDisponibilidad_Click(object sender, EventArgs e)
        {
            //si la fecha ini es menor que fecha fin
            if (FechaIni.CompareTo(FechaFin) == -1)
            {
                TablaDisponibilidad TablaDisp = new TablaDisponibilidad(FechaIni, FechaFin);
                TablaDisp.ShowDialog();

                if (TablaDisp.HabSeleccionada != null)
                {
                    txb_NroHabitacion.Text = Convert.ToString(TablaDisp.HabSeleccionada.HabitacionId);
                    this.HabSeleccionada = TablaDisp.HabSeleccionada;
                    
                    if (!new ControladorAlojamiento().ExclusividadSegunCapacidad(FechaIni, FechaFin, 20))//si es falso que entre
                    {
                        VentanaEmergente ventanaEmergente = new VentanaEmergente("No se permite la exclusividad de la Habitación porque para las fechas deseadas se supera el límite de exclusividad de la capacidad del Hotel", TipoMensaje.Alerta);
                        ventanaEmergente.ShowDialog();
                        ck_Exclusividad.Enabled = false;
                    }
                    else
                    {
                        ck_Exclusividad.Enabled = new ControladorHabitacion().VerificarSolicitdExclusividad(HabSeleccionada) == HabSeleccionada.Capacidad();
                    }

                    groupBox4.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    btn_AgregarAcompañante.Enabled = false;

                    //sino produce excepcion 
                    cont_CuposDobles.Value = 0;
                    cont_CuposSimples.Value = 0;
                    ck_Exclusividad.Checked = false;
                    //groupBox1.Enabled = false;

                    // ya que sino evade controles respoecto al responsable y a los demas clientes
                    dGV_ClienteResponsable.Rows.Clear();

                    if (this.Acompañantes.Count > 1)
                    {
                        this.Acompañantes.Clear();

                        for (int i = 0; i < dGV_Acompañantes.Rows.Count; i++)
                        {
                            dGV_Acompañantes.Rows.RemoveAt(i);
                        }
                    };
                }
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Las fechas seleccionadas no corresponden. Seleccione de nuevo", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_VerificarDisponibilidad.Enabled == false) //se trata de alta de reserva
                {
                    //this.NuevoAlojamiento.SetIDAloj(Convert.ToInt32(txb_IdAloj.Text));
                    
                    this.NuevoAlojamiento.SetClientes(this.Acompañantes);
                    new ControladorCliente().ControlCuposConClientes(this.NuevoAlojamiento.Clientes, cont_CuposSimples.Value, cont_CuposDobles.Value);
                    new ControladorAlojamiento().ComprobarClientesAltaConReserva(this.NuevoAlojamiento, txb_CostoBase.Text);
                    this.NuevoAlojamiento.Habitacion.OcuparCupos(this.NuevoAlojamiento.CantCuposSimples, this.NuevoAlojamiento.iCantCuposDobles);
                    //this.NuevoAlojamiento.Habitacion.SetExclusividad(this.NuevoAlojamiento.Exclusividad);
                    //EL ALOJAMIENTO CAMBIA A ESTADO ALOJADO Y LA FECHA DE INGRESO = DATETIME.NOW
                }
                else if(Acompañantes.Contains(this.ClienteResponsable))//Alta sin Reserva, crea nuevo alojamiento con estado Alojado
                {
                    HabSeleccionada.OcuparCupos(Convert.ToByte(cont_CuposSimples.Value), Convert.ToByte(cont_CuposDobles.Value));
                    this.NuevoAlojamiento = new Alojamiento(HabSeleccionada, ClienteResponsable, Acompañantes, FechaIni, FechaFin, Convert.ToByte(cont_CuposSimples.Value), Convert.ToByte(cont_CuposDobles.Value), HabSeleccionada.Exclusiva);
                    new ControladorCliente().ControlCuposConClientes(this.NuevoAlojamiento.Clientes,cont_CuposSimples.Value,cont_CuposDobles.Value);
                    NuevoAlojamiento.CalcularCostoBase(new List<TarifaCliente>());
                }

                txb_CostoBase.Text = NuevoAlojamiento.MontoTotal.ToString();
                btn_Confirmar.Enabled = false;

                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;

                btn_Aceptar.Enabled = true;
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        //RESPONSABLE
        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.setEnableAltas(false);
            BuscarClienteForm.ShowDialog();
            try
            {
                if (BuscarClienteForm.ClienteSeleccionado != null)
                {
                    this.ClienteResponsable = BuscarClienteForm.ClienteSeleccionado;

                    new ControladorCliente().ControlClienteActivo(ClienteResponsable, EstadoAlojamiento.Alojado, FechaIni, FechaFin);
                    
                    if (ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.Titular)
                    {
                        VentanaEmergente ventanaEmergente = new VentanaEmergente("El Cliente Responsable que eligió no es Titular, según las reglas de negocio.Queda a su criterio continuar con la carga.", TipoMensaje.Alerta);
                        ventanaEmergente.ShowDialog();
                    }else if (ClienteResponsable.TarifaCliente.TarifaClienteId == TipoCliente.TitularExceptuado)
                    {
                        VentanaEmergente ventanaEmergente = new VentanaEmergente("Debido a que el Cliente Responsable es de Tipo Exceptuado, no es posible soliticar la exclusividad de la Habitación. Si cambia dicho Cliente podrá solicitar la exclusividad.", TipoMensaje.Alerta);
                        ventanaEmergente.ShowDialog();
                        HabSeleccionada.SetExclusividad(false);
                        ck_Exclusividad.Enabled = false;
                        ck_Exclusividad.Checked = false;
                    }
                    else
                    {
                        ck_Exclusividad.Enabled = true;
                    }

                    dGV_ClienteResponsable.Rows.Clear();
                    dGV_Acompañantes.Rows.Clear();
                    this.Acompañantes.Clear();

                    dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Legajo, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.TarifaCliente.NombreTarifa);
                    this.Acompañantes.Add(ClienteResponsable);

                    btn_Confirmar.Enabled = true;
                    btn_AgregarAcompañante.Enabled = true;
                    btn_quitarCliente.Enabled = true;
                }
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }

        }

        private void btn_AgregarAcompañante_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.setEnableAltas(false);
            BuscarClienteForm.ShowDialog();

            try
            {
                if (BuscarClienteForm.ClienteSeleccionado == null)
                {
                    throw new Exception("Debe Seleccionar un Cliente.");
                }

                new ControladorCliente().ControlClienteActivo(BuscarClienteForm.ClienteSeleccionado, EstadoAlojamiento.Alojado, FechaIni, FechaFin);

                if (Acompañantes.Contains(BuscarClienteForm.ClienteSeleccionado))
                {
                    throw new Exception("El Cliente elegido ya se encuentra entre los clientes seleccionadoss.");
                }

                if (BuscarClienteForm.ClienteSeleccionado.TarifaCliente.TarifaClienteId == TipoCliente.TitularExceptuado)
                {
                    VentanaEmergente ventanaEmergente = new VentanaEmergente(
                        "Debido a que agregó un Cliente de Tipo Exceptuado, no es posible soliticar la exclusividad de la Habitación", 
                        TipoMensaje.Alerta);
                    ventanaEmergente.ShowDialog();

                    HabSeleccionada.SetExclusividad(false);
                    ck_Exclusividad.Enabled = false;
                    ck_Exclusividad.Checked = false;
                }

                this.Acompañantes.Add(BuscarClienteForm.ClienteSeleccionado);
                dGV_Acompañantes.Rows.Add(BuscarClienteForm.ClienteSeleccionado.ClienteId, BuscarClienteForm.ClienteSeleccionado.Legajo, BuscarClienteForm.ClienteSeleccionado.Apellido, BuscarClienteForm.ClienteSeleccionado.Nombre, BuscarClienteForm.ClienteSeleccionado.TarifaCliente.NombreTarifa);
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int auxIdAloj;
                if (this.NuevoAlojamiento.ContadoresTarifas==null) //Alta sin Reserva
                {
                    auxIdAloj = new ControladorAlojamiento().RegistrarAloj(this.NuevoAlojamiento);
                }
                else
                {//Alta de reserva
                    new ControladorAlojamiento().RegistrarAltaReserva(this.NuevoAlojamiento);
                    auxIdAloj = NuevoAlojamiento.AlojamientoId;
                }
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Alojamiento Registrado con Éxito", TipoMensaje.AltaAlojamientoExitosa, auxIdAloj);
                ventanaEmergente.ShowDialog();
                Close();
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private void dtp_fechaDesde_ValueChanged(object sender, EventArgs e)
        {
            this.FechaIni = dtp_fechaDesde.Value;
            groupBox4.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            btn_Confirmar.Enabled = false;
        }

        private void dtp_fechaHasta_ValueChanged(object sender, EventArgs e)
        {
            this.FechaFin = dtp_fechaHasta.Value.Date;
            groupBox4.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            btn_Confirmar.Enabled = false;
        }

        private void ck_Exclusividad_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_VerificarDisponibilidad.Enabled)
            {
                this.HabSeleccionada.SetExclusividad(this.ck_Exclusividad.Checked);
            }
        }

        /// <summary>
        /// Modifica el campo Enable de una conjunto de propiedades de la Form al valor de parámetro
        /// </summary>
        public void EnableAll(bool pValorEnable)
        {
            groupBox1.Enabled = pValorEnable; //disponibilidad
            groupBox2.Enabled = pValorEnable; //cliente responsable
            groupBox3.Enabled = !pValorEnable; //cliente responsable
            btn_AgregarAcompañante.Enabled = !pValorEnable;
            btn_quitarCliente.Enabled = !pValorEnable;
            groupBox4.Enabled = pValorEnable; //habitacion

            //dtp_fechaDesde.Enabled = pValorEnable;
            //dtp_fechaHasta.Enabled = pValorEnable;
            //cont_CuposSimples.Enabled = pValorEnable;
            //cont_CuposDobles.Enabled = pValorEnable;
            //ck_Exclusividad.Enabled = pValorEnable;
            //btn_VerificarDisponibilidad.Enabled = pValorEnable;
            //btn_AgregarCliente.Enabled = pValorEnable;
            //dGV_ClienteResponsable.Enabled = pValorEnable;
            //txb_CostoBase.Enabled = pValorEnable;
            

            btn_Confirmar.Enabled = !pValorEnable;
            btn_Aceptar.Enabled = pValorEnable;
        }

        private void cont_CuposSimples_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                new ControladorHabitacion().VerificarCuposSimplesIngresados(this.HabSeleccionada,cont_CuposSimples.Value);
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
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
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
                cont_CuposDobles.Value--;
            }
        }

        private void dGV_Acompañantes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dGV_Acompañantes.RowCount > Acompañantes.Count)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("No es posible agregar otro Cliente debido a la cantidad de cupos que ingresó.", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
                dGV_Acompañantes.Rows.RemoveAt(dGV_Acompañantes.RowCount - 1);
            }
        }

        private void btn_quitarCliente_Click(object sender, EventArgs e)
        {
            if (dGV_Acompañantes.CurrentRow != null)
            {
                Cliente auxCliente = Acompañantes.Find(c => c.ClienteId == Convert.ToInt32(dGV_Acompañantes.CurrentRow.Cells[0].Value));
                Acompañantes.Remove(auxCliente);
                dGV_Acompañantes.Rows.Remove(dGV_Acompañantes.CurrentRow);

                if (auxCliente.TarifaCliente.TarifaClienteId == TipoCliente.TitularExceptuado && ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.TitularExceptuado)
                {
                    VentanaEmergente ventanaEmergente = new VentanaEmergente("Ahora es posible elegir exclusividad de Habitación", TipoMensaje.Alerta);
                    ventanaEmergente.ShowDialog();
                    //HabSeleccionada.SetExclusividad(false);
                    ck_Exclusividad.Enabled = true;
                }
            }
        }

        #region Alta de Reserva
        public void RellenarCampos()
        {

            txb_IdAloj.Text = NuevoAlojamiento.AlojamientoId.ToString();
            dtp_fechaDesde.Value = NuevoAlojamiento.FechaEstimadaIngreso;
            dtp_fechaHasta.Value = NuevoAlojamiento.FechaEstimadaEgreso;
            txb_NroHabitacion.Text = NuevoAlojamiento.HabitacionId.ToString();

            HabSeleccionada = NuevoAlojamiento.Habitacion;
            ck_Exclusividad.Checked = NuevoAlojamiento.Exclusividad;
            cont_CuposSimples.Value = NuevoAlojamiento.CantCuposSimples;
            cont_CuposDobles.Value = NuevoAlojamiento.CantCuposDobles;

            //cliente responsable
            this.ClienteResponsable = NuevoAlojamiento.Clientes.Find(c => c.ClienteId == NuevoAlojamiento.DniResponsable);
            dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Legajo, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.TarifaCliente.NombreTarifa);
            this.Acompañantes = new List<Cliente>();
            this.Acompañantes.Add(ClienteResponsable);
            //btn_Confirmar.Enabled = true;

            //HabSeleccionada.SetExclusividad(NuevoAlojamiento.Exclusividad);

            //para almacenar el valor de costo base de reserva y luego comparar
            txb_CostoBase.Text = NuevoAlojamiento.MontoTotal.ToString();

            ////--------Por la reserva------------------------
            //if (!btn_VerificarDisponibilidad.Enabled)
            //{
            //    auxListaCliReserva = NuevoAlojamiento.Clientes;
            //}
            ////-------------------------------------
            button_visualizarReserva.Visible = true;
        }
        #endregion

        private void button_visualizarReserva_Click(object sender, EventArgs e)
        {
            VisualizarAlojamiento visualizarAlojamiento = new VisualizarAlojamiento(NuevoAlojamiento);
            visualizarAlojamiento.ShowDialog();
        }
    }
}
