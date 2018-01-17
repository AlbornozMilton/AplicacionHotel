using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ActualizarTarifas : Form
    {
        public ActualizarTarifas()
        {
            InitializeComponent();
        }

        private void btn_ConsultarTarifas_Click(object sender, EventArgs e)
        {
            ConsultarTarifas VentanaTarifas = new ConsultarTarifas();
            VentanaTarifas.ShowDialog();
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
