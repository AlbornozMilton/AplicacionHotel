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
        double auxCostoBase;


        public AltaAlojamientoSinReserva()
        {
            InitializeComponent();
            txb_fechaActual.Text = DateTime.Today.ToString("dd/mm/yy");
            txb_fechaActual.Enabled = false;

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
            //-------realizar control de costo base para alta de reserva
            //en este momento el total es igual al costo base
            if (!txb_CostoBase.Enabled) //en momento de alta reserva
            {
                auxCostoBase = NuevoAlojamiento.MontoTotal;
            }

            //-------------alta sin reserva
            HabSeleccionada.OcuparCupos(Convert.ToByte(cont_CuposSimples.Value),Convert.ToByte(cont_CuposDobles.Value));
            this.NuevoAlojamiento = new Alojamiento(HabSeleccionada, ClienteResponsable, Acompañantes, FechaIni, FechaFin, Convert.ToByte(cont_CuposSimples.Value), Convert.ToByte(cont_CuposDobles.Value), HabSeleccionada.Exclusiva);
            NuevoAlojamiento.CalcularCostoBase();
            txb_CostoBase.Text = NuevoAlojamiento.MontoDeuda.ToString();

            if (auxCostoBase != NuevoAlojamiento.MontoTotal) //error
            {

            }

            //-----------------
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.ShowDialog();
            this.ClienteResponsable = BuscarClienteForm.iClienteSeleccionado;
            dGV_ClienteResponsable.Rows.Clear();
            dGV_Acompañantes.Rows.Clear();
            this.Acompañantes.Clear();
            dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.Telefono);
            this.Acompañantes.Add(BuscarClienteForm.iClienteSeleccionado);

        }

        private void btn_AgregarAcompañante_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.ShowDialog();
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
            new ControladorAlojamiento().RegistrarReservaAloj(this.NuevoAlojamiento);
            MessageBox.Show("Alojamiento Registrado con Exito");
            Close();
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
            //No es en alta reserva y se puede modificar. Caso contrario se debe evitar este evento.
            if (ck_Exclusividad.Enabled)
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

        }
        #endregion
    }
}
