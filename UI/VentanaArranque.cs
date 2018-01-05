using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class VentanaArranque : Form
    {
        public VentanaArranque()
        {
            InitializeComponent();
            Show();
            bgw_CargaUsuarios.RunWorkerAsync(); //realiza carga de datos en segundo plano permitiendo tener control sobre la UI
        }

        private void bgw_CargaUsuarios_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(2000); //retardo.. solo son 2 segundos es para que sea mas tiempo visible la portada
            new Dominio.ControladorCliente().CargarUsuarios();
        }

        private void bgw_CargaUsuarios_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Hide();
            InicioSesion ventanaIniSesion = new InicioSesion();
            ventanaIniSesion.iPadre = this;
            ventanaIniSesion.ShowDialog();
        }
    }
}
