using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class VisualizarAlojamiento : Form
    {
        double totalPagos;
        double totalServicios;

        public VisualizarAlojamiento(Alojamiento pAlojamiento)
        {
            InitializeComponent();
            CargarFormulario(pAlojamiento);
        }

        public void CargarPagos(List<Pago> pPagos)
        {
            dGV_Pagos.Rows.Clear();
            if (pPagos.Count > 0)
            {
                totalPagos = 0;
                foreach (var pago in pPagos)
                {
                    totalPagos += pago.Monto;
                    dGV_Pagos.Rows.Add(pago.Tipo, pago.FechaPago.ToString("dd / MM / yyyy"), pago.FechaPago.ToString("H:mm"), pago.Monto,pago.Detalle);
                }
            }
        }
        public void CargarClientes(List<Cliente> pClientes, int pResponsable)
        {
            
        }

        public void CargarServicios(List<LineaServicio> pServicios)
        {
            dGV_Servicios.Rows.Clear();

            if (pServicios.Count > 0)
            {
                totalServicios = 0;
                foreach (var serv in pServicios)
                {
                    dGV_Servicios.Rows.Add(serv.Servicio.Nombre, serv.Servicio.CostoBase, serv.Cantidad, serv.FechaServicio.ToString("dd / MM / yyyy"), serv.CostoServicio);
                    totalServicios += serv.CostoServicio;
                }
            }
        }

        private string CargarFecha(DateTime pFecha)
        {
            if (pFecha == new DateTime())
                return "-";
            else
                return pFecha.ToString("dd / MM / yy");
        }

		private string CargarHora(string pFecha, DateTime pHora)
		{
			
			if (pFecha.CompareTo("-") == 0)
				return "-";
			else
				return pHora.ToString("H:mm");
		}

        public void CargarFormulario(Alojamiento pAlojamiento)
        {
            lbl_IdAlojamiento.Text = pAlojamiento.AlojamientoId.ToString();
            lbl_EstadoActual.Text = pAlojamiento.EstadoAlojamiento.ToString();
            lbl_MontoDeuda.Text = pAlojamiento.MontoDeuda.ToString();
            lbl_MontoTotal.Text = pAlojamiento.MontoTotal.ToString();
			lbl_FechaReserva.Text = CargarFecha(pAlojamiento.FechaReserva);
			lbl_hora1.Text = CargarHora(lbl_FechaReserva.Text,pAlojamiento.FechaReserva);
            lbl_FechaIngreso.Text = CargarFecha(pAlojamiento.FechaIngreso);
			lbl_hora4.Text = CargarHora(lbl_FechaIngreso.Text, pAlojamiento.FechaIngreso);
            lbl_FechaEgreso.Text = CargarFecha(pAlojamiento.FechaEgreso);
			lbl_hora5.Text = CargarHora(lbl_FechaEgreso.Text, pAlojamiento.FechaEgreso);
            lbl_FechaEstIngreso.Text = CargarFecha(pAlojamiento.FechaEstimadaIngreso);
			lbl_hora2.Text = CargarHora(lbl_FechaEstIngreso.Text, pAlojamiento.FechaEstimadaIngreso);
            lbl_FechaEstEgreso.Text = CargarFecha(pAlojamiento.FechaEstimadaEgreso);
			lbl_hora3.Text = CargarHora(lbl_FechaEstEgreso.Text, pAlojamiento.FechaEstimadaEgreso);
			lbl_value_fechaCancelacion.Text = CargarFecha(pAlojamiento.FechaCancelacion);
			lbl_hora6.Text = CargarHora(lbl_value_fechaCancelacion.Text, pAlojamiento.FechaCancelacion);
			

            CargarPagos(pAlojamiento.Pagos);
            CargarServicios(pAlojamiento.Servicios);
            if (pAlojamiento.EstadoAlojamiento == EstadoAlojamiento.Reservado)
            {
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pestaña_Servicios_Enter(object sender, EventArgs e)
        {
           
        }

        private void pestaña_Servicios_Leave(object sender, EventArgs e)
        {
            
        }

        private void pestaña_Pagos_Enter(object sender, EventArgs e)
        {
            
        }

        private void pestaña_Pagos_Leave(object sender, EventArgs e)
        {
            
        }

        private void AlojReserva(string pContadores)
        {
            
        }
    }
}
