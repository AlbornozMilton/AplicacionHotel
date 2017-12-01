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
    public partial class AltaReservaAlojamiento : Form
    {
        public AltaReservaAlojamiento()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label14.Visible = true;
            pictureBox1.Image = Properties.Resources.Boton_Ok_Seleccion_3;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            label14.Visible = false;
            pictureBox1.Image = Properties.Resources.Boton_Ok_2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            //button4.BackColor = Color.Yellow 255, 255, 128};
        }

        private void btn_VerificarDisponibilidad_Click(object sender, EventArgs e)
        {
            TablaDisponibilidad TDisp = new TablaDisponibilidad(dtp_fechaDesde,dtp_fechaHasta);
            TDisp.FormPadre = this; //Almacena esta WinForm como la padre de la TDisp con el atributo Opener
            TDisp.ShowDialog();
        }
        
        public void cargar_Nro_Habitacion (int nroHab)
        {
            tbx_NroHab.Text = nroHab.ToString();
        }

        public void agregar_Cliente (DataGridViewCellCollection fila)
        {
            dGV_ClienteResponsable.Rows.Add(fila[0].Value, fila[1].Value, fila[2].Value, fila[3].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.FormPadre = this;
            BuscarClienteForm.ShowDialog();
        }
    }
}
