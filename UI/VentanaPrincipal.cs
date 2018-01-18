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
        List<Alojamiento> listaActivos;
        public VentanaPrincipal()
        {
            InitializeComponent();
            CargarAlojamientosActivos();
            dtp_fechaHasta.Value = DateTime.Now.AddDays(1);

            //realizarlo como proceso en segundo plano al inicio y cada cierto tiempo
            List<Alojamiento> ListAloj = iControladorAlojamiento.AlojReservadosSinDepositoVencidos();
            if (ListAloj.Count > 0)
            {
                //ES UN AVISO - NO SE CANCELAN AUTOMATICAMENTE
                //GENERAR UI PARA ESTOS ALOJs
                //PERMITIR CERRAR UN ALOJ O REALIZAR PAGO EN LA MISMA UI
            }
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
            // TODO: esta línea de código carga datos en la tabla 'hotel_BDDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            //this.clienteTableAdapter.Fill(this.hotel_BDDataSet.Cliente);
            
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

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                if (BuscarAlojamiento.iAloj_Seleccionado == null)
                {
                    throw new NullReferenceException("Debe seleccionar un Alojamiento. Vuelva a intentarlo.");
                }

                iControladorAlojamiento.ControlInicioAltaReserva(BuscarAlojamiento.iAloj_Seleccionado);

                AltaReservaAlojamiento.NuevoAlojamiento = BuscarAlojamiento.iAloj_Seleccionado;

                AltaReservaAlojamiento.EnableAll(false);

                AltaReservaAlojamiento.RellenarCampos();
            }
            catch (NullReferenceException E)
            {
                MessageBox.Show(E.Message);
                AltaReservaAlojamiento.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(BuscarAlojamiento.iAloj_Seleccionado);
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
            listaActivos = iControladorAlojamiento.ObtenerAlojamientosActivos();
            foreach (var aloj in listaActivos)
            {
                var cli = aloj.Clientes.Find(c => c.ClienteId == aloj.DniResponsable);
                dGV_Alojamientos.Rows.Add(aloj.AlojamientoId,aloj.EstadoAlojamiento, aloj.HabitacionId, aloj.DniResponsable, cli.Legajo, cli.NombreCompleto(), (aloj.EstadoAlojamiento==EstadoAlojamiento.Alojado ? aloj.FechaIngreso:aloj.FechaEstimadaIngreso).ToString("dd / MM / yyyy"), aloj.FechaEstimadaEgreso.ToString("dd / MM / yyyy"), aloj.CantCuposSimples + (aloj.CantCuposDobles * 2));
            }

        }

        private void btn_VerDetalle_Click(object sender, EventArgs e)
        {
            VisualizarAlojamiento VentanaVisualizar = new VisualizarAlojamiento(listaActivos.Find(a => a.AlojamientoId == Convert.ToInt32(dGV_Alojamientos.CurrentRow.Cells[0].Value)));
            VentanaVisualizar.ShowDialog();
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
    }
}
