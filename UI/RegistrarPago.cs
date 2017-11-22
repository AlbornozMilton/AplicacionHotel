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
    public partial class RegistrarPago : Form
    {
        public RegistrarPago()
        {
            InitializeComponent();
            lbl_MostrarFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento VentanaBuscarAlojamiento = new BuscarAlojamiento();
            VentanaBuscarAlojamiento.ShowDialog();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
