using System;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class ActualizarCostoServicio : Form
    {
        Servicio Service;

        public ActualizarCostoServicio()
        {
            InitializeComponent();
        }

        public void CargarServicioSeccionado()
        {
            dataGridView_Servicio.Rows.Clear();
            dataGridView_Servicio.Rows.Add(Service.ServicioId, Service.Nombre, Service.CostoBase, Service.Detalle);
        }

        private void btn_buscarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                AdministrarServicios Actualizar = new AdministrarServicios();
                Actualizar.ShowDialog();
                if (Actualizar.ServicioSeleccionado != null)
                {
                    this.Service = Actualizar.ServicioSeleccionado;
                    CargarServicioSeccionado();
                    btn_Aceptar.Enabled = true;
					txb_nuevoCosto.Enabled = true;
					txb_nuevoCosto.Text = "";
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
                new ControladorExtra().AcutalizarCostoServicio(this.Service, txb_nuevoCosto.Text);
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Servicio Actualizado", TipoMensaje.Exito);
                ventanaEmergente.ShowDialog();
                Close();
                AdministrarServicios Actualizar = new AdministrarServicios();
                Actualizar.Show();
				Actualizar.SetVisible(false);
            }
            catch (FormatException)
            {
                if (txb_nuevoCosto.Text == "")
                {
                    new VentanaEmergente("Debe ingresar un nuevo Costo", TipoMensaje.Alerta).ShowDialog();
                }
                else
                {
                    new VentanaEmergente("Costo Incorrecto: se deben ingresar solo números", TipoMensaje.Alerta).ShowDialog();
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
