using System;
using Dominio;
using System.Windows.Forms;

namespace UI
{
	public partial class UserAdmin : Form
	{
		private byte OP;

		public UserAdmin(byte pOP)
		{
			InitializeComponent();
			OP = pOP;
		}

		private void UserAdmin_Load(object sender, EventArgs e)
		{
			switch (OP)
			{
				case 0:
					{
						Text = "Nuevo Usuario";
						label_oldPass.Text = "Contraseña";
						label_newPass.Text = "Repita Contraseña";
					}
					break;
				case 1:
					{
						Text = "Eliminar Usuario";
						label_oldPass.Text = "Contraseña";
						label_newPass.Text = "Repita Contraseña";
					}
					break;
				case 2:
					{
						Text = "Cambiar Contaseña";
					}
					break;
			}
		}

		private void button_aceptar_Click(object sender, EventArgs e)
		{
			try
			{
				switch (OP)
				{
					case 0:
						{
							//Nuevo Usuario
							new ControladorExtra().NuevoUsuario(txb_userName.Text, txb_oldPass.Text, txb_newPass.Text);
							VentanaEmergente ventanaEmergente = new VentanaEmergente("Usuario Agregado Correctamente", TipoMensaje.Exito);
							ventanaEmergente.ShowDialog();
						}
						break;
					case 1:
						{
							VentanaEmergente ventanaEmergente = new VentanaEmergente("¿Eliminar Usuario?", TipoMensaje.Alerta);
							ventanaEmergente.ShowDialog();
							if (ventanaEmergente.Aceptar)
							{
								//ELIMINAR USUARIO
								new ControladorExtra().EliminarUsuario(txb_userName.Text, txb_oldPass.Text, txb_newPass.Text);
								VentanaEmergente ventanaEmergente2 = new VentanaEmergente("Usuario Eliminado", TipoMensaje.Exito);
								ventanaEmergente2.ShowDialog();
							}
						}
						break;
					case 2:
						{
							new ControladorExtra().ModificarUsuario(txb_userName.Text, txb_oldPass.Text, txb_newPass.Text);
							VentanaEmergente ventanaEmergente = new VentanaEmergente("Contraseña cambiada con Éxito", TipoMensaje.Exito);
							ventanaEmergente.ShowDialog();
							VentanaEmergente ventanaEmergente2 = new VentanaEmergente("Los cambios tendrán efectos la próxima vez que Inice la Aplicación", TipoMensaje.Exito);
							ventanaEmergente2.ShowDialog();
						}
						break;
				}

				Close();
			}
			catch (Exception E)
			{
				VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
				ventanaEmergente.ShowDialog();
			}
		}

		private void button_cancelar_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
