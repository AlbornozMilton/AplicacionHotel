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
        public Habitacion iHabitacionSeccionada = new Habitacion();
        public DateTime iFechaEstimadaIngreso = new DateTime();
        public DateTime iFechaEstimadaEgreso = new DateTime();
        public Cliente iClienteResponsable = new Cliente(); 

        public AltaReservaAlojamiento()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            TablaDisponibilidad TDisp = new TablaDisponibilidad(dtp_fechaDesde,dtp_fechaHasta);
            TDisp.FormPadre = this; //Almacena esta WinForm como la padre de la TDisp con el atributo Opener
            TDisp.ShowDialog();
        }
        
        public void cargar_Nro_Habitacion (int nroHab)
        {
            tbx_NroHab.Text = nroHab.ToString();
        }

        public void agregar_Cliente (DataGridViewCellCollection fila)
        {
            dGV_ClienteResponsable.Rows.Add(fila[0].Value, fila[1].Value, fila[2].Value, fila[3].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.FormPadre = this;
            BuscarClienteForm.ShowDialog();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            Alojamiento NuevoAlojamiento = new Alojamiento(iHabitacionSeccionada, iClienteResponsable, iFechaEstimadaIngreso, iFechaEstimadaEgreso);
            NuevoAlojamiento.CalcularCostoBaseReserva(Convert.ToInt32(contador_Titular.Value), Convert.ToInt32(contador_Convenio.Value), Convert.ToInt32(contador_Exceptuado.Value), Convert.ToInt32(contador_Directo.Value), Convert.ToInt32(contador_NoDirecto.Value));
            txb_CostoBase.Text = NuevoAlojamiento.MontoTotal.ToString();
            txb_Deposito.Text = NuevoAlojamiento.Deposito.ToString();
        }
    }
}
