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
    public partial class CancelarAlojamiento : Form
    {
        Alojamiento Aloj_Seleccionado;

        public CancelarAlojamiento()
        {
            InitializeComponent();
            lbl_fechaActual.Text = DateTime.Today.ToString("dd / MM / yyyy");
        }

        public CancelarAlojamiento(Alojamiento pAloj)
        {
            InitializeComponent();
            lbl_fechaActual.Text = DateTime.Today.ToString("dd / MM / yyyy");
            Aloj_Seleccionado = pAloj;
            CargarAlojamientoSeccionado(pAloj);
        }

        private void CargarAlojamientoSeccionado(Alojamiento pAloj)
        {
            dGV_ListadoAlojamientos.Rows.Clear();
            dGV_ListadoAlojamientos.Rows.Add(pAloj.AlojamientoId, pAloj.EstadoAlojamiento, pAloj.HabitacionId, pAloj.DniResponsable, pAloj.Clientes.Find(c => c.ClienteId == pAloj.DniResponsable).NombreCompleto());
        }

        private void btn_BuscarAlojamiento_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento BuscarAlojamiento = new BuscarAlojamiento();
            BuscarAlojamiento.ShowDialog();
			try
			{
				if (BuscarAlojamiento.Aloj_Seleccionado != null)
				{
					if (BuscarAlojamiento.Aloj_Seleccionado.EstadoAlojamiento != EstadoAlojamiento.Reservado)
					{
						throw new Exception("Operación Cancelada: Solo se puede Cancelar un Alojamiento que este Reservado");
					}

					Aloj_Seleccionado = BuscarAlojamiento.Aloj_Seleccionado;
					CargarAlojamientoSeccionado(this.Aloj_Seleccionado);
					btn_Aceptar.Enabled = true;
				}
			}
			catch (Exception E)
			{
				VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
				ventanaEmergente.ShowDialog();
				dGV_ListadoAlojamientos.Rows.Clear();
				btn_Aceptar.Enabled = false;
			}
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            if (dGV_ListadoAlojamientos.CurrentRow != null)
            {
                VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(Aloj_Seleccionado);
                VentanaVisualizar.ShowDialog();
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
                new ControladorAlojamiento().CancelarAlojamiento(Aloj_Seleccionado);
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Cancelación de Reserva de Alojamiento Exitosa", TipoMensaje.Exito);
                ventanaEmergente.ShowDialog();
                Close();
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }
    }
}
