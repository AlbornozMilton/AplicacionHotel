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
        public TablaDisponibilidad()
        {
            InitializeComponent();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            ControladorHabitacion iControladorHab = new ControladorHabitacion(); // V E R !!!! usar asi?
            if (Convert.ToDateTime(dtp_fechaDesde.Text).CompareTo(Convert.ToDateTime(dtp_fechaHasta.Text)) <= 0)
            {
                List<Habitacion> listaHabDisponibles = iControladorHab.DeterminarDisponibilidad(Convert.ToDateTime(dtp_fechaDesde.Text), Convert.ToDateTime(dtp_fechaHasta.Text));
                foreach (var hab in listaHabDisponibles)
                {
                    dGV_TablaHabitaciones.Rows.Add(hab.HabitacionId, hab.Capacidad, hab.Planta, hab.CuposDoblesDisponibles(), hab.CuposSimpleDisponibles(), hab.Exclusiva);
                }
                
            }
            else
            {
                MessageBox.Show("Fecha de Ingreso mayor a Fecha de Egreso");
            }
        }
    }
}
