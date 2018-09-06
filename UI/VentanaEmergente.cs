using System;
using System.Drawing;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class VentanaEmergente : Form
    {
        string Mensaje;
        TipoMensaje TipoMensaje;
        Alojamiento Alojamiento;
        public bool Aceptar = false;

        public VentanaEmergente(string pMensajePrincipal, TipoMensaje pTipoMensaje)
        {
            InitializeComponent();
            Mensaje = pMensajePrincipal;
            TipoMensaje = pTipoMensaje;
            button_cancelar.Visible = false;
            lbl_TextAux.Visible = false;
        }

        public VentanaEmergente(string pMensajePrincipal, TipoMensaje pTipoMensaje, int pIdAloj)
        {
            InitializeComponent();
            Mensaje = pMensajePrincipal;
            TipoMensaje = pTipoMensaje;
            Alojamiento = new ControladorAlojamiento().BuscarAlojamientoPorID(pIdAloj);
            lbl_TextAux.Visible = true;


            btn_Aceptar.Text = "Si";
            lbl_TextAux.Text = "¿Desea continuar?";
            btn_Aceptar.Location = new Point(266, 113);

            button_cancelar.Visible = true;
        }

        private void VentanaEmergente_Load(object sender, EventArgs e)
        {

            lbl_TextPrincipal.Text = Mensaje;
            this.Text = "¡Exito!";
            pictureBox_icon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_icon.Image = Properties.Resources.Exito_Icon;


            switch (TipoMensaje)
            {
                case TipoMensaje.Exito:
                    {

                    }
                    break;
                case TipoMensaje.Alerta:
                    {
                        this.Text = "¡Alerta!";
                        pictureBox_icon.Image = Properties.Resources.Alerta_Icon;
                    }
                    break;
                case TipoMensaje.ReservaExitosa:
                    {
                        lbl_TextAux.Text = "¿Desea realizar un Pago de Depósito?";
                        lbl_TextAux.Visible = true;
                    }
                    break;
                case TipoMensaje.AltaAlojamientoExitosa:
                    {
                        lbl_TextAux.Text = "¿Desea realizar un Pago de Alojado?";
                        lbl_TextAux.Visible = true;

                    }
                    break;
                case TipoMensaje.CierreExistoso:
                    {
                        lbl_TextAux.Text = "¿Desea realizar un Pago de Servicios?";
                        lbl_TextAux.Visible = true;
                    }
                    break;
                case TipoMensaje.SiNo:
                    {
                        pictureBox_icon.Image = Properties.Resources.Alerta_Icon;
                        btn_Aceptar.Text = "Si";
                        button_cancelar.Text = "No";
                        btn_Aceptar.Location = new Point(266, 113);

                        button_cancelar.Visible = true;
                        lbl_TextAux.Visible = true;
                    }
                    break;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (this.TipoMensaje == TipoMensaje.AltaAlojamientoExitosa || this.TipoMensaje == TipoMensaje.ReservaExitosa
                || TipoMensaje == TipoMensaje.CierreExistoso)
            {
                RegistrarPago registrarPago = new RegistrarPago(Alojamiento);
                registrarPago.ShowDialog();
            }
            else if (Mensaje == "¿Eliminar Usuario?" || TipoMensaje == TipoMensaje.SiNo)
            {
                Aceptar = true;
            }

            Close();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            if (TipoMensaje == TipoMensaje.SiNo)
                Aceptar = false;

            Close();
        }
    }

    public enum TipoMensaje
    {
        ReservaExitosa,
        AltaAlojamientoExitosa,
        CierreExistoso,
        Exito,
        Alerta,
        SiNo
    }
}
