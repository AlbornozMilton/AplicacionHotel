﻿using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class TablaDisponibilidad : Form
    {
        public List<Habitacion> HabSeleccionadas = new List<Habitacion>();
        private DateTime iFechaDesde, iFechaHasta;
        public List<Habitacion> Habitaciones;

        public TablaDisponibilidad(DateTime pFechaDesde, DateTime pFechaHasta, bool pValor)
        {
            InitializeComponent();
            btn_Seleccionar.Visible = pValor;
            iFechaDesde = pFechaDesde;
            iFechaHasta = pFechaHasta;
            groupBox2.Text = "Disponibilidad de Habitaciones desde " + iFechaDesde.ToString("dd/MM/yy") + " hasta " + iFechaHasta.ToString("dd/MM/yy");
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
            for (int i = 0; i < dGV_TablaHabitaciones.SelectedRows.Count; i++)
            {
                this.HabSeleccionadas.Add(this.Habitaciones.Find(h => h.HabitacionId == Convert.ToInt32(dGV_TablaHabitaciones.SelectedRows[i].Cells[0].Value)));
            }

            this.HabSeleccionadas = this.HabSeleccionadas.OrderBy(h => h.HabitacionId).ToList();

            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
