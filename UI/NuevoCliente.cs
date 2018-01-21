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
        Cliente localCliente;

        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
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

            if (localCliente!=null)
            {
                CargarCampos();
            }
        }

        public NuevoCliente(Cliente pCliente)
        {
            InitializeComponent();
            localCliente = pCliente;
        }

        public void CargarCampos()
        {
            tbx_dni.Text = localCliente.ClienteId.ToString();
            tbx_dni.Enabled = false;
            txb_legajo.Text = localCliente.Legajo.ToString();
            txb_apellido.Text = localCliente.Apellido;
            txb_nombre.Text = localCliente.Nombre;
            txb_telefono.Text = localCliente.Telefono.ToString();
            cbx_tipo.SelectedIndex = cbx_tipo.FindString(localCliente.TarifaCliente.NombreTarifa);
            cbx_ciudades.SelectedIndex = cbx_ciudades.FindString(localCliente.Domicilio.Ciudad.Nombre);
            //cbx_ciudades.Text = localCliente.Domicilio.Ciudad.Nombre;
            cbx_calles.Text = localCliente.Domicilio.Calle;
            txb_nroCalle.Text = localCliente.Domicilio.Numero.ToString();
            txb_piso.Text = localCliente.Domicilio.Piso.ToString();
            txb_nroDepto.Text = localCliente.Domicilio.NroDepto.ToString();
            txb_correo.Text = localCliente.Correo;
        }

        public void ControlCamposObligatorios()
        {
            Label[] camposOblig = new Label[] { label13, label14, label15, label16, label17, label18, label19, label21, label22 };
            foreach (var camp in camposOblig)
            {
                if (camp.Visible == true)
                {
                    throw new Exception("Faltan Campos Obligatorios");
                }
            }
        }

        //ACEPTAR
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ControlCamposObligatorios();
                ControladorCliente.CargarDomicilio(cbx_calles.Text, txb_nroCalle.Text, txb_piso.Text, txb_nroDepto.Text, txb_codPostal.Text);
                ControladorCliente.NuevoCliente(tbx_dni.Text, txb_legajo.Text, txb_nombre.Text, txb_apellido.Text, txb_telefono.Text, txb_correo.Text, cbx_tipo.Text);
                if (localCliente != null)
                {
                    MessageBox.Show("Cliente Agregado Correctamente");
                }
                else
                {
                    MessageBox.Show("Cliente Actualizado Correctamente");
                }
                Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbx_ciudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            label19.Visible = false;
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
                label13.Visible = true;
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
                label14.Visible = true;
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
                label15.Visible = true;
            }
        }

        private void txb_nombre_Leave(object sender, EventArgs e)
        {
            if (txb_nombre.Text == "")
            {
                label16.Visible = true;
            }
        }

        private void txb_nroCalle_Leave(object sender, EventArgs e)
        {
            if (txb_nroCalle.Text == "")
            {
                label22.Visible = true;
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
                label18.Visible = true;
            }
        }

        private void cbx_ciudades_Leave(object sender, EventArgs e)
        {
            if (cbx_ciudades.SelectedItem == null)
            {
                label19.Visible = true;
            }
        }

        private void txb_telefono_Leave(object sender, EventArgs e)
        {
            if (txb_telefono.Text == "")
            {
                label17.Visible = true;
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

        private void cbx_calles_Leave(object sender, EventArgs e)
        {
            if (cbx_calles.Text == "")
            {
                label21.Visible = true;
            }
        }

        private void tbx_dni_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbx_dni_TextChanged(object sender, EventArgs e)
        {
            label13.Visible = false;
        }

        private void txb_legajo_TextChanged(object sender, EventArgs e)
        {
            label14.Visible = false;
        }

        private void txb_apellido_TextChanged(object sender, EventArgs e)
        {
            label15.Visible = false;
        }

        private void txb_nombre_TextChanged(object sender, EventArgs e)
        {
            label16.Visible = false;
        }

        private void txb_telefono_TextChanged(object sender, EventArgs e)
        {
            label17.Visible = false;
        }

        private void cbx_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            label18.Visible = false;
        }

        private void cbx_calles_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txb_nroCalle_TextChanged(object sender, EventArgs e)
        {
            label22.Visible = false;
        }

        private void cbx_calles_TextChanged(object sender, EventArgs e)
        {
            label21.Visible = false;
        }

        private void pestaña_DatosGenerales_Enter(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
