﻿using System;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class CerrarAlojamiento : Form
    {
        public Alojamiento iAloj_Seleccionado;

        public CerrarAlojamiento()
        {
            InitializeComponent();
            lbl_fechaActual.Text = DateTime.Today.ToString("dd / MM / yyyy");
            lbl_fechaEstEgreso.Text = "-";
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            if (this.iAloj_Seleccionado!=null)
            {
                VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(iAloj_Seleccionado);
                VentanaVisualizar.ShowDialog();
            }
        }

        private void CargarAlojamientoSeccionado()
        {
            dGV_ListadoAlojamientos.Rows.Clear();
			if (iAloj_Seleccionado.MontoDeuda > 0)
			{
				label_deuda.Visible = true;
				pictureBox_deuda.Visible = true;
			}
			else
			{
				label_deuda.Visible = false;
				pictureBox_deuda.Visible = false;
			}
		}

        private void btn_BuscarAlojamiento_Click(object sender, EventArgs e)
        {
			try
			{
				BuscarAlojamiento BuscarAlojamiento = new BuscarAlojamiento();
				BuscarAlojamiento.ShowDialog();
				if (BuscarAlojamiento.Aloj_Seleccionado != null)
				{
					
					if (BuscarAlojamiento.Aloj_Seleccionado.EstadoAlojamiento != EstadoAlojamiento.Alojado)
					{
						throw new Exception("Solo se realiza el Cierre de Alojamientos en Estado Alojado");
					}

					if (!BuscarAlojamiento.Aloj_Seleccionado.Pagos.Exists(p => p.Tipo == TipoPago.Alojado))
					{
						throw new Exception("Se debe realizar un Pago de Alojado para realizar el Cierre del mismo");
					}

					iAloj_Seleccionado = BuscarAlojamiento.Aloj_Seleccionado;

					if (DateTime.Now.Date.CompareTo(iAloj_Seleccionado.FechaEstimadaEgreso.Date) == -1)
					{
						VentanaEmergente ventanaEmergente = new VentanaEmergente("La Fecha Estimada de Egreso no coincide con la Fecha Actual", TipoMensaje.Alerta);
						ventanaEmergente.ShowDialog();
					}

					CargarAlojamientoSeccionado();
					lbl_fechaEstEgreso.Text = iAloj_Seleccionado.FechaEstimadaEgreso.Date.ToString("dd / MM / yyyy");
					btn_Aceptar.Enabled = true;
				}
			}
			catch (Exception E)
			{
				VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
				ventanaEmergente.ShowDialog();
			}
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                new ControladorAlojamiento().CerrarAlojamiento(iAloj_Seleccionado);
                if (iAloj_Seleccionado.Servicios.Count != 0)
                    new VentanaEmergente("Cierre de Alojamiento Exitoso", TipoMensaje.CierreExistoso, iAloj_Seleccionado.AlojamientoId).ShowDialog();
                else
                    new VentanaEmergente("Cierre de Alojamiento Exitoso", TipoMensaje.Exito).ShowDialog();
                Close();
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
