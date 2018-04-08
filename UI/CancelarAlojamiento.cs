using System;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class CancelarAlojamiento : Form
    {
        Alojamiento Aloj_Seleccionado;

        public CancelarAlojamiento()
        {
            InitializeComponent();
            lbl_fechaActual.Text = DateTime.Today.ToString("dd / MM / yyyy");
        }

        private void CargarAlojamientoSeccionado()
        {
            dGV_ListadoAlojamientos.Rows.Clear();
        }

        private void btn_BuscarAlojamiento_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento BuscarAlojamiento = new BuscarAlojamiento();
            BuscarAlojamiento.ShowDialog();
			try
			{
				if (BuscarAlojamiento.Aloj_Seleccionado != null)
				{
					if (BuscarAlojamiento.Aloj_Seleccionado.EstadoAlojamiento != EstadoAlojamiento.Reservado)
					{
						throw new Exception("Solo se realiza la Cancelación de Alojamientos en Estado Reservado");
					}

					this.Aloj_Seleccionado = BuscarAlojamiento.Aloj_Seleccionado;
					CargarAlojamientoSeccionado();
					btn_Aceptar.Enabled = true;
				}
			}
			catch (Exception E)
			{
				if (Aloj_Seleccionado != null && Aloj_Seleccionado.EstadoAlojamiento == EstadoAlojamiento.Reservado)
					btn_Aceptar.Enabled = true;
				else
					btn_Aceptar.Enabled = false;

				VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
				ventanaEmergente.ShowDialog();
			}
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
			if (Aloj_Seleccionado != null)
			{
				VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(Aloj_Seleccionado);
				VentanaVisualizar.ShowDialog(); 
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
                new ControladorAlojamiento().CancelarAlojamiento(Aloj_Seleccionado);
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Cancelación de Reserva Exitosa", TipoMensaje.Exito);
                ventanaEmergente.ShowDialog();
                Close();
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }
    }
}
