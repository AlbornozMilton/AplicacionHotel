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
            txb_NroHabitacion.Text = Convert.ToString(TablaDisp.HabSeleccionada.HabitacionId);
            this.HabSeleccionada = TablaDisp.HabSeleccionada;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            HabSeleccionada.OcuparCupos(Convert.ToByte(cont_CuposSimples.Value),Convert.ToByte(cont_CuposDobles.Value));
            this.NuevoAlojamiento = new Alojamiento(HabSeleccionada, ClienteResponsable, Acompañantes, FechaIni, FechaFin, Convert.ToByte(cont_CuposSimples.Value), Convert.ToByte(cont_CuposDobles.Value), HabSeleccionada.Exclusiva);
            NuevoAlojamiento.CalcularCostoBase();
            txb_CostoBase.Text = NuevoAlojamiento.MontoDeuda.ToString();
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
    }
}
