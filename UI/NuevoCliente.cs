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
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
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
                cbx_tipo.Items.Add(tarifa.NombreTarifa);
            }
        }

        public NuevoCliente(Cliente pCliente)
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
                cbx_tipo.Items.Add(tarifa.NombreTarifa);
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
            txb_codPostal.Text = Ciudades.Find(c => c.Nombre == cbx_ciudades.Text).CiudadId.ToString();
            var auxCalles = ControladorCliente.ObtenerCallesDeCiudad(txb_codPostal.Text).OrderByDescending(c => c);
            cbx_calles.Items.Clear();
            cbx_calles.Text = "";
            foreach (var calle in auxCalles)
            {
                cbx_calles.Items.Add(calle);
            }
        }

        private void tbx_dni_Leave(object sender, EventArgs e)
        {
            if (tbx_dni.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI");
                tbx_dni.Focus();
            }
            else if (this.ControladorCliente.ExisteClienteDNI(tbx_dni.Text))
            {
                MessageBox.Show("El DNI ingresado ya existe.");
                tbx_dni.Clear();
                tbx_dni.Focus();
            }
        }

        private void txb_legajo_Leave(object sender, EventArgs e)
        {
            if (txb_legajo.Text == "")
            {
                MessageBox.Show("Debe ingresar un Legajo");
                txb_legajo.Focus();
            }
            else if (this.ControladorCliente.ExisteClienteLegajo(txb_legajo.Text))
            {
                MessageBox.Show("El Legajo ingresado ya existe.");
                txb_legajo.Clear();
                txb_legajo.Focus();
            }
        }

        private void txb_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                new ControladorExtra().EsLetra(e);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            } 
        }

        private void txb_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                new ControladorExtra().EsLetra(e);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void txb_nroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                new ControladorExtra().EsNumero(e);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void txb_piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                new ControladorExtra().EsNumero(e);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void txb_nroDepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                new ControladorExtra().EsNumero(e);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void txb_apellido_Leave(object sender, EventArgs e)
        {
            if (txb_apellido.Text == "")
            {
                MessageBox.Show("Debe ingresar Apellido");
                txb_apellido.Focus();
            }
        }

        private void txb_nombre_Leave(object sender, EventArgs e)
        {
            if (txb_nombre.Text == "")
            {
                MessageBox.Show("Debe ingresar Nombre");
                txb_nombre.Focus();
            }
        }

        private void txb_nroCalle_Leave(object sender, EventArgs e)
        {
            if (txb_nroCalle.Text == "")
            {
                MessageBox.Show("Debe ingresar Número de Calle");
                txb_nroCalle.Focus();
            }
        }

        private void txb_piso_Leave(object sender, EventArgs e)
        {
            if (txb_piso.Text == "")
            {
                txb_piso.Text = "0";
            }
        }

        private void txb_nroDepto_Leave(object sender, EventArgs e)
        {
            if (txb_nroDepto.Text == "")
            {
                txb_nroDepto.Text = "0";
            }
        }

        private void cbx_tipo_Leave(object sender, EventArgs e)
        {
            if (cbx_tipo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un Tipo");
                cbx_tipo.Focus();
            }
        }

        private void cbx_ciudades_Leave(object sender, EventArgs e)
        {
            if (cbx_ciudades.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una Ciudad");
                cbx_ciudades.Focus();
            }
        }

        private void txb_telefono_Leave(object sender, EventArgs e)
        {
            if (txb_telefono.Text == "")
            {
                MessageBox.Show("Debe ingresar un Teléfono");
                txb_telefono.Focus();
            }
        }

        private void txb_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                new ControladorExtra().EsNumero(e);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
