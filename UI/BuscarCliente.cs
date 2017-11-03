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
    public partial class BuscarCliente : Form
    {
        ControladorCliente iControladorCliente = new ControladorCliente();
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.boton_buscar_seleccion2;
            label3.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.boton_buscar;
            label3.Visible = false;
        }

        private void textBox2_ReadOnlyChanged(object sender, EventArgs e)
        {
            textBoxDNI.ReadOnly = true;            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.ReadOnly == true)
            {
                textBoxNombre.ReadOnly = false;
            }
            else
            {
                textBoxNombre.ReadOnly = true;
                textBoxDNI.ReadOnly = false;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Persistencia.Domain.Cliente cli = iControladorCliente.BuscarCliente((Convert.ToInt32(textBoxDNI.Text)));
            if (cli != null)
            {
                tablaResulClientes.Rows.Add(cli.ClienteId, cli.Apellido, cli.Nombre, cli.Telefono);
            }
            else
            {
                MessageBox.Show("Cliente NO Existe");
            }
        }
    }
}
