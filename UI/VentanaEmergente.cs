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
    public partial class VentanaEmergente : Form
    {
        string Mensaje;
        TipoMensaje TipoMensaje;
        Alojamiento Alojamiento;

        public VentanaEmergente(string pMensajePrincipal, TipoMensaje pTipoMensaje)
        {
            InitializeComponent();
            Mensaje = pMensajePrincipal;
            TipoMensaje = pTipoMensaje;
            button_cancelar.Visible = false;
            lbl_TextAux.Visible = false;
        }

        public VentanaEmergente(string pMensajePrincipal, TipoMensaje pTipoMensaje,int pIdAloj)
        {
            InitializeComponent();
            Mensaje = pMensajePrincipal;
            TipoMensaje = pTipoMensaje;
            Alojamiento = new ControladorAlojamiento().BuscarAlojamientoPorID(pIdAloj);

            pictureBox_icon.Location = new Point(37, 12);
            lbl_TextPrincipal.Location = new Point(118, 34);

            //lbl_TextAux.Text = "¿Desea realizar un Pago de Depósito?";
            lbl_TextAux.Location = new Point(66, 87);
            lbl_TextAux.Visible = true;


            btn_Aceptar.Text = "Realizar Pago";
            btn_Aceptar.Location = new Point(242, 113);
            btn_Aceptar.Size = new Size(132, 30);

            button_cancelar.Visible = true;
        }

        private void VentanaEmergente_Load(object sender, EventArgs e)
        {

            lbl_TextPrincipal.Text = Mensaje;
            this.Text = "Exito";
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
                        lbl_TextAux.Visible = true;
                        lbl_TextAux.Text = "¿Desea realizar un Pago de Depósito?";
                    }
                    break;
                case TipoMensaje.AltaAlojamientoExitosa:
                    {
                        lbl_TextAux.Visible = true;
                        lbl_TextAux.Text = "¿Desea realizar un Pago de Alojado?";
                        
                    }
                    break;
                case TipoMensaje.CierreExistoso:
                    {
                        lbl_TextAux.Visible = true;
                        lbl_TextAux.Text = "¿Desea realizar un Pago de Servicios?";
                    }
                    break;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (this.TipoMensaje == TipoMensaje.AltaAlojamientoExitosa|| this.TipoMensaje == TipoMensaje.ReservaExitosa 
                || TipoMensaje == TipoMensaje.CierreExistoso)
            {
                RegistrarPago registrarPago = new RegistrarPago(Alojamiento);
                registrarPago.ShowDialog();
                Close();
            }else
	        {
                Close();
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public enum TipoMensaje
    {
        ReservaExitosa,
        AltaAlojamientoExitosa,
        CierreExistoso,
        Exito,
        Alerta
    }
}
