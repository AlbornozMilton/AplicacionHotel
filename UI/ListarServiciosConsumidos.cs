using System;
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
        }

        private void btn_BuscarAlojamiento_Click(object sender, EventArgs e)
        {
            try
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
                    throw new Exception("   Debe seleccionar un Alojamiento");
                }
            }
            catch (Exception E)
            {

                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
