using System;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class VistaUsuario : Form
    {
        private Cliente unCliente;
        public VistaUsuario(Cliente pCliente)
        {
            InitializeComponent();
            this.unCliente = pCliente;
        }

        private void VistaUsuario_Load(object sender, EventArgs e)
        {
            MostrarCliente();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            NuevoCliente ventanaCliente = new NuevoCliente(unCliente);
            ventanaCliente.ShowDialog();
            unCliente = new ControladorCliente().BuscarClientePorDni(unCliente.ClienteId, unCliente.EnAlta);
            MostrarCliente();
        }

        private void MostrarCliente()
        {
            lbl_valor_dni.Text = unCliente.ClienteId.ToString();
            lbl_valor_legajo.Text = unCliente.Legajo.ToString();
            lbl_valor_apellido.Text = unCliente.Apellido;
            lbl_valor_nombre.Text = unCliente.Nombre;
            lbl_valor_tel.Text = unCliente.Telefono.ToString();
            lbl_valor_nombreTarifa.Text = unCliente.TarifaCliente.NombreTarifa;
            lbl_valor_tarifaSExcl.Text = unCliente.TarifaCliente.Tarifa.ToString();
            lbl_valor_tarifaCExcl.Text = unCliente.TarifaCliente.TarifaExclusiva.ToString();
            if (unCliente.Domicilio.Ciudad != null)
            {
                lbl_valor_nomCiudad.Text = unCliente.Domicilio.Ciudad.Nombre;
                lbl_valor_codPostal.Text = unCliente.Domicilio.Ciudad.CodPostal.ToString();
            }
            lbl_valor_direc.Text = unCliente.Domicilio.Direccion();
            lbl_valor_piso.Text = unCliente.Domicilio.Piso;
            lbl_valor_depto.Text = unCliente.Domicilio.NroDepto;
            textBox_correo.Text = unCliente.Correo == "" ? "-" : unCliente.Correo;
        }
    }
}
