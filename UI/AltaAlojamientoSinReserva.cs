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
    public partial class AltaAlojamientoSinReserva : Form
    {
        public AltaAlojamientoSinReserva()
        {
            InitializeComponent();
            textBox2.Text = Convert.ToString(DateTime.Today.Date);
        }

        public void cargar_Nro_Habitacion(byte nroHab)
        {
            tbx_NroHab.Text = nroHab.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = "HOLAAAA";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_VerificarDisponibilidad_Click(object sender, EventArgs e)
        {
            TablaDisponibilidad TablaDisp = new TablaDisponibilidad();
            TablaDisp.FormPadre = this;
            TablaDisp.ShowDialog();
        }
    }
}
