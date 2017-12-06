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
    public partial class ListarAlojamientos : Form
    {
        public BuscarAlojamiento iFormPadre;
        public ListarAlojamientos()
        {
            InitializeComponent();
        }

        public ListarAlojamientos( BuscarAlojamiento form)
        {
            InitializeComponent();
            this.iFormPadre = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ListarActivos_Click(object sender, EventArgs e)
        {
            ControladorAlojamiento iControladorAloj = new ControladorAlojamiento();
            foreach (var aloj in iControladorAloj.ObtenerAlojamientosActivos())
            {
                dGV_ListadoDeAlojamientos.Rows.Add(aloj.AlojamientoId, aloj.DniResponsable, aloj.Clientes.Find(c => c.ClienteId == aloj.DniResponsable).Apellido + ' ' + aloj.Clientes.Find(c => c.ClienteId == aloj.DniResponsable).Nombre, aloj.Habitacion.HabitacionId);
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            iFormPadre.CargarAlojamientoSeccionado(dGV_ListadoDeAlojamientos.CurrentRow.Cells);
            Close();
        }
    }
}
