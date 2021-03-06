﻿using System;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class BuscarAlojamiento : Form
    {
        public Alojamiento Aloj_Seleccionado;
        private Alojamiento auxAloj_Seleccionado;
        public DataGridViewCellCollection iFilaSeleccionada;

        public BuscarAlojamiento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            btn_Buscar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
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
                string Habs = "";
                foreach (var ah in auxAloj_Seleccionado.AlojHabes)
                {
                    Habs += ah.Habitacion.HabitacionId + ", ";
                }
                Habs = Habs.Remove(Habs.Length - 2);

                Cliente responsable = new ControladorCliente().BuscarClientePorDni(auxAloj_Seleccionado.DniResponsable, true);

                dGV_ListadoAlojamientos.Rows.Add(this.auxAloj_Seleccionado.AlojamientoId, this.auxAloj_Seleccionado.EstadoAlojamiento, Habs, responsable.NombreCompleto(), this.auxAloj_Seleccionado.DniResponsable);
                btn_Aceptar.Enabled = true;
            }
            else
                btn_Aceptar.Enabled = false;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                auxAloj_Seleccionado = new ControladorAlojamiento().BuscarAlojamientoPorID(Convert.ToInt32(tbx_IdAlojamiento.Text));
                CargarAlojAux();
            }
            catch (FormatException)
            {
                if (tbx_IdAlojamiento.Text == "")
                {
                    VentanaEmergente ventanaEmergente = new VentanaEmergente("Debe ingresar un número de Alojamiento", TipoMensaje.Alerta);
                    ventanaEmergente.ShowDialog();
                }
                else
                {
                    VentanaEmergente ventanaEmergente = new VentanaEmergente("Formato Incorrecto: se debe ingresar números sin espacios", TipoMensaje.Alerta);
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

        public void SetVisibleSeleccionar(bool pValor)
        {
            btn_Aceptar.Visible = pValor;
        }
    }
}
