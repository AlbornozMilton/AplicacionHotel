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
        public ModificarCupoHabitacion()
        {
            InitializeComponent();
        }

        private void ModificarCupoHabitacion_Load(object sender, EventArgs e)
        {
            btn_confirmar.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void CargarHabitacion(Habitacion pHab)
        {
            int auxCantCupoSimple = 0;
            int auxCantCuposDoble = 0;
            foreach (var cupo in pHab.Cupos)
            {
                if (cupo.Tipo == TipoCupo.simple) auxCantCupoSimple++;
                else auxCantCuposDoble++;
            }
            dGV_Habs.Rows.Add(pHab.HabitacionId, pHab.Capacidad(), auxCantCupoSimple, auxCantCuposDoble);
        }

        private void CargarCupos(List<Cupo> pCupos)
        {
            foreach (var cupo in pCupos)
            {
                dataGridView_cupos.Rows.Add(cupo.Tipo,cupo.Alta ? "En Alta":"En Baja");

            }

            //for (int i = 0; i < pCupos.Count; i++)
            //{
            //    dataGridView_cupos.Rows.Add(pCupos[i].Tipo, pCupos[i].Alta ? "En Alta" : "En Baja");
            //}
        }
            

        private void btn_buscarHab_Click(object sender, EventArgs e)
        {
            ConsultarHabitaciones consultarHabitaciones = new ConsultarHabitaciones();
            consultarHabitaciones.ShowDialog();


        }
    }
}
