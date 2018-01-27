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
    public partial class BuscarAlojamiento : Form
    {
        //ControladorAlojamiento ControladorAloj = new ControladorAlojamiento();
        public Alojamiento Aloj_Seleccionado;
        private Alojamiento auxAloj_Seleccionado;
        public DataGridViewCellCollection iFilaSeleccionada;

        public BuscarAlojamiento()
        {
            InitializeComponent();
            btn_Aceptar.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
            btn_Buscar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
            btn_Buscar.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        //LISTAR ALOJAMIENTO
        private void button3_Click(object sender, EventArgs e)
        {
            ListarAlojamientos ListarAlojamientos = new ListarAlojamientos();
            ListarAlojamientos.ShowDialog();
            auxAloj_Seleccionado = ListarAlojamientos.AlojSeleccionado;
            CargarAlojAux();
        }

        private void CargarAlojAux()
        {
            dGV_ListadoAlojamientos.Rows.Clear();
            if (auxAloj_Seleccionado != null)
            {
                dGV_ListadoAlojamientos.Rows.Add(this.auxAloj_Seleccionado.AlojamientoId, this.auxAloj_Seleccionado.EstadoAlojamiento, this.auxAloj_Seleccionado.Habitacion.HabitacionId,this.auxAloj_Seleccionado.DniResponsable, this.auxAloj_Seleccionado.Clientes.Find(c => c.ClienteId == this.auxAloj_Seleccionado.DniResponsable).NombreCompleto());
                btn_Aceptar.Enabled = true;
            }
            else
            {
                btn_Aceptar.Enabled = false;
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                auxAloj_Seleccionado = new ControladorAlojamiento().BuscarAlojamientoPorID(Convert.ToInt32(tbx_IdAlojamiento.Text));
                CargarAlojAux();
            }
            catch(FormatException)
            {
                if (tbx_IdAlojamiento.Text == "")
                {
                    VentanaEmergente ventanaEmergente = new VentanaEmergente("Debe ingresar un número de Alojamiento", TipoMensaje.Alerta);
                    ventanaEmergente.ShowDialog();
                }
                else
                {
                    VentanaEmergente ventanaEmergente = new VentanaEmergente("Formato Incorrecto: se debe ingresar un número sin espacios", TipoMensaje.Alerta);
                    ventanaEmergente.ShowDialog();
                }
            }
            catch (Exception pException)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(pException.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        //SELECCIONAR
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Aloj_Seleccionado = auxAloj_Seleccionado;
            Close();
        }

        //VER DETALLES
        private void button1_Click(object sender, EventArgs e)
        {
            if (dGV_ListadoAlojamientos.CurrentRow != null)
            {
                VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(auxAloj_Seleccionado);
                VentanaVisualizar.ShowDialog();
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Debe seleccionar un Alojamiento antes de Ver Detalles", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }
    }
}
