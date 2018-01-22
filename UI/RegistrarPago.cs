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
        public Alojamiento AlojSeleccionado;

        public RegistrarPago()
        {
            InitializeComponent();
            gbx_Pago.Enabled = false;
            btn_Aceptar.Enabled = false;
            ck_ModificarMonto.Enabled = false;
            lbl_MostrarFecha.Text = DateTime.Now.ToString("dd / MM / yyyy");
        }

        private void CargarPagos()
        {
            cbx_TipoPago.Text = "Ninguno";
            switch (AlojSeleccionado.EstadoAlojamiento)
            {
                case EstadoAlojamiento.Reservado:
                    {
                        if (!(AlojSeleccionado.Pagos.Exists(p => p.Tipo.ToString() == "Deposito")))
                        {
                            cbx_TipoPago.Items.Add("Deposito");
                        }
                    }
                    break;
                case EstadoAlojamiento.Alojado:
                    if (!(AlojSeleccionado.Pagos.Exists(p => p.Tipo.ToString() == "Alojado")))
                    {
                        cbx_TipoPago.Items.Add("Alojado");
                    }
                    break;
                case EstadoAlojamiento.Cerrado:
                    if (!(AlojSeleccionado.Pagos.Exists(p => p.Tipo.ToString() == "Servicios")))
                    {
                        cbx_TipoPago.Items.Add("Servicios");

                    }
                    break;
                case EstadoAlojamiento.Cancelado:
                    if (!(AlojSeleccionado.Pagos.Exists(p => p.Tipo.ToString() == "Deuda")))
                    {
                        cbx_TipoPago.Items.Add("Deuda");
                    }
                    break;
            }
        }
        
        public RegistrarPago(Alojamiento pAloj)
        {
            InitializeComponent();
            AlojSeleccionado = pAloj;
            lbl_MostrarFecha.Text = DateTime.Now.ToString("dd / MM / yyyy");
            CargarAlojamientoSeccionado();
            ck_ModificarMonto.Enabled = false;

        }

        public void CargarAlojamientoSeccionado()
        {
            CargarPagos();
            dGV_ListadoAlojamientos.Rows.Clear();
            dGV_ListadoAlojamientos.Rows.Add(AlojSeleccionado.AlojamientoId, AlojSeleccionado.EstadoAlojamiento, AlojSeleccionado.DniResponsable, AlojSeleccionado.Clientes.Find(c => c.ClienteId == AlojSeleccionado.DniResponsable).NombreCompleto(), AlojSeleccionado.HabitacionId);
        }

        //Buscar otro alojamiento
        private void button1_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento VentanaBuscarAlojamiento = new BuscarAlojamiento();
            VentanaBuscarAlojamiento.ShowDialog();

            if (VentanaBuscarAlojamiento.Aloj_Seleccionado != null)
            {
                AlojSeleccionado = VentanaBuscarAlojamiento.Aloj_Seleccionado;
                CargarAlojamientoSeccionado();
                gbx_Pago.Enabled = true;
                btn_Aceptar.Enabled = true;
            }
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
            if (dGV_ListadoAlojamientos.Rows.Count <= 0)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Debe seleccionar un Alojamiento", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            } 
            else if (cbx_TipoPago.SelectedItem.ToString() == "Deposito")
            {
                txb_Monto.Text = AlojSeleccionado.Deposito.ToString();
            }
            else if (cbx_TipoPago.SelectedItem.ToString() == "Servicios")
            {
                ck_ModificarMonto.Enabled = true;
                txb_Monto.Text = AlojSeleccionado.MontoDeuda.ToString();
            }
            else
            {
                txb_Monto.Text = AlojSeleccionado.MontoDeuda.ToString();
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarDatos();
                ControladorAlojamiento iControladorAloj = new ControladorAlojamiento();
                Pago Pago = new Pago(cbx_TipoPago.SelectedItem.ToString(), Convert.ToDouble(txb_Monto.Text), txb_Detalle.Text);
                //iControladorAloj.ControlTipoPago(AlojSeleccionado, iPago);
                iControladorAloj.AddPago(AlojSeleccionado,Pago);
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Pago de Alojamiento Exitoso", TipoMensaje.Exito);
                ventanaEmergente.ShowDialog();
                Close();
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private void ValidarDatos()
        {
            int numero;
            string monto = txb_Monto.Text;
            if (cbx_TipoPago.SelectedItem == null)
            {
                throw new Exception("Debe seleccionar el Tipo de Pago");
            }
            if (monto == "")
            {
                throw new Exception("Debe ingresar un Monto");
            }
            else if ((Int32.TryParse(txb_Monto.Text, out numero)) == false)
            {
                throw new Exception("Formato invalido de monto");
            }
            else if (Convert.ToInt32(monto) <= 0)
            {
                throw new Exception("Monto debe ser mayor a cero");
            }
        }

        //Ver detalles
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.AlojSeleccionado != null)
            {
                VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(AlojSeleccionado);
                VentanaVisualizar.ShowDialog();
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Debe seleccionar un Alojamiento antes de Ver Detalles", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }
    }
}
