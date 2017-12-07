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
    public partial class RegistrarPago : Form
    {
        public Alojamiento iAlojSeleccionado;
        public RegistrarPago()
        {
            InitializeComponent();
            lbl_MostrarFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public void CargarAlojamientoSeccionado(DataGridViewCellCollection fila)
        {
            dGV_ListadoAlojamientos.Rows.Clear();
            dGV_ListadoAlojamientos.Rows.Add(fila[0].Value, fila[1].Value, fila[2].Value, fila[3].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento VentanaBuscarAlojamiento = new BuscarAlojamiento();
            VentanaBuscarAlojamiento.iFormPadre = this;
            VentanaBuscarAlojamiento.ShowDialog();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ck_ModificarMonto_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_ModificarMonto.Checked)
            {
                txb_Monto.ReadOnly = false;
            }
            else
            {
                txb_Monto.ReadOnly = true;
            }
        }

        private void cbx_TipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_TipoPago.SelectedItem.ToString() == "Depósito")
            {
                txb_Monto.Text = iAlojSeleccionado.Deposito.ToString();
            }
            else
            {
                txb_Monto.Text = iAlojSeleccionado.MontoDeuda.ToString();
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorAlojamiento iControladorAloj = new ControladorAlojamiento();
                Pago iPago = new Pago(cbx_TipoPago.SelectedItem.ToString(), Convert.ToDouble(txb_Monto.Text), txb_Detalle.Text);
                iControladorAloj.ControlTipoPago(iAlojSeleccionado, iPago);
                iControladorAloj.AddPago(iAlojSeleccionado);
            }
            catch (Exception pException)
            {
                MessageBox.Show(pException.Message);
            }
        }
    }
}
