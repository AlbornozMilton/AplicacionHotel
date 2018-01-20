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
        public Alojamiento AlojSeleccionado;
        public List<Alojamiento> Alojamientos;

        public ListarAlojamientos()
        {
            InitializeComponent();
            dateTimePicker_hasta.Value = DateTime.Now;
            string[] auxComponents = { "btn_Aceptar","button_realizarPago", "button_CancelarAloj" };
            this.EnableComponents(auxComponents, false);
        }

        public ListarAlojamientos(List<Alojamiento> pAlojs)
        {
            InitializeComponent();
            Alojamientos = pAlojs;
            CargarAlojamientos();
            string[] auxComponents = { "btn_Aceptar","groupBox_Rapida", "groupBox_Personalizado" };
            this.EnableComponents(auxComponents, false);
            //groupBox_Rapida.Enabled = false;
            //groupBox_Personalizado.Enabled = false;
            //btn_Aceptar.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarAlojamientos()
        {
            foreach (var aloj in Alojamientos)
            {
                Cliente auxCli = aloj.Clientes.Find(c => c.ClienteId == aloj.DniResponsable);
                dGV_ListadoDeAlojamientos.Rows.Add(aloj.AlojamientoId, aloj.EstadoAlojamiento, aloj.Habitacion.HabitacionId, auxCli.ClienteId,auxCli.NombreCompleto(),auxCli.TarifaCliente.NombreTarifa);
            }
        }

        private void btn_ListarActivos_Click(object sender, EventArgs e)
        {
            Alojamientos = new ControladorAlojamiento().ObtenerAlojamientosActivos();
            CargarAlojamientos();
            btn_verDetalles.Enabled = true;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            AlojSeleccionado = Alojamientos.Find(a => a.AlojamientoId == Convert.ToInt32(dGV_ListadoDeAlojamientos.CurrentRow.Cells[0].Value));
            Close();
        }

        //Ver detalles
        private void button1_Click(object sender, EventArgs e)
        {
            if (dGV_ListadoDeAlojamientos.CurrentRow != null)
            {
                int auxIdAloj = Convert.ToInt32(dGV_ListadoDeAlojamientos.CurrentRow.Cells[0].Value);
                VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(Alojamientos.Find(a => a.AlojamientoId == auxIdAloj));
                VentanaVisualizar.ShowDialog();
            }
        }

        private void button_realizarPago_Click(object sender, EventArgs e)
        {
            if (dGV_ListadoDeAlojamientos.CurrentRow != null)
            {
                RegistrarPago registrarPago = new RegistrarPago(Alojamientos.Find(a => a.AlojamientoId == Convert.ToInt32(dGV_ListadoDeAlojamientos.CurrentRow.Cells[0].Value)));
                registrarPago.ShowDialog();
                Close();
            }
            //actualizar lista o no
        }

        private void button_CancelarAloj_Click(object sender, EventArgs e)
        {
            if (dGV_ListadoDeAlojamientos.CurrentRow != null)
            {
                
                Close();
            }
            //actualizar lista o no
        }

        public void EnableComponents(string[] pNombreComponentes,bool pValor)
        {
            foreach (string component in pNombreComponentes)
            {
                Control auxComponent = this.Controls.Find(component, false).Single();

                if (auxComponent != null)
                {
                    auxComponent.Enabled = pValor;
                }
            }
        }        
    }
}
