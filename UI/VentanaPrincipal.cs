using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class VentanaPrincipal : Form
    {
        public InicioSesion iPadre;
        private List<Alojamiento> ListaAlojamientos;
        private BackgroundWorker SegundoPlano = new BackgroundWorker();

        public VentanaPrincipal()
        {
            InitializeComponent();
			//dGV_Alojamientos.DefaultCellStyle.BackColor = Color.White;
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
            CorrerTodoSegundoPlano();
        }


        #region SegundoPlano

        async private void CorrerTodoSegundoPlano()
        {
            dGV_Alojamientos.Rows.Clear();
            pictureBox1.Visible = true;
            this.ListaAlojamientos = await CargarAlojsActivos();
            MostrarAlojsActivos();
            this.ListaAlojamientos = CargarAlojsSinDeposito();
            MostrarAlojsSinDeposito();
            timer1.Interval = 7200000;// dos horas para nueva notificacion 
            timer1.Enabled = true;
            this.ListaAlojamientos = CargarAlojsADarDeAlta();
            MostrarAlojsADarDeAlta();
            this.ListaAlojamientos = CargarAlojsACerrar();
            MostrarAlojsACerrar();
        }

        async private void SegundoPlanoCargarActivos()
        {
            dGV_Alojamientos.Rows.Clear();
            pictureBox1.Visible = true;
            this.ListaAlojamientos = await CargarAlojsActivos();
            MostrarAlojsActivos();
        }

        private Task<List<Alojamiento>> CargarAlojsActivos()
        {
            return Task.Run(() => (new ControladorAlojamiento().ObtenerAlojamientosActivos()));
        }

        private void MostrarAlojsActivos()
        {
			ControladorExtra controladorExtra = new ControladorExtra();
            pictureBox1.Visible = false;
            int countRow = 0;
			foreach (Alojamiento aloj in this.ListaAlojamientos)
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
					aloj.FechaEstimadaEgreso.ToString("dd / MM / yyyy")
					);
				dGV_Alojamientos.Rows[countRow].Cells[8].Style.BackColor = Color.FromName(controladorExtra.DeterminarColor(aloj));
				dGV_Alojamientos.Rows[countRow].Cells[8].Style.SelectionBackColor = Color.Transparent;
				countRow++;
            }
        }

        private List<Alojamiento> CargarAlojsSinDeposito()
        {
           return new ControladorAlojamiento().AlojsReservadosConDepositoVencidos();
        }

        private void MostrarAlojsSinDeposito()
        {
            if (this.ListaAlojamientos.Count > 0)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Alojamientos Reservados no presentan Pago de Depósito", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
                ListarAlojamientos listarAlojamientos = new ListarAlojamientos(this.ListaAlojamientos);
                listarAlojamientos.VisiblePago();
                listarAlojamientos.ShowDialog();
            }
        }

        private List<Alojamiento> CargarAlojsADarDeAlta()
        {
            return new ControladorExtra().AlojamientosACancelar();
        }

        private void MostrarAlojsADarDeAlta()
        {
            if (this.ListaAlojamientos.Count > 0)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Los siguientes Alojamientos deben dase de Alta Hoy", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
                ListarAlojamientos listarAlojamientos = new ListarAlojamientos(this.ListaAlojamientos);
                listarAlojamientos.ShowDialog();
                ventanaEmergente = new VentanaEmergente("Recuerde Dar de Alta las Reservas en las Fechas de Ingreso correspondientes", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private List<Alojamiento> CargarAlojsACerrar()
        {
            return new ControladorExtra().AlojamientosACerrar();
        }

        private void MostrarAlojsACerrar()
        {
            if (this.ListaAlojamientos.Count > 0)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Los siguientes Alojamientos deben Cerrarse Hoy.", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
                ListarAlojamientos listarAlojamientos = new ListarAlojamientos(this.ListaAlojamientos);
                listarAlojamientos.ShowDialog();
                ventanaEmergente = new VentanaEmergente("Recuerde Cerrar Alojamientos en las Fechas de Egreso correspondientes.", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }
        
        //Temporizador para 72hs sin deposito
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.ListaAlojamientos = CargarAlojsSinDeposito();
            MostrarAlojsSinDeposito();
            timer1.Enabled = true;
        }
        #endregion

        //ACTUALIZAR
        private void button1_Click(object sender, EventArgs e)
        {
            SegundoPlanoCargarActivos();
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
			BuscarAlojamiento.SetVisibleSeleccionar(false);
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
            if (dtp_fechaDesde.Value.CompareTo(dtp_fechaHasta.Value) == -1)
            {
                TablaDisponibilidad TDisp = new TablaDisponibilidad(dtp_fechaDesde.Value, dtp_fechaHasta.Value,false);
                TDisp.ShowDialog();
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Fechas Incorrectas: fecha 'Hasta' debe ser mayor a la fecha 'Desde'", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
            
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
			BuscarCliente.SetVisibleSeleccionar(false);
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
			else
			{
				VentanaEmergente ventanaEmergente = new VentanaEmergente("No Existen Alojamientos con Servicios Impagos", TipoMensaje.Exito);
				ventanaEmergente.ShowDialog();
			}
        }

        private void listaPersonalizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarAlojamientos listarAlojamientos = new ListarAlojamientos();
			listarAlojamientos.SetVisibleSeleccionar(false);
			listarAlojamientos.ShowDialog();
        }

		private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarCiudad agregarCiudad = new AgregarCiudad(1);
			agregarCiudad.ShowDialog();
		}

		private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarCiudad agregarCiudad = new AgregarCiudad(2);
			agregarCiudad.ShowDialog();
		}

		private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarCiudad agregarCiudad = new AgregarCiudad(3);
			agregarCiudad.ShowDialog();
		}

		private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UserAdmin userAdmin = new UserAdmin(2);
			userAdmin.ShowDialog();
		}

		private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UserAdmin userAdmin = new UserAdmin(0);
			userAdmin.ShowDialog();
		}

		private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UserAdmin userAdmin = new UserAdmin(1);
			userAdmin.ShowDialog();
		}
	}
}
