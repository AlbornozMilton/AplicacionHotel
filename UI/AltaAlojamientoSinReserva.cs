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
    public partial class AltaAlojamientoSinReserva : Form
    {
        public Habitacion HabSeleccionada;
        public DateTime FechaIni;
        public DateTime FechaFin;
        public Cliente ClienteResponsable;
        public Alojamiento NuevoAlojamiento;
        public List<Cliente> Acompañantes = new List<Cliente>();
		private List<Alojamiento> iAlojsActivos = new ControladorAlojamiento().ObtenerAlojamientosActivos();
		private bool exclusividadCapacidad;


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

					exclusividadCapacidad = new ControladorAlojamiento().ExclusividadSegunCapacidad(FechaIni, FechaFin, 20);

					if (!exclusividadCapacidad)//si es falso que entre
                    {
                        VentanaEmergente ventanaEmergente = new VentanaEmergente("No se permite la exclusividad de la Habitación porque para las fechas deseadas se supera el límite de exclusividad de la capacidad del Hotel", TipoMensaje.Alerta);
                        ventanaEmergente.ShowDialog();
						ck_Exclusividad.Enabled = exclusividadCapacidad;
                    }
                    else
                    {
						exclusividadCapacidad = new ControladorHabitacion().VerificarSolicitdExclusividad(HabSeleccionada) == HabSeleccionada.Capacidad;
						ck_Exclusividad.Enabled = exclusividadCapacidad;
					}

                    groupBox4.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    btn_AgregarAcompañante.Enabled = false;

					//cont_CuposDobles.Value = 0;
					//cont_CuposSimples.Value = 0;
					//ck_Exclusividad.Checked = false;
                }
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Las fechas seleccionadas no corresponden. Seleccione de nuevo", TipoMensaje.Alerta);
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

                    new ControladorCliente().ControlClienteActivo(ClienteResponsable, FechaIni, FechaFin, iAlojsActivos);
					
					if (ClienteResponsable.TarifaCliente.TarifaClienteId == TipoCliente.TitularExceptuado && ck_Exclusividad.Enabled == true)
                    {
                        VentanaEmergente ventanaEmergente = new VentanaEmergente("Debido a que el Cliente Responsable es de Tipo Exceptuado, no es posible solicitar la Exclusividad de la Habitación.", TipoMensaje.Alerta);
                        ventanaEmergente.ShowDialog();
                        HabSeleccionada.SetExclusividad(false);
                        ck_Exclusividad.Checked = false;
						ck_Exclusividad.Enabled = false;
                    }
					else
					{
						if (this.ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.Titular)
						{
							VentanaEmergente ventanaEmergente = new VentanaEmergente("El Cliente Responsable que eligió no es Titular, según las reglas de negocio. Queda a su criterio continuar con la carga.", TipoMensaje.Alerta);
							ventanaEmergente.ShowDialog();
						}
						ck_Exclusividad.Enabled = exclusividadCapacidad;
					}

					if (Acompañantes.Count != 0)
					{
						dGV_ClienteResponsable.Rows.Clear();
						dGV_Acompañantes.Rows.Clear();
						this.Acompañantes.Clear(); 
					}

                    dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Legajo, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.TarifaCliente.NombreTarifa);
                    this.Acompañantes.Add(ClienteResponsable);

                    btn_Comprobar.Enabled = true;
                    btn_AgregarAcompañante.Enabled = true;
                    btn_quitarCliente.Enabled = true;
                }
                else
                {
					dGV_ClienteResponsable.Rows.Clear();
					throw new Exception("   Debe seleccionar un Cliente");
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

                if (Acompañantes.Contains(BuscarClienteForm.ClienteSeleccionado))
                {
                    throw new Exception("El Cliente elegido ya se encuentra entre los Clientes seleccionados.");
                }

				new ControladorCliente().ControlClienteActivo(BuscarClienteForm.ClienteSeleccionado, FechaIni, FechaFin, iAlojsActivos);

				if (ck_Exclusividad.Enabled == true
					&&
					ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.TitularExceptuado
					&&
					BuscarClienteForm.ClienteSeleccionado.TarifaCliente.TarifaClienteId == TipoCliente.TitularExceptuado
					)
				{
					HabSeleccionada.SetExclusividad(false);
					ck_Exclusividad.Checked = false;
					ck_Exclusividad.Enabled = false;

					VentanaEmergente ventanaEmergente = new VentanaEmergente(
                        "Debido a que agregó un Cliente de Tipo Exceptuado, no es posible solicitar la Exclusividad de la Habitación", 
                        TipoMensaje.Alerta);
                    ventanaEmergente.ShowDialog();
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

		private void btn_Comprobar_Click(object sender, EventArgs e)
		{
			try
			{
				if (btn_VerificarDisponibilidad.Enabled == false) //se trata de alta de reserva
				{

					this.NuevoAlojamiento.SetClientes(this.Acompañantes);
					new ControladorCliente().ControlCapacidadConClientes(this.NuevoAlojamiento.Clientes, HabSeleccionada);
					new ControladorAlojamiento().ComprobarClientesAltaConReserva(this.NuevoAlojamiento, txb_CostoBase.Text);
					
					//this.NuevoAlojamiento.Habitacion.OcuparCupos(this.NuevoAlojamiento.CantCuposSimples, this.NuevoAlojamiento.iCantCuposDobles);
					
				}
				else if (Acompañantes.Contains(this.ClienteResponsable))//Alta sin Reserva, crea nuevo alojamiento con estado Alojado
				{
					new ControladorCliente().ControlCapacidadConClientes(Acompañantes, HabSeleccionada);

					//HabSeleccionada.OcuparCupos(Convert.ToByte(cont_CuposSimples.Value), Convert.ToByte(cont_CuposDobles.Value));

					this.NuevoAlojamiento = new Alojamiento(HabSeleccionada, ClienteResponsable, Acompañantes, FechaIni, FechaFin, HabSeleccionada.Exclusiva);
					NuevoAlojamiento.CalcularCostoBase(new List<TarifaCliente>());
				}
				else
				{
					throw new Exception("El Cliente Responsable no se encuentra en la lista de Clientes.");
				}

				txb_CostoBase.Text = NuevoAlojamiento.MontoTotal.ToString();
				btn_Comprobar.Enabled = false;

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
        }

        private void dtp_fechaHasta_ValueChanged(object sender, EventArgs e)
        {
            this.FechaFin = dtp_fechaHasta.Value.Date;
			txb_NroHabitacion.Text = "";
			ck_Exclusividad.Checked = false;

			dGV_ClienteResponsable.Rows.Clear();

			if (this.Acompañantes.Count > 1)
			{
				dGV_Acompañantes.Rows.Clear();
				this.Acompañantes.Clear();
			};

			groupBox4.Enabled = false;
			groupBox2.Enabled = false;
			groupBox3.Enabled = false;
			btn_Comprobar.Enabled = false;
		}

        private void ck_Exclusividad_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_VerificarDisponibilidad.Enabled) // Nuevo Aloj
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
            groupBox3.Enabled = !pValorEnable; //
            btn_AgregarAcompañante.Enabled = !pValorEnable;
            btn_quitarCliente.Enabled = !pValorEnable;
            groupBox4.Enabled = pValorEnable; //habitacion

            btn_Comprobar.Enabled = !pValorEnable;
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
                //cont_CuposSimples.Value = HabSeleccionada.CuposSimpleDisponibles();
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
                //cont_CuposDobles.Value = HabSeleccionada.CuposDoblesDisponibles();
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
				if (auxCliente.TarifaCliente.TarifaClienteId == TipoCliente.TitularExceptuado)
				{
					if (!Acompañantes.Exists(c => c.TarifaCliente.TarifaClienteId == TipoCliente.TitularExceptuado))
					{
						ck_Exclusividad.Enabled = exclusividadCapacidad; 
					}
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

        private void btn_Comprobar_MouseHover(object sender, EventArgs e)
        {
            label14.Visible = true;
            btn_Comprobar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btn_Comprobar_MouseLeave(object sender, EventArgs e)
        {
            label14.Visible = false;
            btn_Comprobar.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
