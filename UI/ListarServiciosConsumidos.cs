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
    public partial class ListarServiciosConsumidos : Form
    {
        public Alojamiento iAloj_Seleccionado;
        public ListarServiciosConsumidos()
        {
            InitializeComponent();
        }

        public ListarServiciosConsumidos(Alojamiento pAloPreSeleccionado)
        {
            InitializeComponent();
            this.iAloj_Seleccionado = pAloPreSeleccionado;
            CargarAlojamientoSeccionado(this.iAloj_Seleccionado);
        }

        public void CargarAlojamientoSeccionado(Alojamiento pAloj)
        {
            dGV_ListadoAlojamientos.Rows.Clear();
            dGV_ListadoAlojamientos.Rows.Add(pAloj.AlojamientoId, pAloj.EstadoAlojamiento, pAloj.HabitacionId, pAloj.DniResponsable, pAloj.Clientes.Find(c => c.ClienteId == pAloj.DniResponsable).NombreCompleto());
        }

        private void btn_BuscarAlojamiento_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento BuscarAlojamiento = new BuscarAlojamiento();
            BuscarAlojamiento.ShowDialog();
            if (BuscarAlojamiento.Aloj_Seleccionado != null)
            {
                iAloj_Seleccionado = BuscarAlojamiento.Aloj_Seleccionado;
                CargarAlojamientoSeccionado(BuscarAlojamiento.Aloj_Seleccionado);
                dGV_ListadoServicios.Rows.Clear();
                double auxTotal = 0;
                foreach (var serv in iAloj_Seleccionado.Servicios)
                {
                    auxTotal += serv.CostoServicio;
                    dGV_ListadoServicios.Rows.Add(serv.Servicio.Nombre, serv.Servicio.CostoBase, serv.Cantidad, serv.FechaServicio.ToString("dd/MM/yyyy"), serv.CostoServicio);
                }
                textBox_total.Text = auxTotal.ToString();
            }
            else
            {
                dGV_ListadoAlojamientos.Rows.Clear();
                dGV_ListadoServicios.Rows.Clear();
            }
        }
    }
}
