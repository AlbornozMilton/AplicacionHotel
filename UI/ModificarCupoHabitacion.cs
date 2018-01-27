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
    public partial class ModificarCupoHabitacion : Form
    {
        Habitacion HabSeleccionada;

        public ModificarCupoHabitacion()
        {
            InitializeComponent();
        }

        private void ModificarCupoHabitacion_Load(object sender, EventArgs e)
        {
            btn_confirmar.Enabled = false;
            //button1.Enabled = false;
            //button2.Enabled = false;
            //button3.Enabled = false;
        }

        private void CargarHabitacion(Habitacion pHab)
        {
            dGV_Habs.Rows.Clear();
            int auxCantCupoSimple = 0;
            int auxCantCuposDoble = 0;
            foreach (var cupo in pHab.Cupos)
            {
                if (cupo.Tipo == TipoCupo.simple) auxCantCupoSimple++;
                else auxCantCuposDoble++;
            }
            dGV_Habs.Rows.Add(pHab.HabitacionId, pHab.Capacidad(), pHab.Planta==0 ? "Baja":"Alta");
        }

        private void CargarCupos(List<Cupo> pCupos)
        {
            dataGridView_cupos.Rows.Clear();
            foreach (var cupo in pCupos)
            {
                dataGridView_cupos.Rows.Add(cupo.Tipo.ToString().ToUpper(),cupo.Alta ? "En Alta":"En Baja", cupo.Alta ? "Dar de Baja":"Dar de Alta");
            }
        }
            
        private void btn_buscarHab_Click(object sender, EventArgs e)
        {
            btn_confirmar.Enabled = false;
            ConsultarHabitaciones consultarHabitaciones = new ConsultarHabitaciones();
            consultarHabitaciones.ShowDialog();
            if (consultarHabitaciones.HabSeleccionada != null)
            {
                List<Alojamiento> auxListaAlojs = new ControladorHabitacion().ControlModificarAltaCupos(consultarHabitaciones.HabSeleccionada.HabitacionId);
                if (auxListaAlojs.Count == 0)
                {
                    CargarHabitacion(consultarHabitaciones.HabSeleccionada);
                    CargarCupos(consultarHabitaciones.HabSeleccionada.Cupos);
                    btn_confirmar.Enabled = true;
                    HabSeleccionada = consultarHabitaciones.HabSeleccionada;
                }
                else
                {
                    VentanaEmergente ventanaEmergente = new VentanaEmergente("No es posible la Habitación seleccionada ya que se ecuentra activa en los siguientes Alojamietos", TipoMensaje.Alerta);
                    ventanaEmergente.ShowDialog();
                    dGV_Habs.Rows.Clear();
                    dataGridView_cupos.Rows.Clear();
                    ListarAlojamientos ListarAlojs = new ListarAlojamientos(auxListaAlojs);
                    ListarAlojs.ShowDialog();
                }
            }
            else
            {
                dGV_Habs.Rows.Clear();
                dataGridView_cupos.Rows.Clear();
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            new ControladorHabitacion().ModificarAltaDeCupos(HabSeleccionada);
            VentanaEmergente ventanaEmergente = new VentanaEmergente("Modificacion de Cupos Exitosa", TipoMensaje.Exito);
            ventanaEmergente.ShowDialog();
            Close();
        }

        private void dataGridView_cupos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView_cupos.CurrentCell.ColumnIndex == 2)
            {
                HabSeleccionada.ModificarAltaCupo(dataGridView_cupos.CurrentCell.RowIndex);
                CargarCupos(HabSeleccionada.Cupos);
            }
        }
    }
}
