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
    public partial class BuscarAlojamiento : Form
    {
        ControladorAlojamiento iControladorAloj = new ControladorAlojamiento();
        public RegistrarPago iFormPadre;
        public Alojamiento iAloj_Seleccionado;

        public BuscarAlojamiento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
            btn_Buscar.Image = Properties.Resources.boton_buscar_seleccion2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
            btn_Buscar.Image = Properties.Resources.boton_buscar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListarAlojamientos ListarAlojamientos = new ListarAlojamientos();
            ListarAlojamientos.iFormPadre = this;
            ListarAlojamientos.ShowDialog();
        }

        public void CargarAlojamientoSeccionado (DataGridViewCellCollection fila)
        {
            dGV_ListadoAlojamientos.Rows.Clear();
            dGV_ListadoAlojamientos.Rows.Add(fila[0].Value, fila[1].Value, fila[2].Value, fila[3].Value);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                Alojamiento unAloj = iControladorAloj.BuscarAlojamientoPorID(Convert.ToInt32(tbx_IdAlojamiento.Text));
                dGV_ListadoAlojamientos.Rows.Clear();
                dGV_ListadoAlojamientos.Rows.Add(unAloj.AlojamientoId, unAloj.DniResponsable, unAloj.Clientes.Find(c => c.ClienteId == unAloj.DniResponsable).Apellido + ' ' + unAloj.Clientes.Find(c => c.ClienteId == unAloj.DniResponsable).Nombre, unAloj.Habitacion.HabitacionId);
            }
            catch (Exception pException)
            {

                MessageBox.Show(pException.Message);
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            iFormPadre.CargarAlojamientoSeccionado(dGV_ListadoAlojamientos.CurrentRow.Cells);
            iFormPadre.iAlojSeleccionado = iControladorAloj.BuscarAlojamientoPorID(Convert.ToInt32(dGV_ListadoAlojamientos.CurrentRow.Cells[0].Value));
            Close();
        }
    }
}
