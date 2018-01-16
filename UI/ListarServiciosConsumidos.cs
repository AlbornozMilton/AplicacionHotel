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

        /// <summary>
        /// Para que pueda ser llamado desde otros eventos.
        /// </summary>
        /// <param name="pAloPreSeleccionado">Un Alojamiento no vacío</param>
        public ListarServiciosConsumidos(Alojamiento pAloPreSeleccionado)
        {
            InitializeComponent();
            this.iAloj_Seleccionado = pAloPreSeleccionado;
            CargarAlojamientoSeccionado(this.iAloj_Seleccionado);
        }

        public void CargarAlojamientoSeccionado(Alojamiento pAloj)
        {
            dGV_ListadoAlojamientos.Rows.Clear();
            dGV_ListadoAlojamientos.Rows.Add(pAloj.AlojamientoId, pAloj.EstadoAlojamiento, pAloj.DniResponsable, pAloj.Clientes.Find(c => c.ClienteId == pAloj.DniResponsable).NombreCompleto(), pAloj.HabitacionId);
        }

        private void btn_BuscarAlojamiento_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento BuscarAlojamiento = new BuscarAlojamiento();
            BuscarAlojamiento.ShowDialog();
            if (BuscarAlojamiento.iAloj_Seleccionado != null)
            {
                iAloj_Seleccionado = BuscarAlojamiento.iAloj_Seleccionado;
                CargarAlojamientoSeccionado(BuscarAlojamiento.iAloj_Seleccionado);
                dGV_ListadoServicios.Rows.Clear();
                foreach (var serv in iAloj_Seleccionado.Servicios)
                {
                    dGV_ListadoServicios.Rows.Add(serv.Servicio.Nombre, serv.Cantidad, serv.Servicio.CostoBase, serv.FechaServicio.ToString("dd/MM/yyyy"), serv.CostoServicio);
                }
            }
            else
            {
                dGV_ListadoAlojamientos.Rows.Clear();
                dGV_ListadoServicios.Rows.Clear();
            }
        }
    }
}
