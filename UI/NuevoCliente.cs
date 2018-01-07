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
        ControladorCliente ControladorCliente = new ControladorCliente();
        List<Ciudad> Ciudades;
        List<TarifaCliente> Tarifas;

        public NuevoCliente()
        {
            InitializeComponent();
            Ciudades = ControladorCliente.ObtenerCiudades();
            Tarifas = ControladorCliente.DevolverListaTarifas();
            txb_codPostal.Enabled = false;

            foreach (var ciudad in Ciudades)
            {
                cbx_ciudades.Items.Add(ciudad.Nombre);
            }

            foreach (var tarifa in Tarifas)
            {
                cbx_tipo.Items.Add(tarifa.TarifaClienteId.ToString());
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //ControladorCliente.CargarCiudad(Convert.ToInt32(txb_codPostal.Text), txb_codPostal.Text);
            ControladorCliente.CargarDomicilio(txb_calle.Text, txb_nroCalle.Text, txb_piso.Text, txb_nroDepto.Text);
            ControladorCliente.NuevoCliente(tbx_dni.Text,label_legajo.Text, txb_nombre.Text,txb_apellido.Text,txb_telefono.Text, txb_correo.Text, Domicilio ,cbx_tipo.Text);
            MessageBox.Show("Cliente agregado correctamente");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbx_ciudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_ciudades.Items.Count > 0)
            {
                txb_codPostal.Text = Ciudades.Find(c => c.Nombre == cbx_ciudades.Text).CiudadId.ToString();
            }
            else
            {
                MessageBox.Show("No hay ciudad cargadas en combo box.");
            }
        }
    }
}
