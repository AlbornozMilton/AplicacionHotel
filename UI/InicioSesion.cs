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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new Dominio.ControladorCliente().ValidarUsuario(textBox1.Text, textBox2.Text))
            {
                Hide();
                VentanaPrincipal NuevaVentanaPpal = new VentanaPrincipal();
                NuevaVentanaPpal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario NO Registrado");
            }
            
        }
    }
}
