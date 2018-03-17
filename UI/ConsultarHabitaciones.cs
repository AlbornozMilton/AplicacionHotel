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
    public partial class ConsultarHabitaciones : Form
    {
        List<Habitacion> Habitaciones = new ControladorHabitacion().GetAllHabitaciones();
        public Habitacion HabSeleccionada;

        public ConsultarHabitaciones()
        {
            InitializeComponent();
        }

        private void ConsultarHabitaciones_Load(object sender, EventArgs e)
        {
            foreach (var hab in Habitaciones)
            {
                //foreach (var cupo in hab.Cupos)
                //{
                //    if (cupo.Tipo == TipoCupo.simple) auxCantCupoSimple++;
                //    else auxCantCuposDoble++;
                //}
                //dGV_Habs.Rows.Add(hab.HabitacionId,hab.Capacidad(), hab.Planta == 0 ? "Baja" : "Alta", auxCantCupoSimple,auxCantCuposDoble);
            }
        }

        //SALIR
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.HabSeleccionada = Habitaciones.Find(h => h.HabitacionId == Convert.ToInt32(dGV_Habs.CurrentRow.Cells[0].Value));
            Close();
        }
    }
}
