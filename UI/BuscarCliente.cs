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
        public AltaReservaAlojamiento FormPadre;
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
            btn_Buscar.Image = Properties.Resources.boton_buscar_seleccion2;
            label3.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btn_Buscar.Image = Properties.Resources.boton_buscar;
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

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Cliente cli = iControladorCliente.BuscarClientePorDni((Convert.ToInt32(textBoxDNI.Text)));
                if (cli != null)
                {
                    tablaResulClientes.Rows.Add(cli.ClienteId, cli.Apellido, cli.Nombre, cli.Telefono);
                }
                else
                {
                    MessageBox.Show("Cliente NO Existe");
                }
            }
            else
            {
                tablaResulClientes.Rows.Clear();
                List<Cliente> list = iControladorCliente.BuscarClientePorNom_Ape(textBoxNombre.Text);
                foreach (var cli in list)
                {
                    tablaResulClientes.Rows.Add(cli.ClienteId, cli.Apellido, cli.Nombre, cli.Telefono);
                }
            }
            
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            tablaResulClientes.DefaultCellStyle.Font = new Font("BankGothic Lt BT", 12);
            tablaResulClientes.ColumnHeadersDefaultCellStyle.Font = new Font("BankGothic Lt BT", 12);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            FormPadre.agregar_Cliente(tablaResulClientes.CurrentRow.Cells);
            Close();
        }
    }
}
