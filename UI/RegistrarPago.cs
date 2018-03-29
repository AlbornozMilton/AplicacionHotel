using System;
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
            lbl_MostrarFecha.Text = DateTime.Now.ToString("dd / MM / yyyy");
        }

        private void CargarPagos()
        {
			cbx_TipoPago.Items.Clear();
			txb_Monto.Text = "-";
			ck_ModificarMonto.Enabled = false;

			switch (AlojSeleccionado.EstadoAlojamiento)
            {
                case EstadoAlojamiento.Reservado:
                    {
                        if (!(AlojSeleccionado.Pagos.Exists(p => p.Tipo.ToString() == "Deposito"))
							&&
							AlojSeleccionado.Deposito != 0)
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
                    if (AlojSeleccionado.MontoDeuda > 0)
                    {
                        if (!(AlojSeleccionado.Pagos.Exists(p => p.Tipo.ToString() == "Servicios")))
                        {
                            cbx_TipoPago.Items.Add("Servicios");
                        }
                        else
                        {
                            cbx_TipoPago.Items.Add("Deuda");
                        }
                    }
                    break;
            }
        }
        
        public RegistrarPago(Alojamiento pAloj)
        {
            InitializeComponent();
            if (pAloj.EstadoAlojamiento != EstadoAlojamiento.Cancelado)
            {
				gbx_Pago.Enabled = true;
				button1.Enabled = false;
                AlojSeleccionado = pAloj;
                lbl_MostrarFecha.Text = DateTime.Now.ToString("dd / MM / yyyy");
                CargarAlojamientoSeccionado();
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("No se realizan Pagos de Alojamientos Cancelados", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
				Close();
            }
        }

        public void CargarAlojamientoSeccionado()
        {
            CargarPagos();
            dGV_ListadoAlojamientos.Rows.Clear();
            dGV_ListadoAlojamientos.Rows.Add(AlojSeleccionado.AlojamientoId, AlojSeleccionado.EstadoAlojamiento, AlojSeleccionado.HabitacionId, AlojSeleccionado.DniResponsable, AlojSeleccionado.Clientes.Find(c => c.ClienteId == AlojSeleccionado.DniResponsable).NombreCompleto());
        }

        //Buscar otro alojamiento
        private void button1_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento VentanaBuscarAlojamiento = new BuscarAlojamiento();
            VentanaBuscarAlojamiento.ShowDialog();

            if (VentanaBuscarAlojamiento.Aloj_Seleccionado != null)
            {
                if (VentanaBuscarAlojamiento.Aloj_Seleccionado.EstadoAlojamiento != EstadoAlojamiento.Cancelado)
                {
                    AlojSeleccionado = VentanaBuscarAlojamiento.Aloj_Seleccionado;
                    CargarAlojamientoSeccionado();
                    gbx_Pago.Enabled = true;
                }
                else
                {
					VentanaEmergente ventanaEmergente = new VentanaEmergente("No se realizan Pagos de Alojamientos Cancelados", TipoMensaje.Alerta);
                    ventanaEmergente.ShowDialog();
                }
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
            if (cbx_TipoPago.SelectedItem.ToString() == "Deposito")
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
			btn_Aceptar.Enabled = true;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
				ValidarDatos();
				Pago Pago = new Pago(cbx_TipoPago.SelectedItem.ToString(), Convert.ToDouble(txb_Monto.Text), txb_Detalle.Text);
				new ControladorAlojamiento().AddPago(AlojSeleccionado, Pago);
				string mensaje = "Pago de Alojamiento Exitoso";
				if (Pago.Tipo == TipoPago.Servicios && Pago.Monto != AlojSeleccionado.MontoDeuda)
					mensaje += ". El Alojamiento quedó con DEUDA.";
				VentanaEmergente ventanaEmergente = new VentanaEmergente(mensaje, TipoMensaje.Exito);
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
            if (Convert.ToInt32(monto) < 0)
            {
                throw new Exception("Debe ingresar un Monto mayor a cero");
            }
            else if ((Int32.TryParse(txb_Monto.Text, out numero)) == false)
            {
                throw new Exception("Formato inválido de Monto. Solo se admiten dígitos.");
            }
            else if (Convert.ToDouble(monto) > AlojSeleccionado.MontoDeuda)
            {
                throw new Exception("El Monto ingresado es superior al Monto Deuda del Alojamiento.");
            }
        }

        //Ver detalles
        private void button2_Click(object sender, EventArgs e)
        {
            if (dGV_ListadoAlojamientos.CurrentRow != null)
            {
                VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(AlojSeleccionado);
                VentanaVisualizar.ShowDialog();
            }
        }

		private void txb_Monto_Leave(object sender, EventArgs e)
		{
			if (txb_Monto.Text == "")
			{
				txb_Monto.Text = "0";
			}
		}
	}
}
