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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AltaAlojamientoSinReserva_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = "HOLAAAA";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TablaDisponibilidad TablaDisp = new TablaDisponibilidad();
            TablaDisp.ShowDialog();
        }
    }
}
