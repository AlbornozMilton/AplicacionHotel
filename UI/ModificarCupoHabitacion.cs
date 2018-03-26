using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;
using System.Drawing;

namespace UI
{
    public partial class ModificarCupoHabitacion : Form
    {
        Habitacion HabSeleccionada;

        public ModificarCupoHabitacion()
        {
            InitializeComponent();
        }

        private void CargarHabitacion()
        {
            dGV_Habs.Rows.Clear();
			dGV_Habs.Rows.Add(
				this.HabSeleccionada.HabitacionId,
				this.HabSeleccionada.Planta == 0 ? "Baja" : "Alta",
				this.HabSeleccionada.Capacidad,
				this.HabSeleccionada.Alta ? "En Alta" : "En Baja"
				);

			if (this.HabSeleccionada.Alta)
			{
				btn_alta.Text = "Dar de Baja";
				btn_alta.BackColor = Color.Red;
			}
			else
			{
				btn_alta.Text = "Dar de Alta";
				btn_alta.BackColor = Color.Green;
			}
		}

		private void btn_buscarHab_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultarHabitaciones consultarHabitaciones = new ConsultarHabitaciones(true);
                consultarHabitaciones.ShowDialog();
                if (consultarHabitaciones.HabSeleccionada != null)
                {
					List<Alojamiento> auxListaAlojs = new ControladorHabitacion().ControlModificarAltaHabitacion(consultarHabitaciones.HabSeleccionada.HabitacionId);
                    if (auxListaAlojs.Count == 0)
                    {
						this.HabSeleccionada = consultarHabitaciones.HabSeleccionada;
						CargarHabitacion();
						btn_confirmar.Enabled = true;
						btn_alta.Visible = true;
                    }
                    else
                    {
                        VentanaEmergente ventanaEmergente = new VentanaEmergente("No es posible la Habitación seleccionada ya que se encuentra Activa en los siguientes Alojamientos", TipoMensaje.Alerta);
                        ventanaEmergente.ShowDialog();
                        dGV_Habs.Rows.Clear();
                        ListarAlojamientos ListarAlojs = new ListarAlojamientos(auxListaAlojs);
                        ListarAlojs.ShowDialog();
                    }
                }
            }
            catch (Exception E)
            {
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            new ControladorHabitacion().ModificarAltaDeHabitacion(HabSeleccionada);
            VentanaEmergente ventanaEmergente = new VentanaEmergente("Modificacion de Cupos Exitosa", TipoMensaje.Exito);
            ventanaEmergente.ShowDialog();
			ConsultarHabitaciones consultarHabitaciones = new ConsultarHabitaciones();
			consultarHabitaciones.ShowDialog();
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void btn_alta_Click(object sender, EventArgs e)
		{
			if (btn_alta.Text == "Dar de Baja")
				HabSeleccionada.DarDeBaja();
			else
				HabSeleccionada.DarDeAlta();
			CargarHabitacion();

		}
	}
}
