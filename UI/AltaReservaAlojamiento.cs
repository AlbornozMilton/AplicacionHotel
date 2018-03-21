using System;
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
		private bool exclusividadCapacidad;

		public AltaReservaAlojamiento()
        {
            InitializeComponent();
			txb_fechaActual.Text = DateTime.Now.ToString("dd/MM/yy");
			dtp_fechaDesde.Value = DateTime.Now;
			dtp_fechaHasta.Value = DateTime.Now.AddDays(1);
		}

		private void AltaReservaAlojamiento_Load(object sender, EventArgs e)
		{
			FechaIni = DateTime.Now;
			FechaFin = DateTime.Now.AddDays(1);
		}

		private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label14.Visible = true;
            btn_Confirmar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            label14.Visible = false;
            btn_Confirmar.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_VerificarDisponibilidad_Click(object sender, EventArgs e)
        {
            if (FechaIni.CompareTo(FechaFin) == -1)
            {
                TablaDisponibilidad TablaDisp = new TablaDisponibilidad(FechaIni, FechaFin);
                TablaDisp.ShowDialog();

                if (TablaDisp.HabSeleccionada != null)
                {
					this.HabSeleccionada = TablaDisp.HabSeleccionada;
					//Almacenar si se supero el 20% de exlcuisividad permitida. Por defecto este campo va a estar en True
					this.exclusividadCapacidad = new ControladorAlojamiento().ExclusividadSegunCapacidad(FechaIni, FechaFin, 20);
					if (!exclusividadCapacidad)//si es falso que entre
					{
						VentanaEmergente ventanaEmergente = new VentanaEmergente("No se permite la exclusividad de la Habitación porque para las Fechas elegidas se supera el límite de exclusividad", TipoMensaje.Alerta);
						ventanaEmergente.ShowDialog();
						ck_Exclusividad.Enabled = this.exclusividadCapacidad;
					}
					//LLenar campos de Habitación
					tbx_NroHab.Text = Convert.ToString(this.HabSeleccionada.HabitacionId);
					txb_planta.Text = this.HabSeleccionada.Planta == 0 ? "Baja":"Alta";
					txb_capacidad.Text = Convert.ToString(this.HabSeleccionada.Capacidad);

					dGV_ClienteResponsable.Rows.Clear();
					ClienteResponsable = null;
					groupBox4.Enabled = true; //HABIACION
					groupBox2.Enabled = true; //RESPONSABLE
				}
				else if (HabSeleccionada == null)
				{
					VentanaEmergente ventanaEmergente = new VentanaEmergente("Debe elegir una Habitación para continuar", TipoMensaje.Alerta);
					ventanaEmergente.ShowDialog();
				}
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("La Fecha de Egreso debe ser Mayor a la Fecha de Ingreso", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
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
					//Excepción cliente activo
					new ControladorCliente().ControlClienteActivo(BuscarClienteForm.ClienteSeleccionado, FechaIni, FechaFin, new ControladorAlojamiento().ObtenerAlojamientosActivos());

					//AVISO DE CLIENTE DEUDOR
					this.ClienteResponsable = BuscarClienteForm.ClienteSeleccionado;
					dGV_ClienteResponsable.Rows.Clear();
					contador_Convenio.Value = 0;
					contador_Convenio.Enabled = true;
					contador_Titular.Value = 0;
					contador_Titular.Enabled = true;
					contador_Directo.Value = 0;
					contador_Directo.Enabled = true;
					contador_NoDirecto.Value = 0;
					contador_NoDirecto.Enabled = true;
					contador_Exceptuado.Value = 0;
					contador_Exceptuado.Enabled = true;

					switch (ClienteResponsable.TarifaCliente.TarifaClienteId)
					{
						case TipoCliente.Titular:
							{
								contador_Convenio.Enabled = false;
								ck_Exclusividad.Enabled = exclusividadCapacidad;
							}
							break;
						case TipoCliente.AcompanianteDirecto:
							{
								contador_Convenio.Enabled = false;
								VentanaEmergente ventanaEmergente = new VentanaEmergente("El Cliente Responsable que eligió no es Titular, queda a su criterio continuar con la carga", TipoMensaje.Alerta);
								ventanaEmergente.ShowDialog();
								ck_Exclusividad.Enabled = exclusividadCapacidad;
							}
							break;
						case TipoCliente.AcompanianteNoDirecto:
							{
								contador_Convenio.Enabled = false;
								VentanaEmergente ventanaEmergente = new VentanaEmergente("El Cliente Responsable que eligió no es Titular, queda a su criterio continuar con la carga", TipoMensaje.Alerta);
								ventanaEmergente.ShowDialog();
								ck_Exclusividad.Enabled = exclusividadCapacidad;
							}
							break;
						case TipoCliente.TitularExceptuado:
							{
								contador_Convenio.Enabled = false;
								//VentanaEmergente ventanaEmergente = new VentanaEmergente("Debido a que el Cliente Responsable es de Tipo Exceptuado, no es posible solicitar la Exclusividad de la Habitación", TipoMensaje.Alerta);
								//ventanaEmergente.ShowDialog();
								ck_Exclusividad.Checked = false;
							}
							break;
						case TipoCliente.Convenio:
							{
								contador_Titular.Enabled = false;
								contador_Directo.Enabled = false;
								contador_NoDirecto.Enabled = false;
								contador_Exceptuado.Enabled = false;
								ck_Exclusividad.Enabled = exclusividadCapacidad;
							}
							break;
					}
						
                    dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Legajo, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.TarifaCliente.NombreTarifa);
                    btn_Confirmar.Enabled = true;
					if (!ck_Exclusividad.Checked)
					{
						groupBox3.Enabled = true; //ACOMPAÑANTES 
					}
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

					new ControladorCliente().ControlContadoresConClientes(ClienteResponsable, contadores,txb_capacidad.Text);

					this.NuevoAlojamiento = new Alojamiento(contadores, HabSeleccionada, ClienteResponsable, FechaIni, FechaFin, HabSeleccionada.Exclusiva);

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
				else if (ClienteResponsable == null)
					throw new Exception("Debe elegir un Cliente como Responsable");
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdAloj = new ControladorAlojamiento().RegistrarAloj(this.NuevoAlojamiento);
				VentanaEmergente ventanaEmergente = new VentanaEmergente("Reserva de Alojamiento Exitosa", TipoMensaje.ReservaExitosa, IdAloj);
				ventanaEmergente.ShowDialog();
                Close();
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private void ck_Exclusividad_CheckedChanged(object sender, EventArgs e)
        {
			if (ClienteResponsable != null && ClienteResponsable.TarifaCliente.TarifaClienteId == TipoCliente.TitularExceptuado)
			{
				if (ck_Exclusividad.Checked == false)
				{
					VentanaEmergente ventanaEmergente = new VentanaEmergente("No se permite Exclusividad para Cliente Exceptuado", TipoMensaje.Alerta);
					ventanaEmergente.ShowDialog();
				}
				ck_Exclusividad.Checked = false;

				groupBox3.Enabled = true;
			}
			else if (ck_Exclusividad.Checked == true)
			{
				groupBox3.Enabled = false;
				contador_Titular.Value = 0;
				contador_Convenio.Value = 0;
				contador_Directo.Value = 0;
				contador_NoDirecto.Value = 0;
				contador_Exceptuado.Value = 0;
			}
			else if (ck_Exclusividad.Checked == false)
			{
				groupBox3.Enabled = true;
			}
			this.HabSeleccionada.SetExclusividad(this.ck_Exclusividad.Checked);
        }

        #region Ingreso de Fechas en Calendario
        //Cuando se lanze estos dos eventos, obligar a que realice una verificacion de disponibilidad o algo similar
        private void dtp_fechaDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                new ControladorAlojamiento().ControlPlazoParaReservar(dtp_fechaDesde.Value.Date);
                this.FechaIni = dtp_fechaDesde.Value;

            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
			}
			finally
			{
				Limpiar();
			}
		}

        private void dtp_fechaHasta_ValueChanged(object sender, EventArgs e)
        {
            this.FechaFin = dtp_fechaHasta.Value;
			Limpiar();
        }

		private void Limpiar()
		{
			tbx_NroHab.Text = "";
			txb_capacidad.Text = "";
			txb_planta.Text = "";
			ck_Exclusividad.Checked = false;
			ClienteResponsable = null;
			dGV_ClienteResponsable.Rows.Clear();
			contador_Titular.Value = 0;
			contador_Directo.Value = 0;
			contador_NoDirecto.Value = 0;
			contador_Exceptuado.Value = 0;
			contador_Convenio.Value = 0;

			btn_Confirmar.Enabled = false;
			groupBox4.Enabled = false;
			groupBox3.Enabled = false;
			groupBox2.Enabled = false;
		}
        #endregion

		//REGLAS PARA TIPOS DE CLIENTES EN UN HABITACION Y SU EXCLUSIVIDAD
        private void contador_Exceptuado_ValueChanged(object sender, EventArgs e)
        {
			//HabSeleccionada.SetExclusividad(false);
			//ck_Exclusividad.Enabled = false;
			//ck_Exclusividad.Checked = false; 
			//contador_Convenio.Value = 0;
			//contador_Convenio.Enabled = false;
            //if(contador_Exceptuado.Value == 0 && ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.TitularExceptuado) //para evitar duplicacion de aviso
            //{
            //    ck_Exclusividad.Enabled = exclusividadCapacidad;
            //}
        }

		private void contador_Titular_ValueChanged(object sender, EventArgs e)
		{
			//contador_Convenio.Value = 0;
			//contador_Convenio.Enabled = false;
		}

		private void contador_Directo_ValueChanged(object sender, EventArgs e)
		{
			//contador_Convenio.Value = 0;
			//contador_Convenio.Enabled = false;
		}

		private void contador_NoDirecto_ValueChanged(object sender, EventArgs e)
		{
			//contador_Convenio.Value = 0;
			//contador_Convenio.Enabled = false;
		}

		private void contador_Convenio_ValueChanged(object sender, EventArgs e)
		{
			//contador_Titular.Value = 0;
			//contador_Titular.Enabled = false;
			//contador_Directo.Value = 0;
			//contador_Directo.Enabled = false;
			//contador_NoDirecto.Value = 0;
			//contador_NoDirecto.Enabled = false;
			//contador_Exceptuado.Value = 0;
			//contador_Exceptuado.Enabled = false;
		}
	}
}
