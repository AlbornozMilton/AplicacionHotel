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
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iControladorCliente.CargarCiudad(Convert.ToInt32(textBox8.Text), textBox7.Text);
            iControladorCliente.CargarDomicilio(textBox6.Text, textBox5.Text, textBox9.Text, textBox10.Text);
            iControladorCliente.NuevoCliente(textBox1.Text,textBox3.Text,textBox2.Text,textBox4.Text);
            MessageBox.Show("Cliente agregado correctamente");
            Close();
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
