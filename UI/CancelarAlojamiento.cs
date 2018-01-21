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
    public partial class CancelarAlojamiento : Form
    {
        Alojamiento Aloj_Seleccionado;

        public CancelarAlojamiento()
        {
            InitializeComponent();
            lbl_fechaActual.Text = DateTime.Today.ToString("dd / MM / yyyy");
            btn_Visualizar.Enabled = false;
            btn_Aceptar.Enabled = false;
        }

        private void CargarAlojamientoSeccionado(Alojamiento pAloj)
        {
            dGV_ListadoAlojamientos.Rows.Clear();
            dGV_ListadoAlojamientos.Rows.Add(pAloj.AlojamientoId, pAloj.EstadoAlojamiento, pAloj.DniResponsable, pAloj.Clientes.Find(c => c.ClienteId == pAloj.DniResponsable).NombreCompleto(), pAloj.HabitacionId);
        }

        private void btn_BuscarAlojamiento_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento BuscarAlojamiento = new BuscarAlojamiento();
            BuscarAlojamiento.ShowDialog();
            if (BuscarAlojamiento.Aloj_Seleccionado != null)
            {
                Aloj_Seleccionado = BuscarAlojamiento.Aloj_Seleccionado;
                CargarAlojamientoSeccionado(this.Aloj_Seleccionado);
                btn_Visualizar.Enabled = true;
                btn_Aceptar.Enabled = true;
            }
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            if (Aloj_Seleccionado != null)
            {
                VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(Aloj_Seleccionado);
                VentanaVisualizar.ShowDialog();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                new ControladorAlojamiento().CancelarAlojamiento(Aloj_Seleccionado,DateTime.Now);
                MessageBox.Show("Cancelación de Reserva de Alojamiento Exitosa.");
                Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
