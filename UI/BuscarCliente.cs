using Dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class BuscarCliente : Form
    {
        public Cliente ClienteSeleccionado;
        private Cliente AuxClienteSeleccionado;
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

        private void CargarCliente()
        {
            tablaResulClientes.Rows.Add(AuxClienteSeleccionado.ClienteId, AuxClienteSeleccionado.Legajo, AuxClienteSeleccionado.Apellido, AuxClienteSeleccionado.Nombre, AuxClienteSeleccionado.TarifaCliente.NombreTarifa);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
				//tablaResulClientes.Rows.Clear();
				//if (radioButton1.Checked && textBox_DNI.Text.Length > 0) //DNi
				//{
				//    AuxClienteSeleccionado = new ControladorCliente().BuscarClientePorDni((Convert.ToInt32(textBox_DNI.Text)), auxAlta);
				//    CargarCliente();
				//}
				//else if (radioButton_nombre.Checked)//NOMBRE
				//{
				//    List<Cliente> list = new ControladorCliente().BuscarClientePorNom_Ape(textBox_Nombre.Text, auxAlta);
				//    foreach (var cli in list)
				//    {
				//        tablaResulClientes.Rows.Add(cli.ClienteId, cli.Legajo, cli.Apellido, cli.Nombre, cli.TarifaCliente.NombreTarifa);
				//    }
				//}
				//else if (radioButton_legajo.Checked && textBox_Legajo.Text.Length > 0) //LEGAJO
				//{
				//    AuxClienteSeleccionado = new ControladorCliente().BuscarClientePorLegajo(textBox_Legajo.Text, auxAlta);
				//    CargarCliente();
				//}
				//btn_Aceptar.Enabled = true;
				ResultadoBusqueda();
            }
            catch (FormatException)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("    Debe ingresar solo números", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
            catch (NullReferenceException)
            {
                new VentanaEmergente("        Cliente no encontrado", TipoMensaje.Alerta).ShowDialog();
            }
        }

		private void ResultadoBusqueda()
		{
			tablaResulClientes.Rows.Clear();
			if (radioButton1.Checked && textBox_DNI.Text.Length > 0) //DNi
			{
				AuxClienteSeleccionado = new ControladorCliente().BuscarClientePorDni((Convert.ToInt32(textBox_DNI.Text)), auxAlta);
				CargarCliente();
			}
			else if (radioButton_nombre.Checked)//NOMBRE
			{
				List<Cliente> list = new ControladorCliente().BuscarClientePorNom_Ape(textBox_Nombre.Text, auxAlta);
				foreach (var cli in list)
				{
					tablaResulClientes.Rows.Add(cli.ClienteId, cli.Legajo, cli.Apellido, cli.Nombre, cli.TarifaCliente.NombreTarifa);
				}
			}
			else if (radioButton_legajo.Checked && textBox_Legajo.Text.Length > 0) //LEGAJO
			{
				AuxClienteSeleccionado = new ControladorCliente().BuscarClientePorLegajo(textBox_Legajo.Text, auxAlta);
				CargarCliente();
			}
			btn_Aceptar.Enabled = true;
		}

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (tablaResulClientes.Rows.Count != 0)
            {
                this.ClienteSeleccionado = new ControladorCliente().BuscarClientePorDni(Convert.ToInt32(tablaResulClientes.CurrentRow.Cells[0].Value), auxAlta);
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
			Limpiar();
		}

        private void rbn_baja_CheckedChanged(object sender, EventArgs e)
        {
            auxAlta = false;
			Limpiar();
		}

		private void Limpiar()
		{
			tablaResulClientes.Rows.Clear();
			ClienteSeleccionado = null;
			btn_Aceptar.Enabled = false;
		}

        private void btn_Buscar_MouseHover(object sender, EventArgs e)
        {
            btn_Buscar.SizeMode = PictureBoxSizeMode.Zoom;
            lbl_Buscar.Visible = true;
        }

        private void btn_Buscar_MouseLeave(object sender, EventArgs e)
        {
            btn_Buscar.SizeMode = PictureBoxSizeMode.CenterImage;
            lbl_Buscar.Visible = false;
        }

		private void button_verDatosCliente_Click(object sender, EventArgs e)
		{
			if (tablaResulClientes.CurrentRow != null)
			{
				VistaUsuario vistaUsuario = new VistaUsuario(new ControladorCliente().BuscarClientePorDni(Convert.ToInt32(tablaResulClientes.CurrentRow.Cells[0].Value), auxAlta));
				vistaUsuario.ShowDialog();
				ResultadoBusqueda();
			}
		}
	}
}
