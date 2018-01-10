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
    public partial class ListarAlojamientos : Form
    {
        public BuscarAlojamiento iFormPadre;
        public List<Alojamiento> Alojamientos;

        public ListarAlojamientos()
        {
            InitializeComponent();
            btn_verDetalles.Enabled = false;
        }

        public ListarAlojamientos( BuscarAlojamiento form)
        {
            InitializeComponent();
            this.iFormPadre = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ListarActivos_Click(object sender, EventArgs e)
        {
            Alojamientos = new ControladorAlojamiento().ObtenerAlojamientosActivos();
            foreach (var aloj in Alojamientos)
            {
                dGV_ListadoDeAlojamientos.Rows.Add(aloj.AlojamientoId, aloj.DniResponsable, aloj.Clientes.Find(c => c.ClienteId == aloj.DniResponsable).Apellido + ' ' + aloj.Clientes.Find(c => c.ClienteId == aloj.DniResponsable).Nombre, aloj.Habitacion.HabitacionId);
            }
            btn_verDetalles.Enabled = true;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            iFormPadre.CargarAlojamientoSeccionado(dGV_ListadoDeAlojamientos.CurrentRow.Cells);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dGV_ListadoDeAlojamientos.CurrentRow.Cells != null)
            {
                int auxIdAloj = Convert.ToInt32(dGV_ListadoDeAlojamientos.CurrentRow.Cells[0].Value);
                VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(Alojamientos.Find(a => a.AlojamientoId == auxIdAloj));
                VentanaVisualizar.ShowDialog();
                iFormPadre.iAloj_Seleccionado = null;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Alojamiento antes de Ver Detalladamente.");
            }
        }
    }
}
