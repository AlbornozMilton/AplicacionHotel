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
    public partial class ModificarAltaCliente : Form
    {
        Cliente ClienteSeleccionado;
        public ModificarAltaCliente()
        {
            InitializeComponent();
            btn_darAlta.Enabled = false;
            btn_darBaja.Enabled = false;
            btn_aceptar.Enabled = false;
        }

        private void btn_nuevoCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarCliente = new BuscarCliente();
            BuscarCliente.ShowDialog();
            if (BuscarCliente.ClienteSeleccionado != null)
            {
                ClienteSeleccionado = BuscarCliente.ClienteSeleccionado;
                RellenarCampos();
            }
            else
            {
                tablaResulCliente.Rows.Clear();
                btn_darBaja.Enabled = false;
                btn_aceptar.Enabled = false;
                btn_aceptar.Enabled = false;
            }
        }

        private void RellenarCampos()
        {
            tablaResulCliente.Rows.Clear();
            tablaResulCliente.Rows.Add(ClienteSeleccionado.ClienteId, ClienteSeleccionado.Legajo, ClienteSeleccionado.Apellido, ClienteSeleccionado.Nombre, ClienteSeleccionado.TarifaCliente.NombreTarifa, ClienteSeleccionado.EnAlta ? "En Alta" : "En Baja");
            if (ClienteSeleccionado.EnAlta)
            {
                btn_darAlta.Enabled = false;
                btn_darBaja.Enabled = true;
            }
            else
            {
                btn_darBaja.Enabled = false;
                btn_darAlta.Enabled = true;
            }
            btn_aceptar.Enabled = true;   
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_darAlta_Click(object sender, EventArgs e)
        {
            new ControladorCliente().ModificarAltaCliente(ClienteSeleccionado.ClienteId, true);
            MessageBox.Show("Cliente dado de Alta.");
            ClienteSeleccionado = new ControladorCliente().BuscarClientePorDni(ClienteSeleccionado.ClienteId, !ClienteSeleccionado.EnAlta);
            RellenarCampos();
        }

        private void btn_darBaja_Click(object sender, EventArgs e)
        {
            new ControladorCliente().ModificarAltaCliente(ClienteSeleccionado.ClienteId, false);
            MessageBox.Show("Cliente dado de Baja.");
            ClienteSeleccionado = new ControladorCliente().BuscarClientePorDni(ClienteSeleccionado.ClienteId, !ClienteSeleccionado.EnAlta);
            RellenarCampos();
        }
    }
}
