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
    public partial class AltaReservaAlojamiento : Form
    {
        public Habitacion iHabSeleccionada;
        public DateTime iFechaIni;
        public DateTime iFechaFin;
        public Cliente iClienteResponsable;
        Alojamiento iNuevoAlojamiento;

        public AltaReservaAlojamiento()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label14.Visible = true;
            btn_Confirmar.Image = Properties.Resources.Boton_Ok_Seleccion_3;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            label14.Visible = false;
            btn_Confirmar.Image = Properties.Resources.Boton_Ok_2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            //button4.BackColor = Color.Yellow 255, 255, 128};
        }

        private void btn_VerificarDisponibilidad_Click(object sender, EventArgs e)
        {
            TablaDisponibilidad TablaDisp = new TablaDisponibilidad(dtp_fechaDesde.Value,dtp_fechaHasta.Value);
            TablaDisp.ShowDialog();
            tbx_NroHab.Text = Convert.ToString(TablaDisp.iHabSeleccionada.HabitacionId);
            this.iHabSeleccionada = TablaDisp.iHabSeleccionada;
            this.iFechaIni = TablaDisp.iFechaIni;
            this.iFechaFin = TablaDisp.iFechaFin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.ShowDialog();
            this.iClienteResponsable = BuscarClienteForm.iClienteSeleccionado;
            dGV_ClienteResponsable.Rows.Clear();
            dGV_ClienteResponsable.Rows.Add(iClienteResponsable.ClienteId, iClienteResponsable.Apellido, iClienteResponsable.Nombre, iClienteResponsable.Telefono);
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            this.iNuevoAlojamiento = new Alojamiento(iHabSeleccionada, iClienteResponsable, iFechaIni, iFechaFin, Convert.ToByte(cont_CuposSimples.Value), Convert.ToByte(cont_CuposDobles.Value), ck_Exclusividad.Checked);
            decimal[] contadores = new decimal[] { contador_Titular.Value, contador_Directo.Value, contador_NoDirecto.Value, contador_Exceptuado.Value, contador_Convenio.Value};
            iNuevoAlojamiento.CalcularCostoBase(contadores);
            txb_CostoBase.Text = iNuevoAlojamiento.MontoTotal.ToString();
            txb_Deposito.Text = iNuevoAlojamiento.Deposito.ToString();
            btn_Aceptar.Enabled = true;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            new ControladorAlojamiento().RegistrarReservaAloj(this.iNuevoAlojamiento);
            MessageBox.Show("Reserva Registrada con Exito");
            Close();
        }
    }
}
