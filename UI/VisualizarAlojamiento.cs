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
                    dGV_Pagos.Rows.Add(pago.Tipo, pago.FechaPago.ToString("dd / MM / yyyy"), pago.FechaPago.ToString("H:mm"), pago.Monto);
                }
            }
        }
        public void CargarClientes(List<Cliente> pClientes, int pResponsable)
        {
            dGV_ClienteResponsable.Rows.Clear();
            dGV_Acompañantes.Rows.Clear();
            foreach (var cli in pClientes)
            {
                if (cli.ClienteId == pResponsable)
                {
                    dGV_ClienteResponsable.Rows.Add(cli.ClienteId, cli.Legajo, cli.Apellido, cli.Nombre, cli.TarifaCliente.NombreTarifa);
                }
                else
                {
                    dGV_Acompañantes.Rows.Add(cli.ClienteId,cli.Legajo, cli.Apellido, cli.Nombre, cli.TarifaCliente.NombreTarifa);
                }
            }
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

        public string CargarFecha(DateTime pFecha)
        {
            if (pFecha == new DateTime())
            {
                return "-";
            }
            else
            {
                return pFecha.ToString("dd / MM / yy");
            }

        }

        public void CargarFormulario(Alojamiento pAlojamiento)
        {
            lbl_IdAlojamiento.Text = pAlojamiento.AlojamientoId.ToString();
            lbl_EstadoActual.Text = pAlojamiento.EstadoAlojamiento.ToString();
            lbl_MontoDeuda.Text = pAlojamiento.MontoDeuda.ToString();
            lbl_MontoTotal.Text = pAlojamiento.MontoTotal.ToString();
            lbl_NroHabitacion.Text = pAlojamiento.HabitacionId.ToString();
            lbl_CuposSimples.Text = pAlojamiento.CantCuposSimples.ToString();
            lbl_CuposDobles.Text = pAlojamiento.CantCuposDobles.ToString();
            lbl_FechaReserva.Text = CargarFecha(pAlojamiento.FechaReserva);
            lbl_FechaIngreso.Text = CargarFecha(pAlojamiento.FechaIngreso);
            lbl_FechaEgreso.Text = CargarFecha(pAlojamiento.FechaEgreso);
            lbl_FechaEstIngreso.Text = CargarFecha(pAlojamiento.FechaEstimadaIngreso);
            lbl_FechaEstEgreso.Text = CargarFecha(pAlojamiento.FechaEstimadaEgreso);

            if (pAlojamiento.Exclusividad)
            {
                lbl_Exclusividad.Text = "SI";
            }
            else
            {
                lbl_Exclusividad.Text = "NO";
            }

            CargarClientes(pAlojamiento.Clientes, pAlojamiento.DniResponsable);
            CargarPagos(pAlojamiento.Pagos);
            CargarServicios(pAlojamiento.Servicios);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pestaña_Servicios_Enter(object sender, EventArgs e)
        {
            textBox_total.Text = totalServicios.ToString();
            textBox_total.Visible = true;
            label13.Visible = true;
        }

        private void pestaña_Servicios_Leave(object sender, EventArgs e)
        {
            textBox_total.Visible = false;
            label13.Visible = false;
        }

        private void pestaña_Pagos_Enter(object sender, EventArgs e)
        {
            textBox_total.Text = totalPagos.ToString();
            textBox_total.Visible = true;
            label13.Visible = true;
        }

        private void pestaña_Pagos_Leave(object sender, EventArgs e)
        {
            textBox_total.Visible = false;
            label13.Visible = false;
        }
    }
}
