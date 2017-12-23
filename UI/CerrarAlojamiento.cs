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
    public partial class CerrarAlojamiento : Form
    {
        public Alojamiento iAloj_Seleccionado; 
        public CerrarAlojamiento()
        {
            InitializeComponent();
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(iAloj_Seleccionado);
            VentanaVisualizar.ShowDialog();
        }

        public void CargarAlojamientoSeccionado(DataGridViewCellCollection fila)
        {
            dGV_ListadoAlojamientos.Rows.Clear();
            dGV_ListadoAlojamientos.Rows.Add(fila[0].Value, fila[1].Value, fila[2].Value, fila[3].Value);
        }

        private void btn_BuscarAlojamiento_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento BuscarAlojamiento = new BuscarAlojamiento();
            BuscarAlojamiento.ShowDialog();
            iAloj_Seleccionado = BuscarAlojamiento.iAloj_Seleccionado;
            CargarAlojamientoSeccionado(BuscarAlojamiento.iFilaSeleccionada);
        }
    }
}
