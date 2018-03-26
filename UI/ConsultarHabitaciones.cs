using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;
using System.Drawing;

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

		public ConsultarHabitaciones(bool pValor)
		{
			InitializeComponent();
			btn_Aceptar.Visible = pValor;
		}

		private void ConsultarHabitaciones_Load(object sender, EventArgs e)
        {
			int currentHab = 0;
            foreach (var hab in Habitaciones)
            {
				dGV_Habs.Rows.Add(
					hab.HabitacionId, 
					hab.Planta == 0 ? "Baja" : "Alta", 
					hab.Capacidad,
					hab.Alta ? "SI":"NO");
				if (!hab.Alta)
				{
					dGV_Habs.Rows[currentHab].DefaultCellStyle.BackColor = Color.FromName("Khaki"); 
				}
				currentHab++;
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
