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
    public partial class AltaAlojamientoSinReserva : Form
    {
        public Habitacion HabSeleccionada;
        public DateTime FechaIni;
        public DateTime FechaFin;
        public Cliente ClienteResponsable;
        public Alojamiento NuevoAlojamiento;
        public List<Cliente> Acompañantes;
        List<Cliente> auxListaCliReserva = new List<Cliente>(); //clientes de la reserva


        public AltaAlojamientoSinReserva()
        {
            InitializeComponent();
            txb_fechaActual.Text = DateTime.Today.ToString("dd/mm/yy");
            txb_fechaActual.Enabled = false;

            dtp_fechaDesde.Value = DateTime.Now;
            FechaIni = dtp_fechaDesde.Value;
            dtp_fechaHasta.Value = DateTime.Now.AddDays(1);
            FechaFin = dtp_fechaHasta.Value;
            txb_IdAloj.Enabled = false;
        }

        private void btn_VerificarDisponibilidad_Click(object sender, EventArgs e)
        {
            //si la fecha ini es manor que fecha fin
            if (FechaIni.CompareTo(FechaFin) == -1)
            {
                TablaDisponibilidad TablaDisp = new TablaDisponibilidad(FechaIni, FechaFin);
                TablaDisp.ShowDialog();

                if (TablaDisp.HabSeleccionada != null)
                {
                    txb_NroHabitacion.Text = Convert.ToString(TablaDisp.HabSeleccionada.HabitacionId);
                    this.HabSeleccionada = TablaDisp.HabSeleccionada;
                }
            }
            else
                MessageBox.Show("Las fechas seleccionadas no corresponden. Seleccione de nuevo.");
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (btn_VerificarDisponibilidad.Enabled == false) //se trata de alta de reserva
            {
                try
                {
                    //this.NuevoAlojamiento.SetIDAloj(Convert.ToInt32(txb_IdAloj.Text));
                    this.NuevoAlojamiento.Habitacion.OcuparCupos(this.NuevoAlojamiento.CantCuposSimples, this.NuevoAlojamiento.iCantCuposDobles);
                    this.NuevoAlojamiento.Habitacion.SetExclusividad(this.NuevoAlojamiento.Exclusividad);
                    this.NuevoAlojamiento.SetClientes(this.Acompañantes);
                    new ControladorAlojamiento().ComprobarClientesAltaConReserva(this.NuevoAlojamiento, txb_CostoBase.Text);
                    //EL ALOJAMIENTO CAMBIA A ESTADO ALOJADO Y LA FECHA DE INGRESO = DATETIME.NOW
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    Close();
                }
            }
            else //Alta sin Reserva, crea nuevo alojamiento con estado Alojado
            {
                HabSeleccionada.OcuparCupos(Convert.ToByte(cont_CuposSimples.Value), Convert.ToByte(cont_CuposDobles.Value));
                this.NuevoAlojamiento = new Alojamiento(HabSeleccionada, ClienteResponsable, Acompañantes, FechaIni, FechaFin, Convert.ToByte(cont_CuposSimples.Value), Convert.ToByte(cont_CuposDobles.Value), HabSeleccionada.Exclusiva);
                NuevoAlojamiento.CalcularCostoBase(new List<TarifaCliente>());
            }
            txb_CostoBase.Text = NuevoAlojamiento.MontoTotal.ToString();
            btn_Aceptar.Enabled = true;
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.ShowDialog();
            this.ClienteResponsable = BuscarClienteForm.iClienteSeleccionado;

            //comprobar que el cliente no esta "activo"

            dGV_ClienteResponsable.Rows.Clear();
            dGV_Acompañantes.Rows.Clear();
            if (Acompañantes!=null)
            {
              this.Acompañantes.Clear();
            }
            else
            {
                this.Acompañantes = new List<Cliente>();
            }
            dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.Telefono);
            this.Acompañantes.Add(BuscarClienteForm.iClienteSeleccionado);

        }

        private void btn_AgregarAcompañante_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.ShowDialog();

            //comprobar que el cliente no esta "activo"

            if (Acompañantes.Contains(BuscarClienteForm.iClienteSeleccionado))
            {
                MessageBox.Show("Cliente ya agregado");
            }
            else
            {
                this.Acompañantes.Add(BuscarClienteForm.iClienteSeleccionado);
                dGV_Acompañantes.Rows.Add(BuscarClienteForm.iClienteSeleccionado.ClienteId, BuscarClienteForm.iClienteSeleccionado.Apellido, BuscarClienteForm.iClienteSeleccionado.Nombre, BuscarClienteForm.iClienteSeleccionado.Telefono);
            }            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.NuevoAlojamiento.ContadoresTarifas==null)
                {
                    new ControladorAlojamiento().RegistrarAloj(this.NuevoAlojamiento);
                }
                else
                {
                    new ControladorAlojamiento().RegistrarAltaReserva(this.NuevoAlojamiento);
                }
                MessageBox.Show("Alojamiento Registrado con Exito.");
                Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message+E.InnerException.Message);
            }
        }

        private void dtp_fechaDesde_ValueChanged(object sender, EventArgs e)
        {
            this.FechaIni = dtp_fechaDesde.Value;
        }

        private void dtp_fechaHasta_ValueChanged(object sender, EventArgs e)
        {
            this.FechaFin = dtp_fechaHasta.Value;
        }

        private void ck_Exclusividad_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_VerificarDisponibilidad.Enabled)
            {
                this.HabSeleccionada.SetExclusividad(this.ck_Exclusividad.Checked); 
            }
        }

        #region Alta de Reserva
        public void RellenarCampos()
        {
            txb_IdAloj.Text = NuevoAlojamiento.AlojamientoId.ToString();
            dtp_fechaDesde.Value = NuevoAlojamiento.FechaEstimadaIngreso;
            dtp_fechaHasta.Value = NuevoAlojamiento.FechaEstimadaEgreso;
            txb_NroHabitacion.Text = NuevoAlojamiento.HabitacionId.ToString();
            cont_CuposSimples.Value = NuevoAlojamiento.CantCuposSimples;
            cont_CuposDobles.Value = NuevoAlojamiento.CantCuposDobles;
            ck_Exclusividad.Checked = NuevoAlojamiento.Exclusividad;

            //cliente responsable
            this.ClienteResponsable = NuevoAlojamiento.Clientes.Find(c => c.ClienteId == NuevoAlojamiento.DniResponsable);
            dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.Telefono);
            this.Acompañantes = new List<Cliente>();
            this.Acompañantes.Add(ClienteResponsable);

            HabSeleccionada = NuevoAlojamiento.Habitacion;
            HabSeleccionada.SetExclusividad(NuevoAlojamiento.Exclusividad);

            //para almacenar el valor de costo base de reserva y luego comparar
            txb_CostoBase.Text = NuevoAlojamiento.MontoTotal.ToString();

            //--------Por la reserva------------------------
            if (!btn_VerificarDisponibilidad.Enabled)
            {
                auxListaCliReserva = NuevoAlojamiento.Clientes;
            }
            //-------------------------------------
        }

        /// <summary>
        /// Modifica el campo Enable de una conjunto de propiedades de la Form al valor de parámetro
        /// </summary>
        public void EnableAll(bool pValorEnable)
        {
            dtp_fechaDesde.Enabled = pValorEnable;
            dtp_fechaHasta.Enabled = pValorEnable;
            cont_CuposSimples.Enabled = pValorEnable;
            cont_CuposDobles.Enabled = pValorEnable;
            ck_Exclusividad.Enabled = pValorEnable;

            btn_VerificarDisponibilidad.Enabled = pValorEnable;
            btn_AgregarCliente.Enabled = pValorEnable;
            tbx_dniResponsable.Enabled = pValorEnable;
            dGV_ClienteResponsable.Enabled = pValorEnable;

            txb_CostoBase.Enabled = pValorEnable;

            btn_Aceptar.Enabled = pValorEnable;

        }
        #endregion
    }
}
