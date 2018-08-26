using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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
        string[,] camposObligatorios;

        private void ActualizarCamposoBligatorios(string pLabelName, string pLabelText)
        {
            for (int i = 0; i < camposObligatorios.Length; i++)
            {
                //int j = 1;
                if (camposObligatorios[i, 0] == pLabelName)
                {
                    camposObligatorios[i, 1] = pLabelText;
                    break;
                }
            }
        }

        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            camposObligatorios = new string[,]
            {
                { label13.Name, label13.Text },
                { label14.Name, label14.Text },
                //{ label15.Name, label15.Text }, { label16.Name, label16.Text },
                //{ label17.Name, label17.Text }, 
                { label18.Name, label18.Text }
                //{ label19.Name, label19.Text }, { label21.Name, label21.Text },
                //{ label22.Name, label22.Text }
            };

            //button1.Enabled = false; //ACEPTAR
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

            if (localCliente != null)
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
            label13.Text = "";
            tbx_dni.Enabled = false;
            txb_legajo.Text = localCliente.Legajo.ToString();
            label14.Text = "";
            txb_apellido.Text = localCliente.Apellido;
            label15.Text = "";
            txb_nombre.Text = localCliente.Nombre;
            label16.Text = "";
            txb_telefono.Text = localCliente.Telefono.ToString();
            label17.Text = "";
            cbx_tipo.SelectedIndex = cbx_tipo.FindString(localCliente.TarifaCliente.NombreTarifa);
            label18.Text = "";
            if (localCliente.Domicilio.Ciudad != null)
                cbx_ciudades.SelectedIndex = cbx_ciudades.FindString(localCliente.Domicilio.Ciudad.Nombre);
            label19.Text = "";
            //cbx_ciudades.Text = localCliente.Domicilio.Ciudad.Nombre;
            cbx_calles.Text = localCliente.Domicilio.Calle;
            label21.Text = "";
            txb_nroCalle.Text = localCliente.Domicilio.Numero.ToString();
            label22.Text = "";
            txb_piso.Text = localCliente.Domicilio.Piso.ToString();
            txb_nroDepto.Text = localCliente.Domicilio.NroDepto.ToString();
            txb_correo.Text = localCliente.Correo;

            for (int i = 0; i < camposObligatorios.Length / 2; i++)
            {
                camposObligatorios[i, 1] = "";
            }
        }

        public void ControlCamposObligatorios()
        {
            for (int i = 0; i < camposObligatorios.Length / 2; i++)
            {
                if (camposObligatorios[i, 1] != "")
                {
                    throw new Exception("Revise los datos ingresados");
                }
            }

            if (cbx_tipo.SelectedItem == null)
                throw new Exception("Debe elegir un Tipo de Cliente");

            //if (cbx_ciudades.SelectedItem == null)
            //{
            //    throw new Exception("Debe elegir una Ciudad");
            //}

            //if (cbx_calles.SelectedItem == null && cbx_calles.Text == "")
            //{
            //    throw new Exception("Debe elegir un Nombre de Calle");
            //}

            if (txb_piso.Text == "")
            {
                txb_piso.Text = "0";
            }

            if (txb_nroDepto.Text == "")
            {
                txb_nroDepto.Text = "0";
            }
        }

        //ACEPTAR
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ControlCamposObligatorios();

                ControladorCliente.CargarDomicilio(cbx_calles.Text, txb_nroCalle.Text, txb_piso.Text, txb_nroDepto.Text, txb_codPostal.Text, cbx_ciudades.Text);

                ControladorCliente.NuevoCliente(tbx_dni.Text, txb_legajo.Text, txb_nombre.Text, txb_apellido.Text, txb_telefono.Text, txb_correo.Text, cbx_tipo.Text);

                if (localCliente == null)
                {
                    new VentanaEmergente("Cliente Agregado Correctamente", TipoMensaje.Exito).ShowDialog();
                }
                else
                {
                    new VentanaEmergente("Cliente Actualizado Correctamente", TipoMensaje.Exito).ShowDialog();
                }
                Close();
            }
            catch (Exception E)
            {
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region tbxLeave

        private void tbx_dni_Leave(object sender, EventArgs e)
        {

            if (tbx_dni.Text == "")
                label13.Text = "Campo Obligatorio";
            else if (tbx_dni.Text.Length > 8)
                label13.Text = "DNI muy largo";
            else if (this.ControladorCliente.ExisteClienteDNI(tbx_dni.Text))
                label13.Text = "Ya Existe";
            else
                label13.Text = "";
            ActualizarCamposoBligatorios(label13.Name, label13.Text);
        }

        private void txb_legajo_Leave(object sender, EventArgs e)
        {
            //if (txb_legajo.Text == "")
            //	label14.Text = "Campo Obligatorio";
            //         else 
            //if (txb_legajo.Text.Length > 8)
            //    label14.Text = "Legajo muy largo";
            //else 
            if (tbx_dni.Enabled == true && txb_legajo.Text != "" && this.ControladorCliente.ExisteClienteLegajo(txb_legajo.Text))
                label14.Text = "Ya Existe";
            else if (txb_legajo.Text != "" && tbx_dni.Enabled == false && localCliente.Legajo.ToString().CompareTo(txb_legajo.Text) != 0 && this.ControladorCliente.ExisteClienteLegajo(txb_legajo.Text))//PARA EL CASO DE LA MODIFICACION
                label14.Text = "Ya Existe";
            else
                label14.Text = "";
            ActualizarCamposoBligatorios(label14.Name, label14.Text);
        }

        private void txb_apellido_Leave(object sender, EventArgs e)
        {
            //if (txb_apellido.Text == "")
            //	label15.Text = "Campo Obligatorio";
            //else
            //	label15.Text = "";
            //ActualizarCamposoBligatorios(label15.Name, label15.Text);
        }

        private void txb_nombre_Leave(object sender, EventArgs e)
        {
            //if (txb_nombre.Text == "")
            //    label16.Text = "Campo Obligatorio";
            //else
            //    label16.Text = "";
            //ActualizarCamposoBligatorios(label16.Name, label16.Text);
        }

        private void txb_telefono_Leave(object sender, EventArgs e)
        {
            //if (txb_telefono.Text == "")
            //    label17.Text = "Campo Obligatorio";
            //else
            //    label17.Text = "";
            //ActualizarCamposoBligatorios(label17.Name, label17.Text);
        }

        private void cbx_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            label18.Text = "";
            ActualizarCamposoBligatorios(label18.Name, label18.Text);
        }

        private void cbx_ciudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label19.Text = "";
            //ActualizarCamposoBligatorios(label19.Name, label19.Text);

            txb_codPostal.Text = Ciudades.Find(c => c.Nombre == cbx_ciudades.Text).CodPostal.ToString();

            var auxCalles = ControladorCliente.ObtenerCallesDeCiudad(txb_codPostal.Text, cbx_ciudades.Text).OrderByDescending(c => c);
            cbx_calles.Items.Clear();

            foreach (var calle in auxCalles)
            {
                cbx_calles.Items.Add(calle);
            }
        }

        private void cbx_calles_Leave(object sender, EventArgs e)
        {
            //if (cbx_calles.Text == "")
            //    label21.Text = "Campo Obligatorio";
            //else
            //    label21.Text = "";
            //ActualizarCamposoBligatorios(label21.Name, label21.Text);
        }

        private void cbx_calles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label21.Text = "";
            //ActualizarCamposoBligatorios(label21.Name, label21.Text);
        }

        private void txb_nroCalle_Leave(object sender, EventArgs e)
        {
            //if (txb_nroCalle.Text == "")
            //    label22.Text = "Campo Obligatorio";
            //else
            //    label22.Text = "";
            //ActualizarCamposoBligatorios(label22.Name, label22.Text);
        }

        #endregion

        private void txb_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                new ControladorExtra().EsLetra(e);
            }
            catch (Exception E)
            {
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
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
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
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
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
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
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
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
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
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
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
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
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
            }
        }

        private void cbx_calles_KeyPress(object sender, KeyPressEventArgs e)
        {
            //try
            //{
            //    new ControladorExtra().EsLetra(e);
            //}
            //catch (Exception E)
            //{
            //    new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
            //}
        }

        private void txb_legajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                new ControladorExtra().EsNumero(e);
            }
            catch (Exception E)
            {
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
            }
        }

        //AGREGAR UNA CIUDAD
        private void button3_Click(object sender, EventArgs e)
        {
            AgregarCiudad agregarCiudad = new AgregarCiudad(1);
            agregarCiudad.ShowDialog();
            cbx_ciudades.Items.Clear();
            Ciudades = new ControladorCliente().ObtenerCiudades();
            foreach (Ciudad ciudad in Ciudades)
            {
                cbx_ciudades.Items.Add(ciudad.Nombre);
            }
        }

        private void txb_correo_Leave(object sender, EventArgs e)
        {
            if (txb_correo.Text != "")
            {
                if (new ControladorExtra().ValidarEmail(txb_correo.Text))
                {
                    label_correo.Text = "Correo";
                    label_correo.ForeColor = Color.Black;
                    button1.Enabled = true;
                }
                else
                {
                    label_correo.Text = "Correo Inválido";
                    label_correo.ForeColor = Color.Red;
                    button1.Enabled = false;
                }
            }
            else
            {
                label_correo.Text = "Correo";
                label_correo.ForeColor = Color.Black;
                button1.Enabled = true;
            }
        }
    }
}
