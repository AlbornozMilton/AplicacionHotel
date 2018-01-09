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
        public Cliente ClienteSeleccionado;
        public DataGridViewRow FilaSeleccionada;
        ControladorCliente ControladorCliente = new ControladorCliente();
        public BuscarCliente()
        {
            InitializeComponent();
            btn_Aceptar.Enabled = false;
            radioButton1.Checked = true;
            textBox_Legajo.Enabled = false;
            textBox_Nombre.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void pictureBox1_MouseHover(object sender, EventArgs e)
        //{
        //    btn_Buscar.Image = Properties.Resources.boton_buscar_seleccion2;
        //    label1.Visible = true;
        //}

        //private void pictureBox1_MouseLeave(object sender, EventArgs e)
        //{
        //    btn_Buscar.Image = Properties.Resources.boton_buscar;
        //    label4.Visible = false;
        //}

        private void btn_Buscar_Click(object sender, EventArgs e)
        {                               //O UN METODO QUE REALICE TODOS LOC CONTROLES NECESARIOS Y RETORNE BOOLEANO
            if (radioButton1.Checked && radioButton1.Text.Length>0)
            {
                tablaResulClientes.Rows.Clear();
                Cliente cli = ControladorCliente.BuscarClientePorDni((Convert.ToInt32(textBox_DNI.Text)));
                tablaResulClientes.Rows.Add(cli.ClienteId, cli.Apellido, cli.Nombre, cli.Telefono);
                btn_Aceptar.Enabled = true;
            }
            else if (radioButton_nombre.Checked && radioButton_nombre.Text.Length > 0)//NOMBRE
            {
                tablaResulClientes.Rows.Clear();
                List<Cliente> list = ControladorCliente.BuscarClientePorNom_Ape(textBox_Nombre.Text);
                foreach (var cli in list)
                {
                    tablaResulClientes.Rows.Add(cli.ClienteId, cli.Apellido, cli.Nombre, cli.Telefono);
                }
                btn_Aceptar.Enabled = true;
            }
            else if (radioButton_legajo.Checked && radioButton_legajo.Text.Length > 0) //LEGAJO
            {
                tablaResulClientes.Rows.Clear();
                Cliente cli = ControladorCliente.BuscarClientePorLegajo(textBox_Legajo.Text);
                tablaResulClientes.Rows.Add(cli.ClienteId, cli.Apellido, cli.Nombre, cli.Telefono);
                btn_Aceptar.Enabled = true;
            }
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
            this.ClienteSeleccionado = ControladorCliente.BuscarClientePorDni(Convert.ToInt32(tablaResulClientes.CurrentRow.Cells[0].Value));
            this.FilaSeleccionada = tablaResulClientes.CurrentRow;
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_DNI.Enabled = true;
            textBox_Legajo.Enabled = false;
            textBox_Legajo.Clear();
            textBox_Nombre.Enabled = false;
            textBox_Nombre.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//nombre
        {
            textBox_DNI.Enabled = false;
            textBox_DNI.Clear();
            textBox_Legajo.Enabled = false;
            textBox_Legajo.Clear();
            textBox_Nombre.Enabled = true;
        }

        private void radioButton_legajo_CheckedChanged(object sender, EventArgs e)
        {
            textBox_DNI.Enabled = false;
            textBox_DNI.Clear();
            textBox_Legajo.Enabled = true;
            textBox_Nombre.Enabled = false;
            textBox_Nombre.Clear();
        }
    }
}
