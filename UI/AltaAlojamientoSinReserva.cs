using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class AltaAlojamientoSinReserva : Form
    {
        public DateTime FechaIni;
        public DateTime FechaFin;
        public Cliente ClienteResponsable;
        public Alojamiento NuevoAlojamiento;
        public List<Cliente> Acompañantes = new List<Cliente>();

        List<AlojHab> AlojHabs = new List<AlojHab>();
        List<Alojamiento> iAlojsActivos = new ControladorAlojamiento().ObtenerAlojamientosActivos();
        bool exclusividadCapacidad;
        int cantExclAux = 0;


        public AltaAlojamientoSinReserva()
        {
            InitializeComponent();
        }

        private void AltaAlojamientoSinReserva_Load(object sender, EventArgs e)
        {
            //DateTime.Today.ToString("dd/MM/yy");
            dtpicker_fechaAloj.Value = DateTime.Today;
            dt_hora.Value = dtpicker_fechaAloj.Value;
            dtp_fechaDesde.Value = DateTime.Now;
            FechaIni = DateTime.Now;
            dtp_fechaHasta.Value = DateTime.Now.AddDays(1);
            FechaFin = DateTime.Now.AddDays(1);  // si es reserva, se rellenan campos

            dGV_excl.AlternatingRowsDefaultCellStyle = null;
        }

        private void btn_VerificarDisponibilidad_Click(object sender, EventArgs e)
        {
            if (FechaIni.Date.CompareTo(FechaFin.Date) == -1)
            {
                TablaDisponibilidad TablaDisp = new TablaDisponibilidad(FechaIni, FechaFin, true);
                TablaDisp.ShowDialog();

                if (TablaDisp.HabSeleccionadas.Count != 0)
                {
                    //this.HabSeleccionadas = TablaDisp.HabSeleccionadas;
                    ;

                    exclusividadCapacidad = new ControladorAlojamiento().ExclusividadSegunCapacidad(FechaIni, FechaFin, 0);

                    AlojHabs.Clear();
                    dGV_Habitaciones.Rows.Clear();
                    dGV_excl.Rows.Clear();
                    cantExclAux = 0;

                    foreach (Habitacion hab in TablaDisp.HabSeleccionadas)
                    {
                        AlojHabs.Add(new AlojHab(hab));

                        for (int i = 0; i < hab.Capacidad; i++)
                        {
                            dGV_Habitaciones.Rows.Add("Agregar", hab.HabitacionId);
                        }

                        dGV_excl.Rows.Add(hab.HabitacionId, "No");
                    }

                    //limpiar Responsable y Acompañantes
                    dGV_ClienteResponsable.Rows.Clear();
                    ClienteResponsable = null;

                    //this.Acompañantes.Clear(); 
                    foreach (AlojHab alojHab in AlojHabs)
                    {
                        alojHab.Clientes.Clear();
                    }

                    btn_AgregarCliente.Enabled = true; //seleccionar responsable

                    //btn_Comprobar.Enabled = false; //por si vulve a seleccionar "Determianar"
                }
                else if (TablaDisp.HabSeleccionadas == null)
                {
                    VentanaEmergente ventanaEmergente = new VentanaEmergente("Debe seleccionar al menos una Habitación para continuar", TipoMensaje.Alerta);
                    ventanaEmergente.ShowDialog();
                }
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("La fecha de egreso debe ser mayor a la fecha de ingreso", TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        //RESPONSABLE
        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente BuscarClienteForm = new BuscarCliente();
            BuscarClienteForm.setEnableAltas(false);
            BuscarClienteForm.ShowDialog();
            try
            {
                if (BuscarClienteForm.ClienteSeleccionado == null)
                    throw new Exception("Debe seleccionar un Responsable para continuar");

                if (BuscarClienteForm.ClienteSeleccionado.TarifaCliente.TarifaClienteId == TipoCliente.AcompanianteDirecto
                        ||
                        BuscarClienteForm.ClienteSeleccionado.TarifaCliente.TarifaClienteId == TipoCliente.AcompanianteNoDirecto)
                {
                    throw new Exception("El Responsable solo puede ser Titular, Titular Exceptuado o Convenio");
                }

                //Excepción cliente activo
                new ControladorCliente().ControlClienteActivo(BuscarClienteForm.ClienteSeleccionado, FechaIni, FechaFin, new ControladorAlojamiento().ObtenerAlojamientosActivos());

                //<-------------AVISO DE CLIENTE DEUDOR --------------------------

                dGV_ClienteResponsable.Rows.Clear();
                this.ClienteResponsable = BuscarClienteForm.ClienteSeleccionado;
                dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Legajo, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.TarifaCliente.NombreTarifa);
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

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int auxIdAloj;
                if (NuevoAlojamiento == null) //Alta sin Reserva
                {
                    auxIdAloj = new ControladorAlojamiento().RegistrarAloj(this.NuevoAlojamiento);
                }
                else
                {//Alta de reserva
                    new ControladorAlojamiento().RegistrarAltaReserva(this.NuevoAlojamiento);
                    auxIdAloj = NuevoAlojamiento.AlojamientoId;
                }
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Alojamiento Registrado con Éxito", TipoMensaje.AltaAlojamientoExitosa, auxIdAloj);
                ventanaEmergente.ShowDialog();
                Close();
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        //Esta deshabilitado
        private void dtp_fechaDesde_ValueChanged(object sender, EventArgs e)
        {
            this.FechaIni = dtp_fechaDesde.Value;
        }

        private void dtp_fechaHasta_ValueChanged(object sender, EventArgs e)
        {
            this.FechaFin = dtp_fechaHasta.Value;
            //txb_NroHabitacion.Text = "";
            //txb_capacidad.Text = "";
            //ck_Exclusividad.Checked = false;
            dGV_ClienteResponsable.Rows.Clear();
            dGV_Habitaciones.Rows.Clear();
            ClienteResponsable = null;
            Acompañantes.Clear();
            //groupBox4.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
            //btn_Comprobar.Enabled = false;
        }

        /// <summary>
        /// Modifica el campo Enable de una conjunto de propiedades de la Form al valor de parámetro
        /// </summary>
        public void EnableAll(bool pValorEnable)//true
        {

        }

        #region Alta de Reserva
        public void RellenarCampos()
        {

            //importanteeee----------------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            //foreach (Habitacion hab in this.HabSeleccionadas)
            //{
            //    AlojHabs.Add(new AlojHab(hab));

            //    for (int i = 0; i < hab.Capacidad; i++)
            //    {
            //        dGV_Habitaciones.Rows.Add("Agregar", hab.HabitacionId);
            //    }

            //    dGV_excl.Rows.Add(hab.HabitacionId, "No");
            //}

            //generar los check
            //check de su tarifa correspondiente para tal habitacion
            //<<<<<<<<<<<<<<<<<<----------------------------------------

            txb_IdAloj.Text = NuevoAlojamiento.AlojamientoId.ToString();
            dtp_fechaDesde.Value = NuevoAlojamiento.FechaEstimadaIngreso;
            dtp_fechaHasta.Value = NuevoAlojamiento.FechaEstimadaEgreso;
            //ck_Exclusividad.CheckState = NuevoAlojamiento.Exclusividad == true ? CheckState.Checked:CheckState.Unchecked;

            //cliente responsable
            dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Legajo, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.TarifaCliente.NombreTarifa);
            this.Acompañantes = new List<Cliente>();
            this.Acompañantes.Add(ClienteResponsable);
            //btn_Confirmar.Enabled = true;

            //HabSeleccionada.SetExclusividad(NuevoAlojamiento.Exclusividad);

            //para almacenar el valor de costo base de reserva y luego comparar
            //txb_CostoBase.Text = NuevoAlojamiento.MontoTotal.ToString();

            ////--------Por la reserva------------------------
            //if (!btn_VerificarDisponibilidad.Enabled)
            //{
            //    auxListaCliReserva = NuevoAlojamiento.Clientes;
            //}
            ////-------------------------------------
            groupBox1.Enabled = false; //disponibilidad
            groupBox3.Enabled = true; // Acompañantes
            button_visualizarReserva.Visible = true;
        }
        #endregion

        private void button_visualizarReserva_Click(object sender, EventArgs e)
        {
            VisualizarAlojamiento visualizarAlojamiento = new VisualizarAlojamiento(NuevoAlojamiento);
            visualizarAlojamiento.ShowDialog();
        }

        private void btn_Comprobar_Click_1(object sender, EventArgs e)
        {
            try
            {
                VentanaEmergente ventanaEmergenteAtendio;
                if (tbx_atendio.Text == null || tbx_atendio.Text == "")
                {
                    ventanaEmergenteAtendio = new VentanaEmergente("El campo 'Atendió' esta vacío", TipoMensaje.SiNo);
                    ventanaEmergenteAtendio.ShowDialog();

                    if (!ventanaEmergenteAtendio.Aceptar)
                        return;
                }

                if (dGV_Habitaciones.Rows.Count == 0)
                    throw new Exception("Debe seleccionar al menos una Habitación");

                if (ClienteResponsable == null)
                    throw new Exception("Debe 'Seleccionar Responsable'");

                List<string> tiposCli = new List<string>() { "Titular", "Convenio", "Titular Exceptuado" };
                if (!tiposCli.Contains(ClienteResponsable.TarifaCliente.NombreTarifa))
                    throw new Exception("Debe incluir algún Titular como Responsable");

                //COMPROBAR QUE EL RESPONSABLE ESTE SELECCIONADO
                bool responsable = false;
                foreach (AlojHab alojHab in AlojHabs)
                {
                    foreach (Cliente cli in alojHab.Clientes)
                    {
                        if (cli.ClienteId == ClienteResponsable.ClienteId)
                        {
                            responsable = true;
                            break;
                        }
                    }
                }
                if (!responsable)
                    throw new Exception("El Responsable elegido debe estar en algunas de las Habitaciones'");

                int capTotal = 0;

                foreach (var hab in AlojHabs)
                {
                    capTotal += hab.Habitacion.Capacidad;
                }

                int cantTour = new ControladorExtra().ObtenerValorMetada(TipoMetadaHotel.CantPersonaTour);
                if (button1.Text == "ES TOUR" && capTotal < cantTour)
                    throw new Exception("La cantidad mínima para Tour debe ser de " + cantTour.ToString());

                //Reglas segun tipo de responsables y clientes
                foreach (DataGridViewRow row in dGV_Habitaciones.Rows)
                {
                    if (row.Cells[4].Value != null)
                    {
                        if ((ClienteResponsable.TarifaCliente.TarifaClienteId == TipoCliente.Convenio && (string)row.Cells[4].Value != "Convenio")
                                            ||
                                        (ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.Convenio) && (string)row.Cells[4].Value == "Convenio")
                            throw new Exception("No debe haber Titulares por Convenio mezclados con otros Tipos de Titulares"); 
                    }
                }

                //PARA LA EXCL DE LA HAB SE DEBE RELLANAR LA CANTIDAD TOTAL DE ESA HAB PARA EVITAR EXCEPCIÓN "ESPACIO DISPONIBLE"
                int cantNull = 0;
                foreach (DataGridViewRow rowExcl in dGV_excl.Rows)
                {
                    if ((string)rowExcl.Cells[1].Value == "No")
                    {
                        foreach (DataGridViewRow rowHabs in dGV_Habitaciones.Rows)
                        {
                            if ((byte)rowExcl.Cells[0].Value == (byte)rowHabs.Cells[1].Value && rowHabs.Cells[3].Value == null)
                            {
                                cantNull++;
                            }
                        }
                    }
                }

                VentanaEmergente ventanaEmergenteHabDisp;
                if (cantNull != 0 && ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.Convenio)
                {
                    ventanaEmergenteHabDisp = new VentanaEmergente("Hay habitaciones con espacio disponible", TipoMensaje.SiNo);
                    ventanaEmergenteHabDisp.ShowDialog();
                    if (!ventanaEmergenteHabDisp.Aceptar)
                        return;
                }

                /////////////---------------------------------------->>>>>>>>>>>>>>>>>>>>>
                DateTime lfechaAloj = new DateTime(dtpicker_fechaAloj.Value.Year, dtpicker_fechaAloj.Value.Month, dtpicker_fechaAloj.Value.Day, dt_hora.Value.Hour, dt_hora.Value.Minute, 0);
                if (!btn_VerificarDisponibilidad.Enabled) //se trata de alta de reserva
                {
                    //COMPROBAR QUE TODOS LOS CHECK ESTEN EN TRUE
                    foreach (AlojHab ah in AlojHabs)
                    {
                        if (!ah.ControlTarifasCliente())
                            throw new Exception("Los Clientes cargados deben coincidir con los cargados en la Reserva");
                    }

                    this.NuevoAlojamiento.AltaDeReserva(AlojHabs, lfechaAloj, dtp_fechaDesde.Value);

                    this.NuevoAlojamiento.CalcularCostoBase();

                    if (this.NuevoAlojamiento.MontoTotal.ToString() != txb_MontoAloj.Text)
                        throw new Exception("Error en el cálculo de Monto de Alojamiento");
                }
                else
                {
                    this.NuevoAlojamiento = new Alojamiento(AlojHabs, ClienteResponsable, lfechaAloj, FechaIni, FechaFin, button1.Text == "ES TOUR" ? true : false, tbx_atendio.Text);

                    NuevoAlojamiento.CalcularCostoBase();
                }

                txb_MontoAloj.Text = NuevoAlojamiento.MontoTotal.ToString();
                txb_Deposito.Text = NuevoAlojamiento.MontoDepositado().ToString();

                groupBox1.Enabled = false; // grid de fechas
                groupBox2.Enabled = false; // grid de responsable
                btn_AgregarCliente.Enabled = false;
                groupBox3.Enabled = false; // grid de habitaciones
                dt_hora.Enabled = false;
                dtpicker_fechaAloj.Enabled = false;
                btn_Comprobar.Enabled = false;

                btn_Aceptar.Enabled = true;
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private void dGV_Habitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    var rowSelected = dGV_Habitaciones.Rows[e.RowIndex];
                    var ahAux = AlojHabs.Find(h => h.Habitacion.HabitacionId == (byte)rowSelected.Cells[/*Hab*/1].Value);

                    if ((string)rowSelected.Cells[0].Value == "Agregar")
                    {
                        BuscarCliente BuscarClienteForm = new BuscarCliente();
                        BuscarClienteForm.setEnableAltas(false);
                        BuscarClienteForm.ShowDialog();

                        if (BuscarClienteForm.ClienteSeleccionado != null)
                        {
                            Cliente CliAux = BuscarClienteForm.ClienteSeleccionado;

                            foreach (AlojHab ah in AlojHabs)
                            {
                                foreach (Cliente cli in ah.Clientes)
                                {
                                    if (CliAux.ClienteId == cli.ClienteId)
                                    {
                                        throw new Exception("El cliente elegido ya se encuentra seleccionado");
                                    }
                                }

                            }

                            //Cliente Activo
                            new ControladorCliente().ControlClienteActivo(BuscarClienteForm.ClienteSeleccionado, FechaIni, FechaFin, new ControladorAlojamiento().ObtenerAlojamientosActivos());

                            rowSelected.Cells[2].Value = CliAux.Apellido + " " + CliAux.Nombre;
                            rowSelected.Cells[3].Value = CliAux.ClienteId;
                            rowSelected.Cells[4].Value = CliAux.TarifaCliente.NombreTarifa;
                            if (CliAux.Domicilio.Ciudad != null)
                                rowSelected.Cells[5].Value = CliAux.Domicilio.Ciudad.Nombre + " - " + CliAux.Domicilio.Direccion();
                            else
                                rowSelected.Cells[5].Value = CliAux.Domicilio.Direccion();

                            //CHEQUEAR EL CAMBIO DE EXCL SEGUN EL TIPO DE CLIENTE
                            EvaluarExcl1(rowSelected, ahAux);

                            //si es reserva, la lista de tarifas ya viene cargada, sino no es necesario el futuro control
                            ahAux.Clientes.Add(BuscarClienteForm.ClienteSeleccionado);
                            rowSelected.Cells[0].Value = "Quitar";
                        }
                    }
                    else // QUITAR
                    {
                        ahAux.Clientes.Remove(ahAux.Clientes.Find(c => c.ClienteId == (int)rowSelected.Cells[3].Value));

                        rowSelected.Cells[2].Value = null;
                        rowSelected.Cells[3].Value = null;
                        rowSelected.Cells[4].Value = null;
                        rowSelected.Cells[5].Value = null;

                        //CHEQUEAR EL CAMBIO DE EXCL SEGUN EL TIPO DE CLIENTE
                        EvaluarExcl1(rowSelected, ahAux);

                        rowSelected.Cells[0].Value = "Agregar";
                    }
                }
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private void EvaluarExcl1(DataGridViewRow rowSelected, AlojHab ahAux)
        {
            List<string> tiposCli = new List<string>() { "Titular", "Convenio", "Titular Exceptuado" };
            bool responsable = false;
            int cantParaExcl = 0;
            foreach (DataGridViewRow dgvRow in dGV_Habitaciones.Rows)
            {
                if ((byte)dgvRow.Cells[1].Value == (byte)rowSelected.Cells[1].Value)
                {
                    //solo excl para una persona
                    if (dgvRow.Cells[3].Value != null)
                        cantParaExcl++;

                    if (tiposCli.Contains((string)dgvRow.Cells[4].Value))
                        responsable = true;
                }
            }

            if (cantParaExcl != 1 || cantParaExcl == 1 && !responsable)
            {
                foreach (DataGridViewRow rowExcl in dGV_excl.Rows)
                {
                    if ((byte)rowExcl.Cells[0].Value == ahAux.Habitacion.HabitacionId && (string)rowExcl.Cells[1].Value == "Si")
                    {
                        ahAux.Exclusividad = false;

                        cantExclAux -= ahAux.Habitacion.Capacidad;

                        rowExcl.Cells[1].Value = "No";
                    }
                }
            }
        }

        private void dGV_excl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var row = dGV_excl.Rows[e.RowIndex];
                AlojHab ah = AlojHabs.Find(h => h.Habitacion.HabitacionId == (byte)row.Cells[0].Value);

                if ((string)row.Cells[1].Value == "No")
                {
                    //solo estos en pueden pedir excplusividad para su hab
                    List<string> tiposCli = new List<string>() { "Titular", "Convenio", "Titular Exceptuado" };
                    int cantParaExcl = 0;
                    bool responsable = false;
                    foreach (DataGridViewRow rowHab in dGV_Habitaciones.Rows)
                    {
                        if ((byte)rowHab.Cells[1].Value == (byte)row.Cells[0].Value)
                        {
                            //solo excl para una persona
                            if (rowHab.Cells[3].Value != null)
                                cantParaExcl++;
                            if (tiposCli.Contains((string)rowHab.Cells[4].Value))
                                responsable = true;
                        }
                    }

                    if (responsable && cantParaExcl == 1)
                    {
                        cantExclAux += ah.Habitacion.Capacidad;

                        this.exclusividadCapacidad = new ControladorAlojamiento().ExclusividadSegunCapacidad(FechaIni, FechaFin, cantExclAux);

                        if (this.exclusividadCapacidad)
                        {
                            ah.Exclusividad = exclusividadCapacidad;

                            row.Cells[1].Value = "Si";
                        }
                        else
                        {
                            cantExclAux -= ah.Habitacion.Capacidad;

                            VentanaEmergente ventanaEmergente = new VentanaEmergente("Se supera la cantidad de exclusividad", TipoMensaje.Alerta);
                            ventanaEmergente.ShowDialog();
                        }
                    }
                    else
                    {
                        //cantExclAux -= ah.Habitacion.Capacidad;

                        VentanaEmergente ventanaEmergente = new VentanaEmergente("Para exclusividad de la Habitación SOLAMENTE debe poseer un Titular, Titular Exceptuado o Convenio", TipoMensaje.Alerta);
                        ventanaEmergente.ShowDialog();
                    }
                }
                else //Si
                {
                    ah.Exclusividad = false;

                    cantExclAux -= ah.Habitacion.Capacidad;

                    row.Cells[1].Value = "No";
                }
            }
        }
    }
}
