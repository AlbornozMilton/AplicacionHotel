using System;
using System.Windows.Forms;

namespace UI
{
    public partial class ReInicioSesion : Form
    {
        public bool Validacion = false;
        public ReInicioSesion()
        {
            InitializeComponent();
        }

        private void textBox_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //caracter que corresponde al ENTER
            {
                if (new Dominio.ControladorCliente().ValidarUsuario(textBox_user.Text, textBox_pass.Text))
                {
                    Validacion = true;
                    Close();
                }
                else
                {
                    VentanaEmergente ventanaEmergente = new VentanaEmergente("Error en la Autenticación", TipoMensaje.Alerta);
                    ventanaEmergente.ShowDialog();
                }
            }
        }

        //cancelar
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            if (new Dominio.ControladorCliente().ValidarUsuario(textBox_user.Text, textBox_pass.Text))
            {
                Validacion = true;
                Close();
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Error en la Autenticación", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }
    }
}
