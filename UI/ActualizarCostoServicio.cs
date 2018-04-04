using System;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class ActualizarCostoServicio : Form
    {
        Servicio Servicio;

        public ActualizarCostoServicio()
        {
            InitializeComponent();
        }

		public void ElimiarServicio()
		{
			Text = "Eliminar Servicio";
			lbl_textIngreseCosto.Visible = false;
			txb_nuevoCosto.Visible = false;
		}

        public void CargarServicioSeccionado()
        {
            dataGridView_Servicio.Rows.Clear();
            dataGridView_Servicio.Rows.Add(Servicio.ServicioId, Servicio.Nombre, Servicio.CostoBase, Servicio.Detalle);
        }

        private void btn_buscarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                AdministrarServicios Actualizar = new AdministrarServicios(true);
				Actualizar.ShowDialog();
                if (Actualizar.ServicioSeleccionado != null)
                {
                    this.Servicio = Actualizar.ServicioSeleccionado;
                    CargarServicioSeccionado();
                    btn_Aceptar.Enabled = true;

					if (Text != "Eliminar Servicio")
					{
						txb_nuevoCosto.Enabled = true;
						txb_nuevoCosto.Text = ""; 
					}
				}
            }
            catch (Exception E)
            {
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
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
				string mensaje = "Error de Asiganción de Mensaje";

				if (Text != "Eliminar Servicio")
				{
					mensaje = "Servicio Actualizado";
					new ControladorExtra().AcutalizarCostoServicio(this.Servicio, txb_nuevoCosto.Text);
				}
				else
				{
					mensaje = "Servicio Eliminado";
					new ControladorExtra().EliminarServicio(this.Servicio);
				}

				VentanaEmergente ventanaEmergente = new VentanaEmergente(mensaje, TipoMensaje.Exito);
				ventanaEmergente.ShowDialog();
				Close();
				AdministrarServicios Actualizar = new AdministrarServicios();
                Actualizar.ShowDialog();
            }
            catch (FormatException)
            {
                if (txb_nuevoCosto.Text == "")
                {
                    new VentanaEmergente("Debe ingresar un Costo", TipoMensaje.Alerta).ShowDialog();
                }
                else
                {
                    new VentanaEmergente("Solo ingresar Números", TipoMensaje.Alerta).ShowDialog();
                }
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }
    }
}
