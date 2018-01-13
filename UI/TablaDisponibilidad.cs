using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class TablaDisponibilidad : Form
    {
        public Habitacion HabSeleccionada;
        public List<Habitacion> Habitaciones;
        //ControladorHabitacion iControladorHab = new ControladorHabitacion();
        public Form FormPadre {get; set;} //podria hacerce con una interfaz IForm para juntar varios metodos. consultar Link.

        public TablaDisponibilidad()
        {
            InitializeComponent();
        }

        public TablaDisponibilidad(DateTime fechaDesde, DateTime fechaHasta)
        {
            InitializeComponent();
            //ControladorAlojamiento iControladorAloj = new ControladorAlojamiento();
            dGV_TablaHabitaciones.Rows.Clear();
            this.Habitaciones = new ControladorAlojamiento().DeterminarDisponibilidad(Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta));
            foreach (var hab in this.Habitaciones)
            {
                dGV_TablaHabitaciones.Rows.Add(hab.HabitacionId, hab.Capacidad(), hab.Planta==0 ? "Baja":"Alta", hab.CuposDoblesDisponibles(), hab.CuposSimpleDisponibles());
            }

            dGV_TablaHabitaciones.Sort(Column1, ListSortDirection.Ascending); //Ordena segun Nro de Habitacion
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection Fila = dGV_TablaHabitaciones.CurrentRow.Cells;
            //this.FormPadre.cargar_Nro_Habitacion(Convert.ToByte(Fila[0].Value));
            //this.iHabSeleccionada = iControladorHab.ObtenerHabitacion(Convert.ToInt32(Fila[0].Value));
            this.HabSeleccionada = this.Habitaciones.Find(h =>h.HabitacionId == Convert.ToInt32(Fila[0].Value));
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
