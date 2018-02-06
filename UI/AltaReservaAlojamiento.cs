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

					exclusividadCapacidad = new ControladorAlojamiento().ExclusividadSegunCapacidad(FechaIni, FechaFin, 20);

					if (!exclusividadCapacidad)//si es falso que entre
                    {
						VentanaEmergente ventanaEmergente = new VentanaEmergente("No se permite la exclusividad de la Habitación porque para las fechas deseadas se supera el límite de exclusividad de la capacidad del Hotel", TipoMensaje.Alerta);
                        ventanaEmergente.ShowDialog();
                        ck_Exclusividad.Enabled = exclusividadCapacidad;
                    }
                    else
                    {
						exclusividadCapacidad = new ControladorHabitacion().VerificarSolicitdExclusividad(this.HabSeleccionada) == HabSeleccionada.Capacidad();
						ck_Exclusividad.Enabled = exclusividadCapacidad;
                    }

					dGV_ClienteResponsable.Rows.Clear();
					ClienteResponsable = null;
                    groupBox4.Enabled = true;
                    groupBox2.Enabled = true;
                }
				else
				{
					VentanaEmergente ventanaEmergente = new VentanaEmergente("Las fechas seleccionadas no corresponden. Seleccione de nuevo.", TipoMensaje.Alerta);
					ventanaEmergente.ShowDialog();
				}
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Las fechas seleccionadas no corresponden. Seleccione de nuevo.", TipoMensaje.Alerta);
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

                    this.ClienteResponsable = BuscarClienteForm.ClienteSeleccionado;

                    new ControladorCliente().ControlClienteActivo(this.ClienteResponsable, FechaIni, FechaFin);

					if (ClienteResponsable.TarifaCliente.TarifaClienteId == TipoCliente.TitularExceptuado && ck_Exclusividad.Enabled == true)
                    {
                        VentanaEmergente ventanaEmergente = new VentanaEmergente("Debido a que el Cliente Responsable es de Tipo Exceptuado, no es posible solicitar la Exclusividad de la Habitación", TipoMensaje.Alerta);
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

					dGV_ClienteResponsable.Rows.Clear();
                    dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Legajo, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.TarifaCliente.NombreTarifa);
                    btn_Confirmar.Enabled = true;
                    groupBox3.Enabled = true;
                }
                else
                {
					dGV_ClienteResponsable.Rows.Clear();
					groupBox3.Enabled = false;
					throw new Exception("     Debe seleccionar un Cliente");
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

					new ControladorCliente().ControlCuposConClientes(ClienteResponsable, contadores, cont_CuposSimples.Value, cont_CuposDobles.Value);

					this.NuevoAlojamiento = new Alojamiento(contadores, HabSeleccionada, ClienteResponsable, FechaIni, FechaFin, Convert.ToByte(cont_CuposSimples.Value), Convert.ToByte(cont_CuposDobles.Value), HabSeleccionada.Exclusiva);

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
				else
					throw new Exception("Debe elegir un Clinete como Responsable");
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
				if (NuevoAlojamiento.Deposito != 0)
				{
					VentanaEmergente ventanaEmergente = new VentanaEmergente("Reserva de Alojamiento Exitosa", TipoMensaje.ReservaExitosa, IdAloj);
					ventanaEmergente.ShowDialog();
				}
				else
				{
					VentanaEmergente ventanaEmergente = new VentanaEmergente("Reserva de Alojamiento Exitosa", TipoMensaje.Exito);
					ventanaEmergente.ShowDialog();
				}
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
			cont_CuposDobles.Value = 0;
			cont_CuposSimples.Value = 0;
			ck_Exclusividad.Checked = false;
			ck_Exclusividad.Enabled = true;

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

        private void cont_CuposSimples_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                new ControladorHabitacion().VerificarCuposSimplesIngresados(this.HabSeleccionada, cont_CuposSimples.Value);
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
                cont_CuposSimples.Value = HabSeleccionada.CuposSimpleDisponibles();
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
                cont_CuposDobles.Value = HabSeleccionada.CuposDoblesDisponibles();
            }
        }

        private void contador_Exceptuado_ValueChanged(object sender, EventArgs e)
        {
            if (contador_Exceptuado.Value > 0)
            {
				if (ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.TitularExceptuado)
				{
					VentanaEmergente ventanaEmergente = new VentanaEmergente("Debido a que seleccionó un Cliente de Tipo Exceptuado, no es posible soliticar la exclusividad de la Habitación", TipoMensaje.Alerta);
					ventanaEmergente.ShowDialog();
					HabSeleccionada.SetExclusividad(false);
					ck_Exclusividad.Enabled = false;
					ck_Exclusividad.Checked = false; 
				}
            }
            else if(contador_Exceptuado.Value == 0 && ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.TitularExceptuado) //para evitar duplicacion de aviso
            {
                ck_Exclusividad.Enabled = exclusividadCapacidad;
            }
        }
    }
}
