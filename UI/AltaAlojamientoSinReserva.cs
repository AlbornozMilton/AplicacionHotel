using System;
using System.Collections.Generic;
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
        }

		private void AltaAlojamientoSinReserva_Load(object sender, EventArgs e)
		{
			txb_fechaActual.Text = DateTime.Today.ToString("dd/MM/yy");
			txb_fechaActual.Enabled = false;
			txb_CostoBase.Enabled = false;
			dtp_fechaDesde.Value = DateTime.Now;
			dtp_fechaDesde.Enabled = false;
			//FechaIni = dtp_fechaDesde.Value;
			dtp_fechaHasta.Value = DateTime.Now.AddDays(1);
			//FechaFin = dtp_fechaHasta.Value;
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
					this.HabSeleccionada = TablaDisp.HabSeleccionada;

					exclusividadCapacidad = new ControladorAlojamiento().ExclusividadSegunCapacidad(FechaIni, FechaFin, 20);
					if (!exclusividadCapacidad)//si es falso que entre
                    {
                        VentanaEmergente ventanaEmergente = new VentanaEmergente("No se permite la exclusividad de la Habitación porque para las fechas deseadas se supera el límite de exclusividad de la capacidad del Hotel", TipoMensaje.Alerta);
                        ventanaEmergente.ShowDialog();
						ck_Exclusividad.Enabled = exclusividadCapacidad;
                    }
					//lenar campos de Habitación
					txb_NroHabitacion.Text = Convert.ToString(this.HabSeleccionada.HabitacionId);
					txb_planta.Text = this.HabSeleccionada.Planta == 0 ? "Baja" : "Alta";
					txb_capacidad.Text = Convert.ToString(this.HabSeleccionada.Capacidad);

					//limpiar Responsable y Acompañantes
					dGV_ClienteResponsable.Rows.Clear();
					ClienteResponsable = null;
					this.Acompañantes.Clear();
					dGV_Acompañantes.Rows.Clear();

					groupBox4.Enabled = true; //HABITACION
					groupBox2.Enabled = true; //RESPONSABLE
					//groupBox3.Enabled = true; //ACOMPAÑANTES
				}
				else if (HabSeleccionada == null)
				{
					VentanaEmergente ventanaEmergente = new VentanaEmergente("Debe elegir una Habitación para continuar", TipoMensaje.Alerta);
					ventanaEmergente.ShowDialog();
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
					//Excepción cliente activo
					new ControladorCliente().ControlClienteActivo(this.ClienteResponsable, FechaIni, FechaFin, new ControladorAlojamiento().ObtenerAlojamientosActivos());

					//AVISO DE CLIENTE DEUDOR

					dGV_ClienteResponsable.Rows.Clear();
					this.ClienteResponsable = BuscarClienteForm.ClienteSeleccionado;

					switch (ClienteResponsable.TarifaCliente.TarifaClienteId)
					{
						case TipoCliente.Titular:
							{
								ck_Exclusividad.Enabled = exclusividadCapacidad;
							}
							break;
						case TipoCliente.AcompanianteDirecto:
							{
								VentanaEmergente ventanaEmergente = new VentanaEmergente("El Cliente Responsable que eligió no es Titular, queda a su criterio continuar con la carga", TipoMensaje.Alerta);
								ventanaEmergente.ShowDialog();
								ck_Exclusividad.Enabled = exclusividadCapacidad;
							}
							break;
						case TipoCliente.AcompanianteNoDirecto:
							{
								VentanaEmergente ventanaEmergente = new VentanaEmergente("El Cliente Responsable que eligió no es Titular, queda a su criterio continuar con la carga", TipoMensaje.Alerta);
								ventanaEmergente.ShowDialog();
								ck_Exclusividad.Enabled = exclusividadCapacidad;
							}
							break;
						case TipoCliente.TitularExceptuado:
							{
								ck_Exclusividad.Checked = false;
							}
							break;
						case TipoCliente.Convenio:
							{
								ck_Exclusividad.Enabled = exclusividadCapacidad;
							}
							break;
					}

					dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Legajo, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.TarifaCliente.NombreTarifa);

					groupBox3.Enabled = true; //ACOMPAÑANTES
					btn_Comprobar.Enabled = true;
					dGV_Acompañantes.Rows.Clear();
					Acompañantes.Clear();
					Acompañantes.Add(ClienteResponsable);
				}
				else
				if (ClienteResponsable == null)
				{
					throw new Exception("Debe seleccionar un Cliente para continuar");
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
			try
			{
				if (Acompañantes.Count + 1 > Convert.ToInt32(txb_capacidad.Text))
					throw new Exception("Se Supera la capacidad de la Habitación");

				if (Acompañantes.Count > 0 && ck_Exclusividad.Checked == true)
				{
					throw new Exception("Solo se permite Exclusividad para un Cliente");
				}

				BuscarCliente BuscarClienteForm = new BuscarCliente();
				BuscarClienteForm.setEnableAltas(false);
				BuscarClienteForm.ShowDialog();
				Cliente acomp = BuscarClienteForm.ClienteSeleccionado;

				if (acomp != null)
				{

					if (ClienteResponsable.TarifaCliente.TarifaClienteId == TipoCliente.Convenio
						&&
						acomp.TarifaCliente.TarifaClienteId != TipoCliente.Convenio)
					{
						throw new Exception("Debido al Responsable, solo se admiten Clientes Con Convenio");
					}

					if (ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.Convenio
						&&
						acomp.TarifaCliente.TarifaClienteId == TipoCliente.Convenio)
					{
						throw new Exception("Debido al Responsable, solo se admiten Clientes Sin Convenio");
					}

					if (Acompañantes.Contains(BuscarClienteForm.ClienteSeleccionado))
						throw new Exception("El Cliente elegido ya se encuentra entre los Clientes seleccionados");

					new ControladorCliente().ControlClienteActivo(BuscarClienteForm.ClienteSeleccionado, FechaIni, FechaFin, iAlojsActivos);

					//AVISO CLIENTE ADEUDOR

					dGV_Acompañantes.Rows.Add(acomp.ClienteId, acomp.Legajo, acomp.Apellido, acomp.Nombre, acomp.TarifaCliente.NombreTarifa);
					this.Acompañantes.Add(acomp); 
				}
			}
			catch (Exception E)
			{
				VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
				ventanaEmergente.ShowDialog();
			}
        }

		private void btn_quitarCliente_Click(object sender, EventArgs e)
		{
			if (dGV_Acompañantes.CurrentRow != null)
			{
				Acompañantes.Remove(Acompañantes.Find(c => c.ClienteId == Convert.ToInt32(dGV_Acompañantes.CurrentRow.Cells[0].Value)));
				dGV_Acompañantes.Rows.Remove(dGV_Acompañantes.CurrentRow);
			}
		}

		private void btn_Comprobar_Click(object sender, EventArgs e)
		{
			try
			{
				if (!btn_VerificarDisponibilidad.Enabled) //se trata de alta de reserva
				{
					this.NuevoAlojamiento.SetClientes(this.Acompañantes);
					new ControladorCliente().ControlCapacidadConClientes(this.NuevoAlojamiento.Clientes, HabSeleccionada);
					new ControladorAlojamiento().ComprobarClientesAltaConReserva(this.NuevoAlojamiento, txb_CostoBase.Text);
					NuevoAlojamiento.Habitacion.OcuparHabitacion();
				}
				else
				{
					new ControladorCliente().ControlCapacidadConClientes(Acompañantes, HabSeleccionada);
					HabSeleccionada.OcuparHabitacion();
					this.NuevoAlojamiento = new Alojamiento(HabSeleccionada, ClienteResponsable, Acompañantes, FechaIni, FechaFin, HabSeleccionada.Exclusiva);
					NuevoAlojamiento.CalcularCostoBase(new List<TarifaCliente>());
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
                if (btn_VerificarDisponibilidad.Enabled) //Alta sin Reserva
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

		//Esta deshabilitado
        private void dtp_fechaDesde_ValueChanged(object sender, EventArgs e)
        {
            this.FechaIni = dtp_fechaDesde.Value;
        }

        private void dtp_fechaHasta_ValueChanged(object sender, EventArgs e)
        {
            this.FechaFin = dtp_fechaHasta.Value.Date;
			txb_NroHabitacion.Text = "";
			txb_capacidad.Text = "";
			//ck_Exclusividad.CheckState = CheckState.Checked;
			ck_Exclusividad.Checked = false;
			dGV_ClienteResponsable.Rows.Clear();
			dGV_Acompañantes.Rows.Clear();
			ClienteResponsable = null;
			Acompañantes.Clear();
			groupBox4.Enabled = false;
			groupBox2.Enabled = false;
			groupBox3.Enabled = false;
			btn_Comprobar.Enabled = false;
		}

        private void ck_Exclusividad_CheckedChanged(object sender, EventArgs e)
        {
            if (Acompañantes.Count > 1) //no excl para mas de un cliente
            {
				VentanaEmergente ventanaEmergente = new VentanaEmergente("Solo se permite Exclusividad para un Cliente", TipoMensaje.Alerta);
				ventanaEmergente.ShowDialog();
			}
			else if (ClienteResponsable != null && ClienteResponsable.TarifaCliente.TarifaClienteId == TipoCliente.TitularExceptuado)
			{
				if (ck_Exclusividad.Checked == false)
				{
					VentanaEmergente ventanaEmergente = new VentanaEmergente("No se permite Exclusividad para Cliente Exceptuado", TipoMensaje.Alerta);
					ventanaEmergente.ShowDialog(); 
				}
				ck_Exclusividad.Checked = false;
			} // no se cumple la excl cuando se comaprte
			else
				this.HabSeleccionada.SetExclusividad(this.ck_Exclusividad.Checked);
		}

		/// <summary>
		/// Modifica el campo Enable de una conjunto de propiedades de la Form al valor de parámetro
		/// </summary>
		public void EnableAll(bool pValorEnable)//true
        {
            
        }

        #region Alta de Reserva
        public void RellenarCampos()
        {
            txb_IdAloj.Text = NuevoAlojamiento.AlojamientoId.ToString();
            dtp_fechaDesde.Value = NuevoAlojamiento.FechaEstimadaIngreso;
            dtp_fechaHasta.Value = NuevoAlojamiento.FechaEstimadaEgreso;
            txb_NroHabitacion.Text = NuevoAlojamiento.HabitacionId.ToString();
			txb_capacidad.Text = NuevoAlojamiento.Habitacion.Capacidad.ToString();
			txb_planta.Text = NuevoAlojamiento.Habitacion.Planta == 0 ? "Baja" : "Alta";

			HabSeleccionada = NuevoAlojamiento.Habitacion;
            ck_Exclusividad.Checked = NuevoAlojamiento.Exclusividad;
			//ck_Exclusividad.CheckState = NuevoAlojamiento.Exclusividad == true ? CheckState.Checked:CheckState.Unchecked;

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
			groupBox1.Enabled = false; //disponibilidad
			groupBox3.Enabled = true; // Acompañantes
			btn_Comprobar.Enabled = true;
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
