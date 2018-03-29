using System;
using System.Windows.Forms;

namespace UI
{
    public partial class InicioSesion : Form
    {
        public VentanaArranque iPadre;

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new Dominio.ControladorCliente().ValidarUsuario(textBox1.Text, textBox2.Text))
            {
                Hide();
                VentanaPrincipal NuevaVentanaPpal = new VentanaPrincipal();
                NuevaVentanaPpal.iPadre = this;
                NuevaVentanaPpal.ShowDialog();
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Usuario No Registrado", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 ) //caracter que corresponde al ENTER
            {
                if (new Dominio.ControladorCliente().ValidarUsuario(textBox1.Text, textBox2.Text))
                {
                    Hide();
                    VentanaPrincipal NuevaVentanaPpal = new VentanaPrincipal();
                    NuevaVentanaPpal.iPadre = this;
                    NuevaVentanaPpal.ShowDialog();
                }
                else
                {
                    VentanaEmergente ventanaEmergente = new VentanaEmergente("Usuario No Registrado", TipoMensaje.Alerta);
                    ventanaEmergente.ShowDialog();
                }
            }          
        }

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            iPadre.Close();
        }
    }
}
