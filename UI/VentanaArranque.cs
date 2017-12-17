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
    public partial class VentanaArranque : Form
    {
        public VentanaArranque()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
                label2.Text = progressBar1.Value + "%";
                new Dominio.ControladorCliente().CargarUsuarios();
            }
            else
            {
                timer1.Enabled = false;
                Hide();
                InicioSesion ventanaIniSesion = new InicioSesion();
                ventanaIniSesion.ShowDialog();
                //VentanaPrincipal NuevaVentanaPpal = new VentanaPrincipal();
                //NuevaVentanaPpal.ShowDialog();
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
