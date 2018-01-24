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
    public partial class VentanaPrincipal : Form
    {
        public InicioSesion iPadre;
        ControladorAlojamiento iControladorAlojamiento = new ControladorAlojamiento();

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAlojamientoSinReserva NuevoAlojamiento = new AltaAlojamientoSinReserva();
            NuevoAlojamiento.ShowDialog();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaReservaAlojamiento NuevaReserva = new AltaReservaAlojamiento();
            NuevaReserva.ShowDialog();
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioSesion NuevoInicio = new InicioSesion();
            NuevoInicio.ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            

            dtp_fechaHasta.Value = DateTime.Now.AddDays(1);
            CargarAlojamientosActivos();

            //if (dGV_Alojamientos.CurrentRow != null)
            //{
            //    VentanaEmergente ventanaEmergente = new VentanaEmergente("Reserva de Alojamiento Exitosa", TipoMensaje.ReservaExitosa
            //            , Convert.ToInt32(dGV_Alojamientos.Rows[1].Cells[0].Value));
            //    ventanaEmergente.ShowDialog();

            //    VentanaEmergente ventanaEmergente2 = new VentanaEmergente("Nuevo Alojamiento registrado con Éxito", TipoMensaje.AltaAlojamientoExitosa
            //        , Convert.ToInt32(dGV_Alojamientos.Rows[1].Cells[0].Value));
            //    ventanaEmergente2.ShowDialog(); 
            //}

            //VentanaEmergente ventanaEmergente3 = new VentanaEmergente("Éxito en la Cancelación", TipoMensaje.Exito);
            //ventanaEmergente3.ShowDialog();

            //VentanaEmergente ventanaEmergente4 = new VentanaEmergente("Atención: El Cliente responsable elegido no es Titular, ...", TipoMensaje.Alerta);
            //ventanaEmergente4.ShowDialog();

            AlojsReservadosSinDeposito();
            timer1.Interval = 7200000;// dos horas
            timer1.Enabled = true;
        }

        private void AlojsReservadosSinDeposito()
        {
            List<Alojamiento> ListAloj = iControladorAlojamiento.AlojReservadosSinDepositoVencidos();
            if (ListAloj.Count > 0)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Los Alojamiento Reservados a continuación no presentan Pago de Depósito dentro de las 72hs", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
                ListarAlojamientos listarAlojamientos = new ListarAlojamientos(ListAloj);
                listarAlojamientos.ShowDialog();
            }
        }
        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NuevoCliente NuevoCliente = new NuevoCliente();
            NuevoCliente.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarCliente = new BuscarCliente();
            BuscarCliente.ShowDialog();

        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarAlojamiento BuscarAlojamiento = new BuscarAlojamiento();
            BuscarAlojamiento.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cerrar ventana Principal y dejar ventana de inicio sesion.
        }

        private void agregarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarServicio VentanaServicio = new AgregarServicio();
            VentanaServicio.ShowDialog();
        }

        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RegistrarPago VentanaResgitrarPago = new RegistrarPago();
            VentanaResgitrarPago.ShowDialog();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            TablaDisponibilidad TDisp = new TablaDisponibilidad(dtp_fechaDesde.Value, dtp_fechaHasta.Value);
            TDisp.ShowDialog();
        }

        private void serviciosConsumidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarServiciosConsumidos VentanaListarServConsumidos = new ListarServiciosConsumidos();
            VentanaListarServConsumidos.ShowDialog();
        }

        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CerrarAlojamiento VentanaCerrarALojamiento = new CerrarAlojamiento();
            VentanaCerrarALojamiento.ShowDialog();
        }

        private void altaDeReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAlojamientoSinReserva AltaReservaAlojamiento = new AltaAlojamientoSinReserva();
            AltaReservaAlojamiento.Show();

            BuscarAlojamiento BuscarAlojamiento = new BuscarAlojamiento();
            BuscarAlojamiento.ShowDialog();
            try
            {
                if (BuscarAlojamiento.Aloj_Seleccionado == null)
                {
                    throw new NullReferenceException("Debe seleccionar un Alojamiento. Vuelva a intentarlo.");
                }

                iControladorAlojamiento.ControlInicioAltaReserva(BuscarAlojamiento.Aloj_Seleccionado);

                AltaReservaAlojamiento.NuevoAlojamiento = BuscarAlojamiento.Aloj_Seleccionado;

                AltaReservaAlojamiento.RellenarCampos();

                AltaReservaAlojamiento.EnableAll(false);

                //AltaReservaAlojamiento.ShowDialog();
            }
            catch (NullReferenceException E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
                AltaReservaAlojamiento.Close();
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
                VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(BuscarAlojamiento.Aloj_Seleccionado);
                VentanaVisualizar.ShowDialog();
                AltaReservaAlojamiento.Close();
            }
        }

        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            iPadre.Close();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarServicios VentanaServicios = new AdministrarServicios();
            VentanaServicios.ShowDialog();
        }

        private void CargarAlojamientosActivos()
        {
            dGV_Alojamientos.Rows.Clear();
            foreach (var aloj in iControladorAlojamiento.ObtenerAlojamientosActivos())
            {
                var cli = aloj.Clientes.Find(c => c.ClienteId == aloj.DniResponsable);
                dGV_Alojamientos.Rows.Add
                    (
                    aloj.AlojamientoId,
                    aloj.EstadoAlojamiento,
                    aloj.HabitacionId,
                    aloj.DniResponsable,
                    cli.Legajo,
                    cli.NombreCompleto(),
                    (aloj.EstadoAlojamiento==EstadoAlojamiento.Alojado ? aloj.FechaIngreso:aloj.FechaEstimadaIngreso).ToString("dd / MM / yyyy"),
                    aloj.FechaEstimadaEgreso.ToString("dd / MM / yyyy"),
                    aloj.CantCuposSimples + (aloj.CantCuposDobles * 2)
                    );
            }
        }

        private void btn_VerDetalle_Click(object sender, EventArgs e)
        {
            if (dGV_Alojamientos.CurrentRow != null)
            {
                VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(iControladorAlojamiento.BuscarAlojamientoPorID(Convert.ToInt32(dGV_Alojamientos.CurrentRow.Cells[0].Value)));
                VentanaVisualizar.ShowDialog(); 
            }
        }

        private void modificarAltaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarAltaCliente ModAltaCliente = new ModificarAltaCliente();
            ModAltaCliente.ShowDialog();
        }

        private void consultarHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarHabitaciones consultarHabitaciones = new ConsultarHabitaciones();
            consultarHabitaciones.ShowDialog();
        }

        private void tarifasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarTarifas consultarTarifas = new ConsultarTarifas();
            consultarTarifas.ShowDialog();
        }

        private void actualizarTarifasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarTarifas actualizarTarifas = new ActualizarTarifas();
            actualizarTarifas.ShowDialog();
        }

        private void actualizarTarifaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarCostoServicio actualizarCostoServicio = new ActualizarCostoServicio();
            actualizarCostoServicio.ShowDialog();
        }

        private void modificarAltaDeCuposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarCupoHabitacion modificarCupoHabitacion = new ModificarCupoHabitacion();
            modificarCupoHabitacion.ShowDialog();
        }

        //ACTUALIZAR
        private void button1_Click(object sender, EventArgs e)
        {
            CargarAlojamientosActivos();
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarCliente ventanaBusqueda = new BuscarCliente();
            ventanaBusqueda.ShowDialog();
            if (ventanaBusqueda.ClienteSeleccionado != null)
            {
                NuevoCliente ventanaCliente = new NuevoCliente(ventanaBusqueda.ClienteSeleccionado);
                ventanaCliente.ShowDialog(); 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            AlojsReservadosSinDeposito();
            timer1.Enabled = true;
        }

        private void cancelarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelarAlojamiento cancelarAlojamiento = new CancelarAlojamiento();
            cancelarAlojamiento.ShowDialog();
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarCliente = new BuscarCliente();
            BuscarCliente.ShowDialog();
        }

        private void actualizarCostoServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarCostoServicio actualizarCostoServicio = new ActualizarCostoServicio();
            actualizarCostoServicio.ShowDialog();
        }
    }
}
