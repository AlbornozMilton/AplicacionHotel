using Dominio;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class ActualizarTarifas : Form
    {
        TarifaCliente iTarifa;
        public ActualizarTarifas()
        {
            InitializeComponent();
        }

        private void CargarTarifaSeleccionada()
        {
            dGV_Tarifas.Rows.Clear();
            dGV_Tarifas.Rows.Add(iTarifa.NombreTarifa, iTarifa.Tarifa, iTarifa.TarifaExclusiva);
        }

        private void btn_ConsultarTarifas_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultarTarifas VentanaTarifas = new ConsultarTarifas(true);
                VentanaTarifas.ShowDialog();
                if (VentanaTarifas.iTarifaSeleccionada != null)
                {
                    this.iTarifa = VentanaTarifas.iTarifaSeleccionada;
                    CargarTarifaSeleccionada();
                    txb_Tarifa.Enabled = true;
                    btn_Aceptar.Enabled = true;
					txb_TarifaExclusiva.Text = "";
					txb_TarifaExclusiva.Enabled = true;
					txb_Tarifa.Text = "";
				}
            }
            catch (Exception E)
            {
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                new ControladorExtra().ActualizarTarifa(this.iTarifa, txb_Tarifa.Text, txb_TarifaExclusiva.Text);
                VentanaEmergente ventanaEmergente = new VentanaEmergente("      Tarifa Actualizada", TipoMensaje.Exito);
                ventanaEmergente.ShowDialog();
                Close();
                ConsultarTarifas VentanaTarifas = new ConsultarTarifas();
                VentanaTarifas.ShowDialog();
            }
			catch (FormatException)
			{
				if (txb_TarifaExclusiva.Text == "" || txb_Tarifa.Text == "")
				{
					new VentanaEmergente("Debe ingresar un nuevo Costo", TipoMensaje.Alerta).ShowDialog();
				}
				else
				{
					new VentanaEmergente("Costo Incorrecto: se deben ingresar solo números", TipoMensaje.Alerta).ShowDialog();
				}
			}
			catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
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
