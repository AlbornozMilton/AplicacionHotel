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
    public partial class AgregarServicio : Form
    {
        public Alojamiento AlojSeleciconado;
        public Servicio ServicioSeleccionado;
        //public LineaServicio lLineaServecio;

        public AgregarServicio()
        {
            InitializeComponent();
            btn_Aceptar.Enabled = false;
            btn_buscarServicio.Enabled = false;
            gpb_Servicio.Enabled = false;
            cant_Servicio.Enabled = false;
        }

        public AgregarServicio(Alojamiento pAloj)
        {
            if (pAloj.EstadoAlojamiento != EstadoAlojamiento.Alojado)
            {
                if (pAloj.Pagos.Exists(p => p.Tipo == TipoPago.Alojado))
                {
                    InitializeComponent();
                    btn_Aceptar.Enabled = false;
                    btn_buscarServicio.Enabled = false;
                    cant_Servicio.Enabled = false;
                    AlojSeleciconado = pAloj;
                    CargarAlojamientoSeccionado(AlojSeleciconado);
                }
                else
                {
                    VentanaEmergente ventanaEmergente = new VentanaEmergente("Para agregar Servicios debe realziar un Pago de Alojado", TipoMensaje.Alerta);
                    ventanaEmergente.ShowDialog();
                    Close();
                }
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Solo se Agregan Servicios a Alojamientos en Estado Alojado", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        public void CargarAlojamientoSeccionado(Alojamiento pAloj)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(pAloj.AlojamientoId,pAloj.EstadoAlojamiento, pAloj.HabitacionId,pAloj.DniResponsable, pAloj.Clientes.Find(c => c.ClienteId == pAloj.DniResponsable).NombreCompleto());
        }

        public void CargarServicioSeccionado(Servicio pServicio)
        {
            dataGridView_Servicio.Rows.Clear();
            dataGridView_Servicio.Rows.Add(pServicio.Nombre, pServicio.CostoBase, DateTime.Now.ToString("dd / MM / yyyy"));
        }

        private void btn_BuscarAlojamiento_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento BuscarAlojamiento = new BuscarAlojamiento();
            BuscarAlojamiento.ShowDialog();
            try
            {
                if (BuscarAlojamiento.Aloj_Seleccionado != null)
                {
                    if (BuscarAlojamiento.Aloj_Seleccionado.EstadoAlojamiento != EstadoAlojamiento.Alojado)
                    {
                        throw new Exception("Solo se Agregan Servicios a Alojamientos en Estado Alojado");
                    }

                    if (!BuscarAlojamiento.Aloj_Seleccionado.Pagos.Exists(p => p.Tipo == TipoPago.Alojado))
                    {
                        throw new Exception("Para gregar Servicios debe realizar un Pago de Alojado");
                    }

                    AlojSeleciconado = BuscarAlojamiento.Aloj_Seleccionado;
                    CargarAlojamientoSeccionado(AlojSeleciconado);
                    btn_buscarServicio.Enabled = true;
                    gpb_Servicio.Enabled = true;
                    cant_Servicio.Enabled = true;
                }
                else
                {
                   
                    throw new Exception("Debe seleccionar un Alojamiento");
                }
            }
            catch (Exception E)
            {
                dataGridView1.Rows.Clear();//Aloj seleccionado
                dataGridView_Servicio.Rows.Clear();
                cant_Servicio.Value = 0;
                gpb_Servicio.Enabled = false;
                btn_buscarServicio.Enabled = false;
                cant_Servicio.Enabled = false;

                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private void btn_buscarServicio_Click(object sender, EventArgs e)
        {
            AdministrarServicios Actualizar = new AdministrarServicios();
            Actualizar.ShowDialog();
            if (Actualizar.ServicioSeleccionado != null)
            {
                this.ServicioSeleccionado = Actualizar.ServicioSeleccionado;
                CargarServicioSeccionado(this.ServicioSeleccionado);
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            new ControladorAlojamiento().AgregarServicio(this.ServicioSeleccionado, Convert.ToByte(cant_Servicio.Value), AlojSeleciconado);
            VentanaEmergente ventanaEmergente = new VentanaEmergente("Servicio Agregado Correctamente", TipoMensaje.Exito);
            ventanaEmergente.ShowDialog();
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cant_Servicio_ValueChanged(object sender, EventArgs e)
        {
            if (ServicioSeleccionado != null)
            {
                if (cant_Servicio.Value != 0)
                {
                    btn_Aceptar.Enabled = true;
                    lbl_total.Text = (this.ServicioSeleccionado.CostoBase * Convert.ToDouble(cant_Servicio.Value)).ToString();
                }
                else
                {
                    btn_Aceptar.Enabled = false;
                    lbl_txtTotal.Text = "-";
                } 
            }
        }
    }
}
