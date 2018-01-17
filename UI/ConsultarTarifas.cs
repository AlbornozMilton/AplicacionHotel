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
    public partial class ConsultarTarifas : Form
    {
        public TarifaCliente iTarifaSeleccionada;
        public List<TarifaCliente> ListaTarifas = new ControladorExtra().ObtenerTarifas();
        public ConsultarTarifas()
        {
            InitializeComponent();
            CargarTarifas();
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
    }
}
