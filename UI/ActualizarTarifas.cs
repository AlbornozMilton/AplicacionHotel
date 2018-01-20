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
    public partial class ActualizarTarifas : Form
    {
        TarifaCliente iTarifaSeleccionada;
        public ActualizarTarifas()
        {
            InitializeComponent();
        }

        private void ActualizarTarifas_Load(object sender, EventArgs e)
        {
            txb_Tarifa.Enabled = false;
            txb_TarifaExclusiva.Enabled = false;
        }

        private void CargarTarifaSeleccionada(TarifaCliente pTarifa)
        {
            dGV_Tarifas.Rows.Clear();
            dGV_Tarifas.Rows.Add(pTarifa.NombreTarifa, pTarifa.Tarifa, pTarifa.TarifaExclusiva);
        }

        private void btn_ConsultarTarifas_Click(object sender, EventArgs e)
        {
            ConsultarTarifas VentanaTarifas = new ConsultarTarifas();
            VentanaTarifas.ShowDialog();
            if (VentanaTarifas.iTarifaSeleccionada != null)
            {
                this.iTarifaSeleccionada = VentanaTarifas.iTarifaSeleccionada;
                CargarTarifaSeleccionada(this.iTarifaSeleccionada);
                btn_Aceptar.Enabled = true;
            }
            else
            {
                dGV_Tarifas.Rows.Clear();
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                new ControladorExtra().AcutalizarTarifa(this.iTarifaSeleccionada, txb_Tarifa.Text, txb_TarifaExclusiva.Text);
                MessageBox.Show("Tarifa Actualizado");
                Close();
                ConsultarTarifas VentanaTarifas = new ConsultarTarifas();
                VentanaTarifas.ShowDialog();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dGV_Tarifas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txb_Tarifa.Enabled = true;
            txb_TarifaExclusiva.Enabled = true;
        }
    }
}
