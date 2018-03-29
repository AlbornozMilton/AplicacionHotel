using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;

namespace UI
{
	public partial class AgregarCiudad : Form
	{
		int lOpcion;
		List<Ciudad> Ciudades;

		/// <summary>
		/// Operaciones: Agregar, Modificar o Eliminar Ciudad
		/// </summary>
		/// <param name="pOpcion">Agregar = 1, Modificar = 2, Eliminar = 3</param>
		public AgregarCiudad(int pOpcion)
		{
			InitializeComponent();
			lOpcion = pOpcion;
		}

		private void AgregarCiudad_Load(object sender, EventArgs e)
		{
			switch (lOpcion)
			{
				case 1:
					{
						break;
					}
				case 2: //modificacion
					{
						this.Text = "Modificar Ciudad";
						label_cbx_ciudades.Text = "Ciudad a Modificar";
						button1.Text = "Modificar";
						break;
					}
				case 3: //eliminacion
					{
						tBx_nombrecCiudad.Enabled = false;
						tBx_codPostal.Enabled = false;
						this.Text = "Eliminar Ciudad";
						label_cbx_ciudades.Text = "Ciudad a Eliminar";
						button1.Text = "Eliminar";
						break;
					}
			}

			LlenarCampos();
			
		}

		private void LlenarCampos()
		{
			tBx_nombrecCiudad.Text = "";
			tBx_codPostal.Text = "";
			tbx_codPostal_existente.Text = "";
			cbx_ciudades.Items.Clear();
			Ciudades = new ControladorCliente().ObtenerCiudades();
			foreach (var ciudad in Ciudades)
			{
				cbx_ciudades.Items.Add(ciudad.Nombre);
			}
		}
		//CANCELAR
		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		//ACEPTAR
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				switch (button1.Text)
				{
					case "Agregar":
						{
							new ControladorExtra().NuevaCiudad(tBx_codPostal.Text, tBx_nombrecCiudad.Text);
							VentanaEmergente ventanaEmergente = new VentanaEmergente("Ciudad Agregada correctamente", TipoMensaje.Exito);
							ventanaEmergente.ShowDialog();
							break;
						}
					case "Modificar":
						{
							new ControladorExtra().ModificarCiudad(tbx_codPostal_existente.Text, cbx_ciudades.Text, tBx_codPostal.Text, tBx_nombrecCiudad.Text, Ciudades);
							VentanaEmergente ventanaEmergente = new VentanaEmergente("Ciudad Modificada correctamente", TipoMensaje.Exito);
							ventanaEmergente.ShowDialog();
							break;
						}
					case "Eliminar":
						{
							new ControladorExtra().EliminarCiudad(Ciudades.Find(c => c.Nombre == cbx_ciudades.Text && c.CodPostal.ToString() == tbx_codPostal_existente.Text).CiudadId);
							VentanaEmergente ventanaEmergente = new VentanaEmergente("Ciudad Eliminada correctamente", TipoMensaje.Exito);
							ventanaEmergente.ShowDialog();
							break;
						}
				}
				LlenarCampos();
			}
			catch (Exception E)
			{
				VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
				ventanaEmergente.ShowDialog();
			}
		}

		private void cbx_ciudades_SelectedIndexChanged(object sender, EventArgs e)
		{
			Ciudad auxCiudad = Ciudades.Find(c => c.Nombre == cbx_ciudades.Text);
			tbx_codPostal_existente.Text = auxCiudad.CodPostal.ToString();
			if (button1.Text != "Eliminar")
			{
				tBx_codPostal.Text = tbx_codPostal_existente.Text;
				tBx_nombrecCiudad.Text = auxCiudad.Nombre;
			}
		}

        private void tBx_codPostal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tBx_nombrecCiudad_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
