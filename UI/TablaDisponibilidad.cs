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
        public AltaReservaAlojamiento FormPadre {get; set;} //podria hacerce con una interfaz IForm para juntar varios metodos. consultar Link.
        public TablaDisponibilidad()
        {
            InitializeComponent();
        }
        public TablaDisponibilidad(DateTimePicker fechaDesde, DateTimePicker fechaHasta)
        {
            InitializeComponent();
            this.dtp_fechaDesde = fechaDesde;
            this.dtp_fechaHasta = fechaHasta;
            btn_Actualizar_Click(this,null); //Ejecuta el evento del clic en en el boton ACTUALIZAR automaticamente
        }
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            ControladorHabitacion iControladorHab = new ControladorHabitacion(); // V E R !!!! usar asi?
            if (Convert.ToDateTime(dtp_fechaDesde.Text).CompareTo(Convert.ToDateTime(dtp_fechaHasta.Text)) <= 0)
            {
                dGV_TablaHabitaciones.Rows.Clear();
                List<Habitacion> listaHabDisponibles = iControladorHab.DeterminarDisponibilidad(Convert.ToDateTime(dtp_fechaDesde.Text), Convert.ToDateTime(dtp_fechaHasta.Text));
                foreach (var hab in listaHabDisponibles)
                {
                    
                    dGV_TablaHabitaciones.Rows.Add(hab.HabitacionId, hab.Capacidad, hab.Planta, hab.CuposDoblesDisponibles(), hab.CuposSimpleDisponibles(), hab.Exclusiva);
                    
                }
                dGV_TablaHabitaciones.Sort(Column1, ListSortDirection.Ascending); //Ordena segun Nro de Habitacion
            }
            else
            {
                MessageBox.Show("Fecha de Ingreso mayor a Fecha de Egreso");
            }
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection Fila = dGV_TablaHabitaciones.CurrentRow.Cells;
            this.FormPadre.cargar_Nro_Habitacion(Convert.ToInt32(Fila[0].Value));
            Close();
        }
    }
}
