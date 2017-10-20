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
            textBox1.ReadOnly = true;            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.ReadOnly == true)
            {
                textBox2.ReadOnly = false;
            }
            else
            {
                textBox2.ReadOnly = true;
                textBox1.ReadOnly = false;
            }
            
        }
    }
}
