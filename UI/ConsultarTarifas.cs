using Dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class ConsultarTarifas : Form
    {
        public TarifaCliente iTarifaSeleccionada;
        public List<TarifaCliente> ListaTarifas = new ControladorCliente().DevolverListaTarifas();
        public ConsultarTarifas()
        {
            InitializeComponent();
        }

		public ConsultarTarifas(bool pValor)
		{
			InitializeComponent();
			btn_Seleccionar.Visible = pValor;
		}

		private void CargarTarifas()
        {
            foreach (var tarifa in ListaTarifas)
            {
                dGV_Tarifas.Rows.Add(tarifa.NombreTarifa, tarifa.Tarifa, tarifa.TarifaExclusiva);
            }
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            this.iTarifaSeleccionada = ListaTarifas.Find(s => s.NombreTarifa == (dGV_Tarifas.CurrentRow.Cells[0].Value).ToString());
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void ConsultarTarifas_Load(object sender, EventArgs e)
		{
			CargarTarifas();
		}
	}
}
