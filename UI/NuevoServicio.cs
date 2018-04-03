using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Dominio;
using System.Windows.Forms;

namespace UI
{
	public partial class NuevoServicio : Form
	{
		public NuevoServicio()
		{
			InitializeComponent();
		}

		private void txb_nuevoCosto_KeyPress(object sender, KeyPressEventArgs e)
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

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

		private void button_Cancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btn_Aceptar_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox1.Text == "" || txb_nuevoCosto.Text == "" || textBox2.Text == "")
				{
					throw new Exception("Debe rellenar todos los campos para continuar");
				}

				new ControladorExtra().NuevoServicio(textBox1.Text,textBox2.Text,txb_nuevoCosto.Text);
				new VentanaEmergente("Nuevo Servicio Creado", TipoMensaje.Exito).ShowDialog();
				Close();
				AdministrarServicios Actualizar = new AdministrarServicios();
				Actualizar.ShowDialog();
			}
			catch (Exception E)
			{
				new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
			}
		}
	}
}
