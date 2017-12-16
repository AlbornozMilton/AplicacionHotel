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
        ControladorHabitacion iControladorHab = new ControladorHabitacion();
        public AltaReservaAlojamiento FormPadre {get; set;} //podria hacerce con una interfaz IForm para juntar varios metodos. consultar Link.
        public TablaDisponibilidad()
        {
            InitializeComponent();
        }
        public TablaDisponibilidad(DateTime fechaDesde, DateTime fechaHasta)
        {
            InitializeComponent();
            this.dtp_fechaDesde.Value = fechaDesde;
            this.dtp_fechaHasta.Value = fechaHasta;
            btn_Actualizar_Click(this,null); //Ejecuta el evento del clic en en el boton ACTUALIZAR automaticamente
        }
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            ControladorAlojamiento iControladorAloj = new ControladorAlojamiento(); // V E R !!!! usar asi?
            if (Convert.ToDateTime(dtp_fechaDesde.Value).CompareTo(Convert.ToDateTime(dtp_fechaHasta.Value)) <= 0)
            {
                dGV_TablaHabitaciones.Rows.Clear();
                List<Habitacion> listaHabDisponibles = iControladorAloj.DeterminarDisponibilidad(Convert.ToDateTime(dtp_fechaDesde.Value), Convert.ToDateTime(dtp_fechaHasta.Value));
                foreach (var hab in listaHabDisponibles)
                {
                    
                    dGV_TablaHabitaciones.Rows.Add(hab.HabitacionId, hab.Capacidad(), hab.Planta, hab.CuposDoblesDisponibles(), hab.CuposSimpleDisponibles(), hab.Exclusiva);
                    
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
            this.FormPadre.cargar_Nro_Habitacion(Convert.ToByte(Fila[0].Value));
            this.FormPadre.iHabitacionSeccionada = iControladorHab.ObtenerHabitacion(Convert.ToInt32(Fila[0].Value));
            this.FormPadre.iFechaEstimadaIngreso = Convert.ToDateTime(dtp_fechaDesde.Value);
            this.FormPadre.iFechaEstimadaEgreso = Convert.ToDateTime(dtp_fechaHasta.Value);
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
