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
            btn_Aceptar.Enabled = false;
        }

        public void CargarServicioSeccionado(Servicio pServicio)
        {
            dataGridView_Servicio.Rows.Clear();
            dataGridView_Servicio.Rows.Add(pServicio.ServicioId, pServicio.Nombre, pServicio.CostoBase);
        }

        private void btn_buscarServicio_Click(object sender, EventArgs e)
        {
            AdministrarServicios Actualizar = new AdministrarServicios();
            Actualizar.ShowDialog();
            if (Actualizar.ServicioSeleccionado != null)
            {
                this.ServicioSeleccionado = Actualizar.ServicioSeleccionado;
                CargarServicioSeccionado(this.ServicioSeleccionado);
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
            new ControladorExtra().AcutalizarCostoServicio(this.ServicioSeleccionado, txb_nuevoCosto.Text);
            MessageBox.Show("Servicio Actualizado");
            Close();
            AdministrarServicios Actualizar = new AdministrarServicios();
            Actualizar.ShowDialog();
        }
    }
}
