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
    public partial class AgregarServicio : Form
    {
        public Alojamiento iAloj_Seleccionado;
        public AgregarServicio()
        {
            InitializeComponent();
        }

        private void btn_BuscarAlojamiento_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento BuscarAlojamiento = new BuscarAlojamiento();
            BuscarAlojamiento.ShowDialog();
            iAloj_Seleccionado = BuscarAlojamiento.iAloj_Seleccionado;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            ControladorAlojamiento iControladorAloj = new ControladorAlojamiento();
            iControladorAloj.AgregarServicio(cBox_Servicios.SelectedItem.ToString(), Convert.ToInt32(cant_Servicio.Value), iAloj_Seleccionado);
            MessageBox.Show("¡ Servicio Agregado !");
        }
    }
}
