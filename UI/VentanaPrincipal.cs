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
            ReInicioSesion ReinicioSesion = new ReInicioSesion();
            ReinicioSesion.ShowDialog();
            if (ReinicioSesion.Validacion == true)
            {
                archivoToolStripMenuItem.Enabled = true;
                alojamientoToolStripMenuItem.Enabled = true;
                clienteToolStripMenuItem.Enabled = true;
                listarToolStripMenuItem.Enabled = true;
                movimientoToolStripMenuItem.Enabled = true;
                administracionToolStripMenuItem.Enabled = true;
                groupBox_disponibilidad.Enabled = true;
                cerrarToolStripMenuItem.Enabled = true;

                iniciarToolStripMenuItem.Enabled = false;
            }

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoToolStripMenuItem.Enabled = false;
            alojamientoToolStripMenuItem.Enabled = false;
            clienteToolStripMenuItem.Enabled = false;
            listarToolStripMenuItem.Enabled = false;
            movimientoToolStripMenuItem.Enabled = false;
            administracionToolStripMenuItem.Enabled = false;
            groupBox_disponibilidad.Enabled = false;
            cerrarToolStripMenuItem.Enabled = false;

            iniciarToolStripMenuItem.Enabled = true;
        }
        // LOADDDDDDDDDDDDDDDDDDDDD------------------------------------------------------
        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            iniciarToolStripMenuItem.Enabled = false;

            dtp_fechaHasta.Value = DateTime.Now.AddDays(1);

            //tarea a fondo
            CargarAlojamientosActivos();

            //ALOJS TRAS 72HS SIN DEPOSITO
            //tarea a fondo
            //AlojsReservadosSinDeposito();
            timer1.Interval = 7200000;// dos horas
            timer1.Enabled = true;
        }

        private void CargarAlojamientosActivos()
        {
            dGV_Alojamientos.Rows.Clear();
            List<Alojamiento> ListAloj = new ControladorAlojamiento().ObtenerAlojamientosActivos();

            int countRow = 0;

            foreach (Alojamiento aloj in ListAloj)
            {
                Cliente cli = aloj.Clientes.Find(c => c.ClienteId == aloj.DniResponsable);
                dGV_Alojamientos.Rows.Add
                    (
                    aloj.AlojamientoId,
                    aloj.EstadoAlojamiento,
                    aloj.HabitacionId,
                    aloj.DniResponsable,
                    cli.Legajo,
                    cli.NombreCompleto(),
                    (aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado ? aloj.FechaIngreso : aloj.FechaEstimadaIngreso).ToString("dd / MM / yyyy"),
                    aloj.FechaEstimadaEgreso.ToString("dd / MM / yyyy"),
                    aloj.CantCuposSimples + (aloj.CantCuposDobles * 2)
                    );

                if (aloj.MontoTotal > 0)
                {
                    dGV_Alojamientos.Rows[countRow].DefaultCellStyle.BackColor = Color.AliceBlue;
                }
                countRow++;
            }
        }
        private void AlojsReservadosSinDeposito()
        {
            List<Alojamiento> ListAloj = new ControladorAlojamiento().AlojsReservadosConDepositoVencidos();

            if (ListAloj.Count > 0)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Los Alojamiento Reservados a continuación no presentan Pago de Depósito tras pasar de las 72hs de la Fecha de Reserva", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
                ListarAlojamientos listarAlojamientos = new ListarAlojamientos(ListAloj);
                listarAlojamientos.VisiblePago();
                listarAlojamientos.ShowDialog();
            }
        }

        //RESERVAS QUE SE DEBEN REALIZAR EL ALTA
        private void AlojamietosParaDarDeAlta()
        {
            List<Alojamiento> auxLista = new ControladorExtra().AlojamientosACancelar();
            if (auxLista.Count > 0)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Los siguientes Alojamientos deben dase de Alta Hoy.", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
                ListarAlojamientos listarAlojamientos = new ListarAlojamientos(auxLista);
                listarAlojamientos.ShowDialog();
                ventanaEmergente = new VentanaEmergente("Recuerde Dar de Alta las Reservas en las Fechas de Ingreso correspondientes para evitar confusiones en las operaciones.", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        //ALOJS QUE DEBEN CERRARSE HOY
        private void AlojamietosParaCerrar()
        {
            List<Alojamiento> auxLista = new ControladorExtra().AlojamientosACerrar();
            if (auxLista.Count > 0)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Los siguientes Alojamientos deben Cerrarse Hoy.", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
                ListarAlojamientos listarAlojamientos = new ListarAlojamientos(auxLista);
                listarAlojamientos.ShowDialog();
                ventanaEmergente = new VentanaEmergente("Recuerde Cerrar Alojamientos en las Fechas de Egreso correspondientes para evitar confusion en las operaciones.", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
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

                new ControladorAlojamiento().ControlInicioAltaReserva(BuscarAlojamiento.Aloj_Seleccionado);

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

        private void btn_VerDetalle_Click(object sender, EventArgs e)
        {
            if (dGV_Alojamientos.CurrentRow != null)
            {
                VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(new ControladorAlojamiento().BuscarAlojamientoPorID(Convert.ToInt32(dGV_Alojamientos.CurrentRow.Cells[0].Value)));
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

        private void actualizarCostoServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarCostoServicio actualizarCostoServicio = new ActualizarCostoServicio();
            actualizarCostoServicio.ShowDialog();
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarCliente = new BuscarCliente();
            BuscarCliente.ShowDialog();
        }

        private void alojamientosConDeudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Alojamiento> ListAloj = new ControladorAlojamiento().AlojamientosConDeuda();

            if (ListAloj.Count > 0)
            {
                ListarAlojamientos listarAlojamientos = new ListarAlojamientos(ListAloj);
                listarAlojamientos.VisiblePago();
                listarAlojamientos.ShowDialog();
            }
        }
    }
}
