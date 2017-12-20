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
        public Alojamiento iAloj_Seleccionado;
        public DataGridViewCellCollection iFilaSeleccionada;

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
                iAloj_Seleccionado = iControladorAloj.BuscarAlojamientoPorID(Convert.ToInt32(tbx_IdAlojamiento.Text));
                dGV_ListadoAlojamientos.Rows.Clear();
                dGV_ListadoAlojamientos.Rows.Add(this.iAloj_Seleccionado.AlojamientoId, this.iAloj_Seleccionado.DniResponsable, this.iAloj_Seleccionado.Clientes.Find(c => c.ClienteId == this.iAloj_Seleccionado.DniResponsable).Apellido + ' ' + this.iAloj_Seleccionado.Clientes.Find(c => c.ClienteId == this.iAloj_Seleccionado.DniResponsable).Nombre, this.iAloj_Seleccionado.Habitacion.HabitacionId);
            }
            catch (Exception pException)
            {
                MessageBox.Show(pException.Message);
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            iFilaSeleccionada = (dGV_ListadoAlojamientos.CurrentRow.Cells);
            iAloj_Seleccionado = iControladorAloj.BuscarAlojamientoPorID(Convert.ToInt32(dGV_ListadoAlojamientos.CurrentRow.Cells[0].Value));
            Close();
        }
    }
}
