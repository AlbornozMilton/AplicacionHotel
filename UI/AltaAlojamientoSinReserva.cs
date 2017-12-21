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
        public Habitacion iHabSeleccionada;
        public DateTime iFechaIni;
        public DateTime iFechaFin;
        Cliente iClienteResponsable;
        Alojamiento iNuevoAlojamiento;
        List<Cliente> iAcompañantes = new List<Cliente>();

        public AltaAlojamientoSinReserva()
        {
            InitializeComponent();
            textBox2.Text = Convert.ToString(DateTime.Today.Date);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = "HOLAAAA";
        }

        private void btn_VerificarDisponibilidad_Click(object sender, EventArgs e)
        {
            TablaDisponibilidad TablaDisp = new TablaDisponibilidad();
            TablaDisp.ShowDialog();
            txb_NroHabitacion.Text = Convert.ToString(TablaDisp.iHabSeleccionada.HabitacionId);
            this.iHabSeleccionada = TablaDisp.iHabSeleccionada;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            iHabSeleccionada.SetExclusividad(ck_Exclusividad.Checked);
            iHabSeleccionada.OcuparCupos(Convert.ToByte(cont_CuposSimples.Value),Convert.ToByte(cont_CuposDobles.Value));
            this.iNuevoAlojamiento = new Alojamiento(iHabSeleccionada, iClienteResponsable, iAcompañantes, iFechaIni, iFechaFin, Convert.ToByte(cont_CuposSimples.Value), Convert.ToByte(cont_CuposDobles.Value), ck_Exclusividad.Checked);
            iNuevoAlojamiento.CalcularCostoBase();
            txb_CostoBase.Text = iNuevoAlojamiento.MontoDeuda.ToString();
            //decimal[] contadores = new decimal[] { contador_Titular.Value, contador_Directo.Value, contador_NoDirecto.Value, contador_Exceptuado.Value, contador_Convenio.Value };
            //iNuevoAlojamiento.CalcularCostoBaseReserva(contadores);
            //////////////txb_CostoBase.Text = iNuevoAlojamiento.MontoTotal.ToString();
            //////////////txb_Deposito.Text = iNuevoAlojamiento.Deposito.ToString();
            //////////////btn_Aceptar.Enabled = true;

        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.ShowDialog();
            this.iClienteResponsable = BuscarClienteForm.iClienteSeleccionado;
            dGV_ClienteResponsable.Rows.Clear();
            dGV_Acompañantes.Rows.Clear();
            this.iAcompañantes.Clear();
            dGV_ClienteResponsable.Rows.Add(iClienteResponsable.ClienteId, iClienteResponsable.Apellido, iClienteResponsable.Nombre, iClienteResponsable.Telefono);
            this.iAcompañantes.Add(BuscarClienteForm.iClienteSeleccionado);

        }

        private void btn_AgregarAcompañante_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.ShowDialog();
            if (iAcompañantes.Contains(BuscarClienteForm.iClienteSeleccionado))
            {
                MessageBox.Show("Cliente ya agregado");
            }
            else
            {
                this.iAcompañantes.Add(BuscarClienteForm.iClienteSeleccionado);
                dGV_Acompañantes.Rows.Add(BuscarClienteForm.iClienteSeleccionado.ClienteId, BuscarClienteForm.iClienteSeleccionado.Apellido, BuscarClienteForm.iClienteSeleccionado.Nombre, BuscarClienteForm.iClienteSeleccionado.Telefono);
            }            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            new ControladorAlojamiento().RegistrarReservaAloj(this.iNuevoAlojamiento);
            MessageBox.Show("Alojamiento Registrado con Exito");
            Close();
        }
    }
}
