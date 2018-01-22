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
        private Cliente AuxClienteSeleccionado;
        ControladorCliente ControladorCliente = new ControladorCliente();
        private bool auxAlta;

        public void setEnableAltas(bool pValor)
        {
            gpb_altas.Enabled = pValor;
        } 

        public BuscarCliente()
        {
            InitializeComponent();
        }


        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            btn_Aceptar.Enabled = false;
            radioButton1.Checked = true;
            textBox_Legajo.Enabled = false;
            textBox_Nombre.Enabled = false;

            rbn_Alta.Checked = true;
            rbn_baja.Checked = false;
            auxAlta = true;
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

        private void CargarCliente()
        {
            tablaResulClientes.Rows.Add(AuxClienteSeleccionado.ClienteId, AuxClienteSeleccionado.Legajo, AuxClienteSeleccionado.NombreCompleto(), AuxClienteSeleccionado.TarifaCliente.NombreTarifa, AuxClienteSeleccionado.Telefono);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                tablaResulClientes.Rows.Clear();
                if (radioButton1.Checked && radioButton1.Text.Length > 0) //DNi
                {
                    AuxClienteSeleccionado = ControladorCliente.BuscarClientePorDni((Convert.ToInt32(textBox_DNI.Text)), auxAlta);
                    CargarCliente();
                }
                else if (radioButton_nombre.Checked && radioButton_nombre.Text.Length > 0)//NOMBRE
                {
                    List<Cliente> list = ControladorCliente.BuscarClientePorNom_Ape(textBox_Nombre.Text, auxAlta);
                    foreach (var cli in list)
                    {
                        tablaResulClientes.Rows.Add(cli.ClienteId, cli.Legajo, cli.Apellido, cli.Nombre, cli.Telefono);
                    }
                }
                else if (radioButton_legajo.Checked && radioButton_legajo.Text.Length > 0) //LEGAJO
                {
                    AuxClienteSeleccionado = ControladorCliente.BuscarClientePorLegajo(textBox_Legajo.Text, auxAlta);
                    CargarCliente();
                }
                btn_Aceptar.Enabled = true;
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (AuxClienteSeleccionado == null && tablaResulClientes.CurrentRow != null)
            {
                this.ClienteSeleccionado = ControladorCliente.BuscarClientePorDni(Convert.ToInt32(tablaResulClientes.CurrentRow.Cells[0].Value), auxAlta);
            }
            else
            {
                ClienteSeleccionado = AuxClienteSeleccionado;
            }
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

        private void btn_nuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente VentanaVisualizar = new NuevoCliente();
            VentanaVisualizar.ShowDialog();
        }

        private void rbn_Alta_CheckedChanged(object sender, EventArgs e)
        {
            auxAlta = true;
        }

        private void rbn_baja_CheckedChanged(object sender, EventArgs e)
        {
            auxAlta = false;
        }
    }
}
