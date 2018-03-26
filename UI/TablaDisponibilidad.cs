using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace UI
{
    public partial class TablaDisponibilidad : Form
    {
        public Habitacion HabSeleccionada;
		private DateTime iFechaDesde, iFechaHasta;
        public List<Habitacion> Habitaciones;

		public TablaDisponibilidad(DateTime pFechaDesde, DateTime pFechaHasta, bool pValor)
		{
			InitializeComponent();
			btn_Seleccionar.Visible = pValor;
			iFechaDesde = pFechaDesde;
			iFechaHasta = pFechaHasta;
			groupBox2.Text = "Disponibilidad de Habitaciones desde " + iFechaDesde.ToString("dd/MM/yy") +" hasta "+iFechaHasta.ToString("dd/MM/yy");
		}

        private void TablaDisponibilidad_Load(object sender, EventArgs e)
		{
			this.Habitaciones = new ControladorAlojamiento().DeterminarDisponibilidad(Convert.ToDateTime(iFechaDesde), Convert.ToDateTime(iFechaHasta));
			foreach (var hab in this.Habitaciones)
			{
				if (!hab.Ocupada)
				{
					dGV_TablaHabitaciones.Rows.Add(hab.HabitacionId, hab.Planta == 0 ? "Baja" : "Alta", hab.Capacidad);
				}
			}

			dGV_TablaHabitaciones.Sort(Column1, ListSortDirection.Ascending); //Ordena según Nro de Habitación
		}

		private void btn_Seleccionar_Click(object sender, EventArgs e)
		{
			this.HabSeleccionada = this.Habitaciones.Find(h => h.HabitacionId == Convert.ToInt32(dGV_TablaHabitaciones.CurrentRow.Cells[0].Value));
			Close();
		}

		private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
