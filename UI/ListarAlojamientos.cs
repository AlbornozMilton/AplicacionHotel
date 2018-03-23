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
        private ControladorAlojamiento ControladorAloj = new ControladorAlojamiento();

        public ListarAlojamientos()
        {
            InitializeComponent();
            dateTimePicker_hasta.Value = DateTime.Now.AddDays(1);
            string[] auxComponents = { "btn_Aceptar"};
            this.EnableComponents(auxComponents, false);
        }

        public ListarAlojamientos(List<Alojamiento> pAlojs)
        {
            InitializeComponent();
            Alojamientos = pAlojs;
            CargarAlojamientos();
            string[] auxComponents = { "btn_Aceptar","groupBox_Rapida", "groupBox_Personalizado" };
            this.EnableComponents(auxComponents, false);
        }

        //CANCELAR
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarAlojamientos()
        {
            dGV_ListadoDeAlojamientos.Rows.Clear();
            if (Alojamientos.Count > 0)
            {
				ControladorExtra controladorExtra = new ControladorExtra();
                int indexRow = 0;
                foreach (var aloj in this.Alojamientos)
                {
                    Cliente auxCli = aloj.Clientes.Find(c => c.ClienteId == aloj.DniResponsable);
                    dGV_ListadoDeAlojamientos.Rows.Add(aloj.AlojamientoId, aloj.EstadoAlojamiento, aloj.Habitacion.HabitacionId, auxCli.ClienteId, auxCli.NombreCompleto(), auxCli.TarifaCliente.NombreTarifa);
					string[] colores = controladorExtra.DeterminarColor(aloj);
					dGV_ListadoDeAlojamientos.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromName(colores[0]);
					dGV_ListadoDeAlojamientos.Rows[indexRow].DefaultCellStyle.ForeColor = Color.FromName(colores[1]);
					indexRow++;
                }
                btn_Aceptar.Enabled = true;
            }
            else
            {
                btn_Aceptar.Enabled = false;
            }
        }

        private void btn_ListarActivos_Click(object sender, EventArgs e)
        {
            this.Alojamientos = new List<Alojamiento>();
            this.Alojamientos = ControladorAloj.ObtenerAlojamientosActivos();
            CargarAlojamientos();
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

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            if (dateTimePicker_hasta.Value.Date.CompareTo(dateTimePicker_desde.Value.Date)>0)
            {
                List<EstadoAlojamiento> localEstados = new List<EstadoAlojamiento>();

                if (checkBox_todos.Checked)
                {
                    localEstados.Add(EstadoAlojamiento.Reservado);
                    localEstados.Add(EstadoAlojamiento.Alojado);
                    localEstados.Add(EstadoAlojamiento.Cancelado);
                    localEstados.Add(EstadoAlojamiento.Cerrado);
                }
                else 
                {
                    if (checkBox_cancelado.Checked)
                    {
                        localEstados.Add(EstadoAlojamiento.Cancelado);
                    }
                    if (checkBox_cerrado.Checked)
                    {
                        localEstados.Add(EstadoAlojamiento.Cerrado);
                    }
                }

                this.Alojamientos = new List<Alojamiento>();
                this.Alojamientos = new ControladorAlojamiento().ListaPersonalizada(localEstados,dateTimePicker_desde.Value,dateTimePicker_hasta.Value);
                CargarAlojamientos();
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("La fecha 'Hasta' debe ser mayor que la fecha 'Desde'", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        //REALIZAR PAGO
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dGV_ListadoDeAlojamientos.CurrentRow != null)
            {
                RegistrarPago registrarPago = new RegistrarPago(Alojamientos.Find(a => a.AlojamientoId == Convert.ToInt32(dGV_ListadoDeAlojamientos.CurrentRow.Cells[0].Value)));
                registrarPago.ShowDialog();
                if (this.Alojamientos[0].EstadoAlojamiento == EstadoAlojamiento.Reservado)
                {
                    this.Alojamientos = new ControladorAlojamiento().AlojsReservadosConDepositoVencidos();
                }
                else
                {
                    this.Alojamientos = new ControladorAlojamiento().AlojamientosConDeuda();
                }
                CargarAlojamientos();
            }
        }

        public void VisiblePago()
        {
            button1.Visible = true;
        }
    }
}
