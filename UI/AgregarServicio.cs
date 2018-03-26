using System;
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
        }

        public AgregarServicio(Alojamiento pAloj)
        {
            if (pAloj.EstadoAlojamiento != EstadoAlojamiento.Alojado)
            {
                if (pAloj.Pagos.Exists(p => p.Tipo == TipoPago.Alojado))
                {
                    btn_Aceptar.Enabled = false;
                    btn_buscarServicio.Enabled = false;
                    cant_Servicio.Enabled = false;
                    AlojSeleciconado = pAloj;
                    CargarAlojamientoSeccionado();
                }
                else
                {
                    VentanaEmergente ventanaEmergente = new VentanaEmergente("Para Agregar Servicios primero debe realizar un Pago de Alojado", TipoMensaje.Alerta);
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

        public void CargarAlojamientoSeccionado()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(AlojSeleciconado.AlojamientoId, AlojSeleciconado.EstadoAlojamiento, AlojSeleciconado.HabitacionId, AlojSeleciconado.DniResponsable, AlojSeleciconado.Clientes.Find(c => c.ClienteId == AlojSeleciconado.DniResponsable).NombreCompleto());
        }

        public void CargarServicioSeccionado()
        {
            dataGridView_Servicio.Rows.Clear();
            dataGridView_Servicio.Rows.Add(this.ServicioSeleccionado.Nombre, this.ServicioSeleccionado.CostoBase, DateTime.Now.ToString("dd / MM / yyyy"));
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
                        throw new Exception("Para Agregar Servicios antes debe realizar un Pago de Alojado");
                    }

                    AlojSeleciconado = BuscarAlojamiento.Aloj_Seleccionado;
                    CargarAlojamientoSeccionado();
                    btn_buscarServicio.Enabled = true;
                }
            }
            catch (Exception E)
            {
                //dataGridView1.Rows.Clear();//Aloj seleccionado
                //dataGridView_Servicio.Rows.Clear();
                //cant_Servicio.Value = 0;
                //gpb_Servicio.Enabled = false;
                //btn_buscarServicio.Enabled = false;
                //cant_Servicio.Enabled = false;

                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private void btn_buscarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                AdministrarServicios BuscarServicio = new AdministrarServicios();
				BuscarServicio.ShowDialog();
                if (BuscarServicio.ServicioSeleccionado != null)
                {
                    this.ServicioSeleccionado = BuscarServicio.ServicioSeleccionado;
                    CargarServicioSeccionado();
					cant_Servicio.Enabled = true;
                }
            }
            catch (Exception E)
            {
                new VentanaEmergente(E.Message, TipoMensaje.Alerta).ShowDialog();
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
            if (cant_Servicio.Value != 0)
            {
                btn_Aceptar.Enabled = true;
                lbl_total.Text = (this.ServicioSeleccionado.CostoBase * Convert.ToDouble(cant_Servicio.Value)).ToString();
            }
            else
            {
                btn_Aceptar.Enabled = false;
                lbl_total.Text = "-";
            } 
        }
    }
}
