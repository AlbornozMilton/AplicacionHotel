using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class AdministrarServicios : Form
    {
        public Servicio ServicioSeleccionado;
        public List<Servicio> ListaServicios = new ControladorExtra().ObtenerServicios();

        public AdministrarServicios()
        {
            InitializeComponent();
        }

		public AdministrarServicios(bool pValor)
		{
			InitializeComponent();
			btn_Aceptar.Visible = pValor;
		}
		private void CargarServicios()
        {
            foreach (var serv in ListaServicios)
            {
                dGV_Servicios.Rows.Add(serv.ServicioId,serv.Nombre,serv.CostoBase,serv.Detalle);
            }
        }

		//Boton Seleccionar
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.ServicioSeleccionado = ListaServicios.Find(s => s.ServicioId == Convert.ToByte(dGV_Servicios.CurrentRow.Cells[0].Value));
            Close();
        }

		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AdministrarServicios_Load(object sender, EventArgs e)
		{
			CargarServicios();
		}
	}
}
