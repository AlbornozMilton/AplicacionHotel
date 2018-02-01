using System;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class ActualizarCostoServicio : Form
    {
        Servicio ServicioSeleccionado;

        public ActualizarCostoServicio()
        {
            InitializeComponent();
            txb_nuevoCosto.Enabled = false;
            btn_Aceptar.Enabled = false;
        }

        public void CargarServicioSeccionado(Servicio pServicio)
        {
            dataGridView_Servicio.Rows.Clear();
            dataGridView_Servicio.Rows.Add(pServicio.ServicioId, pServicio.Nombre, pServicio.CostoBase,pServicio.Detalle);
        }

        private void btn_buscarServicio_Click(object sender, EventArgs e)
        {
            AdministrarServicios Actualizar = new AdministrarServicios();
            Actualizar.ShowDialog();
            if (Actualizar.ServicioSeleccionado != null)
            {
                this.ServicioSeleccionado = Actualizar.ServicioSeleccionado;
                CargarServicioSeccionado(this.ServicioSeleccionado);
                txb_nuevoCosto.Enabled = true;
                btn_Aceptar.Enabled = true;
            }
            else
            {
                dataGridView_Servicio.Rows.Clear();
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
                new ControladorExtra().AcutalizarCostoServicio(this.ServicioSeleccionado, txb_nuevoCosto.Text);
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Servicio Actualizado", TipoMensaje.Exito);
                ventanaEmergente.ShowDialog();
                Close();
                AdministrarServicios Actualizar = new AdministrarServicios();
                Actualizar.ShowDialog();
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
