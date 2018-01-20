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
            lbl_fechaActual.Text = DateTime.Today.ToString("dd / MM / yyyy");
            lbl_fechaEstEgreso.Text = "-";
            btn_Visualizar.Enabled = false;
            btn_Aceptar.Enabled = false;
            btn_realizarPago.Enabled = false;
        }

        public CerrarAlojamiento(Alojamiento pAloj)
        {
            InitializeComponent();
            this.iAloj_Seleccionado = pAloj;
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            if (iAloj_Seleccionado!=null)
            {
                VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(iAloj_Seleccionado);
                VentanaVisualizar.ShowDialog();
            }
        }

        public void CargarAlojamientoSeccionado(Alojamiento pAloj)
        {
            dGV_ListadoAlojamientos.Rows.Clear();
            dGV_ListadoAlojamientos.Rows.Add(pAloj.AlojamientoId,pAloj.EstadoAlojamiento, pAloj.DniResponsable, pAloj.Clientes.Find(c => c.ClienteId == pAloj.DniResponsable).NombreCompleto(), pAloj.HabitacionId);
        }

        private void btn_BuscarAlojamiento_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento BuscarAlojamiento = new BuscarAlojamiento();
            BuscarAlojamiento.ShowDialog();
            if (BuscarAlojamiento.Aloj_Seleccionado != null)
            {
                iAloj_Seleccionado = BuscarAlojamiento.Aloj_Seleccionado;
                CargarAlojamientoSeccionado(this.iAloj_Seleccionado);

                if (iAloj_Seleccionado.FechaEstimadaEgreso.Date.CompareTo(DateTime.Now.Date)!=0)
                {
                    MessageBox.Show("Atención: La Fecha Estimada de Egreso no coincide con la Fecha Actual. Queda a su criterio continuar con el Cierre.");
                }

                lbl_fechaEstEgreso.Text = iAloj_Seleccionado.FechaEstimadaEgreso.Date.ToString("dd / MM / yyyy");
                btn_realizarPago.Enabled = true;
                btn_Visualizar.Enabled = true;
                btn_Aceptar.Enabled = true;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                new ControladorAlojamiento().CerrarAlojamiento(iAloj_Seleccionado);
                MessageBox.Show("Cierre de Alojamiento Exitoso.");
                Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void btn_realizarPago_Click(object sender, EventArgs e)
        {
            RegistrarPago VentanaVisualizar = new RegistrarPago(iAloj_Seleccionado);
            VentanaVisualizar.ShowDialog();
            this.iAloj_Seleccionado = new ControladorAlojamiento().BuscarAlojamientoPorID(iAloj_Seleccionado.AlojamientoId);
            CargarAlojamientoSeccionado(this.iAloj_Seleccionado);
        }
    }
}
