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
            cbx_tipo.Items.Clear();

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
            ControladorCliente.CargarDomicilio(cbx_calles.Text, txb_nroCalle.Text, txb_piso.Text, txb_nroDepto.Text, txb_codPostal.Text);
            try
            {
                ControladorCliente.NuevoCliente(tbx_dni.Text, txb_legajo.Text, txb_nombre.Text, txb_apellido.Text, txb_telefono.Text, txb_correo.Text, cbx_tipo.Text);
                MessageBox.Show("Cliente agregado correctamente");
                Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("Error en la Persistencia: "+E.Message);
                MessageBox.Show(E.InnerException.Message);
            }
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
                var auxCalles = ControladorCliente.ObenerCallesDeCiudad(txb_codPostal.Text).OrderByDescending(c => c);
                foreach (var calle in auxCalles)
                {
                    cbx_calles.Items.Add(calle);
                }
            }
            else
            {
                MessageBox.Show("No hay ciudad cargadas en combo box.");
            }
        }

        private void tbx_dni_TextChanged(object sender, EventArgs e)
        {
            // BUSCAR INFO PARA SABER COMO HACER CONTROL LUEGO DE APRETAR "ENTER"
            if (this.ControladorCliente.ExisteClienteDNI(tbx_dni.Text))
            {
                MessageBox.Show("El DNI ingresado ya existe.");
                //tbx_dni.Clear();
            }

            //CONTROLAR LA LONGITUD DE LOS DIGITOS
        }

        private void txb_legajo_TextChanged(object sender, EventArgs e)
        {
            // BUSCAR INFO PARA SABER COMO HACER CONTROL LUEGO DE APRETAR "ENTER"
            if (this.ControladorCliente.ExisteClienteDNI(txb_legajo.Text))
            {
                MessageBox.Show("El Legajo ingresado ya existe.");
                //txb_legajo.Clear();
            }
            
            //CONTROLAR LA LONGITUD DE LOS DIGITOS
        }
    }
}
