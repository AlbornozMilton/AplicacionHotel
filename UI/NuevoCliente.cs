﻿using System;
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
		string[,] camposObligatorios;

		private void ActualizarCamposoBligatorios(string pLabelName, string pLabelText)
		{
			for (int i = 0; i < camposObligatorios.Length; i++)
			{
				//int j = 1;
				if (camposObligatorios[i,0] == pLabelName)
				{
					camposObligatorios[i,1] = pLabelText;
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
				{ label13.Name, label13.Text }, { label14.Name, label14.Text },
				{ label15.Name, label15.Text }, { label16.Name, label16.Text },
				{ label17.Name, label17.Text }, { label18.Name, label18.Text },
				{ label19.Name, label19.Text }, { label21.Name, label21.Text },
				{ label22.Name, label22.Text }
			};

			button1.Enabled = false; //ACEPTAR
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
			for (int i = 0; i < camposObligatorios.Length; i++)
			{
				if (camposObligatorios[i,1] == "")
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
                //if (this.ControladorCliente.ExisteClienteDNI(tbx_dni.Text))
                //{
                //    new VentanaEmergente("El DNI ingresado ya existe.", TipoMensaje.Alerta).ShowDialog();
                //}
                //if (this.ControladorCliente.ExisteClienteLegajo(txb_legajo.Text))
                //{
                //    new VentanaEmergente("El Legajo ingresado ya existe.", TipoMensaje.Alerta).ShowDialog();
                //}
                ControladorCliente.CargarDomicilio(cbx_calles.Text, txb_nroCalle.Text, txb_piso.Text, txb_nroDepto.Text, txb_codPostal.Text);
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
			ActualizarCamposoBligatorios(label19.Name,"");
            txb_codPostal.Text = Ciudades.Find(c => c.Nombre == cbx_ciudades.Text).CiudadId.ToString();
            var auxCalles = ControladorCliente.ObtenerCallesDeCiudad(txb_codPostal.Text).OrderByDescending(c => c);
            cbx_calles.Items.Clear();
            //cbx_calles.Text = "";
            foreach (var calle in auxCalles)
            {
                cbx_calles.Items.Add(calle);
            }
        }
		
        private void tbx_dni_Leave(object sender, EventArgs e)
        {
            if (tbx_dni.Text == "")
            {
				label13.Text = "Campo Obligatorio";
				label13.Visible = true;
				ActualizarCamposoBligatorios(label13.Name,label13.Text);
            }
            else if (this.ControladorCliente.ExisteClienteDNI(tbx_dni.Text))
            {
				label13.Text = "Ya Existe";
				label13.Visible = true;
				ActualizarCamposoBligatorios(label13.Name,label13.Text);
            }
        }

        private void txb_legajo_Leave(object sender, EventArgs e)
        {
            if (txb_legajo.Text == "")
            {
				label14.Text = "Campo Obligatorio";
				label14.Visible = true;
				ActualizarCamposoBligatorios(label14.Name, label14.Text);
			}
			else if (tbx_dni.Enabled == false)
            {
				if (this.ControladorCliente.ExisteClienteLegajo(txb_legajo.Text))
				{
					label14.Text = "Ya Existe";
					label14.Visible = true;
					ActualizarCamposoBligatorios(label14.Name, label14.Text); 
				}
			}
			else if (localCliente.Legajo.ToString().CompareTo(txb_legajo.Text) != 0)//PARA EL CASO DE LA MODIFICACION
			{
				if (this.ControladorCliente.ExisteClienteLegajo(txb_legajo.Text))
				{
					label14.Text = "Ya Existe";
					label14.Visible = true;
					ActualizarCamposoBligatorios(label14.Name, label14.Text);
				}
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
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
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
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
            }
        }

        

        private void cbx_calles_KeyPress(object sender, KeyPressEventArgs e)
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

		#region CampoObligatorio -> ""

		private void tbx_dni_TextChanged(object sender, EventArgs e)
		{
			label13.Visible = false;
			ActualizarCamposoBligatorios(label13.Name, "");
		}

		private void txb_legajo_TextChanged(object sender, EventArgs e)
		{
			label14.Visible = false;
			ActualizarCamposoBligatorios(label14.Name, "");
		}

		private void txb_apellido_TextChanged(object sender, EventArgs e)
		{
			label15.Visible = false;
			ActualizarCamposoBligatorios(label15.Name, "");

		}

		private void txb_nombre_TextChanged(object sender, EventArgs e)
		{
			label16.Visible = false;
			ActualizarCamposoBligatorios(label16.Name, "");

		}

		private void txb_telefono_TextChanged(object sender, EventArgs e)
		{
			label17.Visible = false;
			ActualizarCamposoBligatorios(label17.Name, "");

		}

		private void cbx_tipo_SelectedIndexChanged(object sender, EventArgs e)
		{
			label18.Visible = false;
			ActualizarCamposoBligatorios(label18.Name, "");

		}

		private void txb_nroCalle_TextChanged(object sender, EventArgs e)
		{
			label22.Visible = false;
			ActualizarCamposoBligatorios(label22.Name, "");
		}

		private void cbx_calles_TextChanged(object sender, EventArgs e)
		{

			label21.Visible = false;
			ActualizarCamposoBligatorios(label22.Name, "");
		}

		#endregion
	}
}
