using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class NuevoCliente : Form
    {
        ControladorCliente iControladorCliente = new ControladorCliente();
        Domicilio iDomicilio;
        Ciudad iCiudad;

        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.iCiudad = new Ciudad(3260,"CdelU");
            this.iDomicilio = new Domicilio("Alejo Peyret", 661, 8, 0, this.iCiudad);
            iControladorCliente.NuevoCliente(textBox1.Text,textBox3.Text,textBox2.Text,Convert.ToInt32(textBox4.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
