using Dominio;
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
    public partial class AgregarCiudad : Form
    {
        public AgregarCiudad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControladorCliente iControlador = new ControladorCliente();
            //this.iCiudad = new Ciudad(3260, "CdelU");
            iControlador.NuevaCiudad(Convert.ToInt32(textBox1.Text),textBox2.Text);
            //iControladorCliente.ExisteCliente(textBox1.Text, textBox3.Text, textBox2.Text, Convert.ToInt32(textBox4.Text));
        }
    }
}
