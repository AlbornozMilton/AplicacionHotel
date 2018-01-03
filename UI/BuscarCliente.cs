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
        public Cliente iClienteSeleccionado;
        public DataGridViewRow iFilaSeleccionada;
        ControladorCliente iControladorCliente = new ControladorCliente();
        public BuscarCliente()
        {
            InitializeComponent();
            btn_Aceptar.Enabled = false;
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
                try
                {
                    Cliente cli = iControladorCliente.BuscarClientePorDni((Convert.ToInt32(textBoxDNI.Text)));
                        tablaResulClientes.Rows.Add(cli.ClienteId, cli.Apellido, cli.Nombre, cli.Telefono);
                }
                catch (Exception pE)
                {
                    MessageBox.Show(pE.Message);
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
            btn_Aceptar.Enabled = true;
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            tablaResulClientes.DefaultCellStyle.Font = new Font("BankGothic Lt BT", 12);
            tablaResulClientes.ColumnHeadersDefaultCellStyle.Font = new Font("BankGothic Lt BT", 12);
        }

        /// <summary>
        /// Que hace estoo??? esta de mas??? ver el metodo de arriba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.iClienteSeleccionado = iControladorCliente.BuscarClientePorDni(Convert.ToInt32(tablaResulClientes.CurrentRow.Cells[0].Value));
            this.iFilaSeleccionada = tablaResulClientes.CurrentRow;
            Close();
        }
    }
}
