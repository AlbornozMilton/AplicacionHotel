using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class AltaReservaAlojamiento : Form
    {
        public DateTime FechaIni;
        public DateTime FechaFin;
        public Cliente ClienteResponsable;

        private int cantExclAux = 0;
        private Alojamiento NuevoAlojamiento;
        private List<AlojHab> AlojHabs = new List<AlojHab>();
        private bool exclusividadCapacidad;

        public AltaReservaAlojamiento()
        {
            InitializeComponent();
            //txb_fechaActual.Text = DateTime.Now.ToString("dd/MM/yy");
            dtp_fechaDesde.Value = DateTime.Now;
            dt_hora.Value = dtp_fechaDesde.Value;
            dtp_fechaHasta.Value = DateTime.Now.AddDays(1);
        }

        private void AltaReservaAlojamiento_Load(object sender, EventArgs e)
        {
            FechaIni = DateTime.Now;
            FechaFin = DateTime.Now.AddDays(1);
            dGV_Habs.AlternatingRowsDefaultCellStyle = null;
            dGV_excl.AlternatingRowsDefaultCellStyle = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
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

                    this.exclusividadCapacidad = new ControladorAlojamiento().ExclusividadSegunCapacidad(FechaIni, FechaFin, 0);

                    AlojHabs.Clear();
                    dGV_Habs.Rows.Clear();
                    dGV_excl.Rows.Clear();
                    cantExclAux = 0;

                    foreach (Habitacion hab in TablaDisp.HabSeleccionadas)
                    {
                        AlojHabs.Add(new AlojHab(hab));

                        for (int i = 0; i < hab.Capacidad; i++)
                        {
                            dGV_Habs.Rows.Add(hab.HabitacionId,
                            hab.Planta == 0 ? "Baja" : "Alta");
                        }
                        dGV_excl.Rows.Add(hab.HabitacionId, "No");
                    }

                    //USAR exclusividadCapacidad para no negar el boton de exclusividad
                    dGV_ClienteResponsable.Rows.Clear();
                    ClienteResponsable = null;
                    groupBox4.Enabled = true; //HABIACION
                    groupBox2.Enabled = true; //RESPONSABLE
                    button2.Enabled = true; //Seleccionar responsable
                }
                else if (TablaDisp.HabSeleccionadas.Count == 0)
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

        //boton agregar responsable
        private void button2_Click(object sender, EventArgs e)
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
                new ControladorCliente().ControlClienteActivo(BuscarClienteForm.ClienteSeleccionado, FechaIni, FechaFin, new ControladorAlojamiento().ObtenerAlojamientosActivos(), -1);

                //<-------------AVISO DE CLIENTE DEUDOR --------------------------

                this.ClienteResponsable = BuscarClienteForm.ClienteSeleccionado;
                dGV_ClienteResponsable.Rows.Clear();
                dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Legajo, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.TarifaCliente.NombreTarifa);

            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        /// <summary>
        /// Realizar control de excepciones 
        /// </summary>
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClienteResponsable == null)
                    throw new Exception("Debe 'Seleccionar Responsable'");

                if (dGV_Habs.Rows.Count == 0)
                    throw new Exception("Debe seleccionar al menos una Habitación");

                bool responsable = false;
                for (int i = 0; i < dGV_Habs.Rows.Count; i++)
                {
                    var valorCell = (DataGridViewComboBoxCell)dGV_Habs.Rows[i].Cells[2];

                    if (valorCell != null && (string)valorCell.Value == ClienteResponsable.TarifaCliente.NombreTarifa)
                        responsable = true;
                    //else if (valorCell.Value == null)
                    //    cantNull++;
                }

                if (!responsable)
                    throw new Exception("Debe incluir algún Titular como Responsable");

                int capTotal = 0;
                foreach (var hab in AlojHabs)
                {
                    capTotal += hab.Habitacion.Capacidad;
                }

                int cantTour = new ControladorExtra().ObtenerValorMetada(TipoMetadaHotel.CantPersonaTour);
                if (button1.Text == "ES TOUR" && capTotal < cantTour)
                    throw new Exception("La cantidad mínima para Tour debe ser de " + cantTour.ToString());

                //preguntar si es requisito excluyente
                //if (button1.Text == "ES TOUR" && cantNull != 0)
                //    throw new Exception("Debe completar el Tour");

                //Reglas segun tipo de responsables y clientes
                foreach (DataGridViewRow row in dGV_Habs.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        if ((ClienteResponsable.TarifaCliente.TarifaClienteId == TipoCliente.Convenio && (string)row.Cells[2].Value != "Convenio")
                                            ||
                                        (ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.Convenio) && (string)row.Cells[2].Value == "Convenio")
                            throw new Exception("No debe haber Titulares por Convenio mezclados con otros Tipos de Titulares");
                    }
                }

                //PARA LA EXCL DE LA HAB SE DEBE RELLANAR LA CANTIDAD TOTAL DE ESA HAB PARA EVITAR EXCEPCIÓN "ESPACIO DISPONIBLE"
                int cantNull = 0;
                foreach (DataGridViewRow rowExcl in dGV_excl.Rows)
                {
                    if ((string)rowExcl.Cells[1].Value == "No")
                    {
                        foreach (DataGridViewRow rowHabs in dGV_Habs.Rows)
                        {
                            if ((byte)rowExcl.Cells[0].Value == (byte)rowHabs.Cells[0].Value && rowHabs.Cells[2].Value == null)
                            {
                                cantNull++;
                            }
                        }
                    }
                }

                VentanaEmergente ventanaEmergenteAtendio;
                if (tbx_atendio.Text == null || tbx_atendio.Text == "")
                {
                    ventanaEmergenteAtendio = new VentanaEmergente("El campo 'Atendió' esta vacío", TipoMensaje.SiNo);
                    ventanaEmergenteAtendio.ShowDialog();

                    if (!ventanaEmergenteAtendio.Aceptar)
                        return;
                }

                //solo el Titular Convenio esta registrado, no se registra su familia, entonces solo con la la exclusividad sabemos si va o no con la familia
                //el costo base para responsable convenio se calcula en base a la excl no a la cant de convenios (su familia)
                VentanaEmergente ventanaEmergenteHabDisp;
                if (cantNull != 0 && ClienteResponsable.TarifaCliente.TarifaClienteId != TipoCliente.Convenio)
                {
                    ventanaEmergenteHabDisp = new VentanaEmergente("Hay habitaciones con espacio disponible", TipoMensaje.SiNo);
                    ventanaEmergenteHabDisp.ShowDialog();
                    if (!ventanaEmergenteHabDisp.Aceptar)
                        return;
                }

                if (responsable)
                {
                    new ControladorHabitacion().GenerarTarifas(AlojHabs);

                    DateTime lfechaAloj = new DateTime(dtpicker_fechaAloj.Value.Year, dtpicker_fechaAloj.Value.Month, dtpicker_fechaAloj.Value.Day, dt_hora.Value.Hour, dt_hora.Value.Minute, 0);
                    this.NuevoAlojamiento = new Alojamiento(AlojHabs, ClienteResponsable.ClienteId, lfechaAloj, FechaIni, FechaFin, button1.Text == "ES TOUR" ? true : false, tbx_atendio.Text);

                    this.NuevoAlojamiento.CalcularCostoBase();

                    txb_CostoBase.Text = NuevoAlojamiento.MontoTotal.ToString();

                    int porcDeposito = new ControladorExtra().ObtenerValorMetada(TipoMetadaHotel.PorcentajeDeposito);
                    txb_Deposito.Text = NuevoAlojamiento.Deposito(porcDeposito).ToString();

                    groupBox4.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox_excl.Enabled = false;

                    dt_hora.Enabled = false;
                    dtpicker_fechaAloj.Enabled = false;

                    button1.Enabled = false;
                    button2.Enabled = false;
                    btn_Comprobar.Enabled = false;

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
                int IdAloj = new ControladorAlojamiento().RegistrarAloj(this.NuevoAlojamiento);
                VentanaEmergente ventanaEmergente = new VentanaEmergente("Reserva de Alojamiento Exitosa", TipoMensaje.ReservaExitosa, IdAloj);
                ventanaEmergente.ShowDialog();
                Close();
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        #region Ingreso de Fechas en Calendario
        //Cuando se lanze estos dos eventos, obligar a que realice una verificacion de disponibilidad
        private void dtp_fechaDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                new ControladorAlojamiento().ControlPlazoParaReservar(dtp_fechaDesde.Value.Date);
                this.FechaIni = dtp_fechaDesde.Value;
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
            finally
            {
                Limpiar();
            }
        }

        private void dtp_fechaHasta_ValueChanged(object sender, EventArgs e)
        {
            this.FechaFin = dtp_fechaHasta.Value;
            Limpiar();
        }

        private void Limpiar()
        {
            ClienteResponsable = null;
            dGV_ClienteResponsable.Rows.Clear();

            groupBox4.Enabled = false;
            groupBox2.Enabled = false;
        }
        #endregion

        private void dGV_Habs_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
            e.ThrowException = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "NO ES TOUR")
            {
                button1.Text = "ES TOUR";
                button1.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                button1.Text = "NO ES TOUR";
                button1.BackColor = System.Drawing.Color.OrangeRed;
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
                    List<string> tiposCli = new List<string>() { "Titular", "Convenio", "Titular Exceptuado" };
                    int cantParaExcl = 0;
                    bool responsable = false;
                    foreach (DataGridViewRow rowHab in dGV_Habs.Rows)
                    {
                        if ((byte)rowHab.Cells[0].Value == (byte)row.Cells[0].Value)
                        {
                            //solo excl para una persona
                            if (rowHab.Cells[2].Value != null)
                                cantParaExcl++;

                            if (tiposCli.Contains((string)rowHab.Cells[2].Value))
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
                else // Si
                {
                    //AlojHabs.Find(h => h.Habitacion.HabitacionId == ah.Habitacion.HabitacionId).Exclusividad = false;
                    ah.Exclusividad = false;

                    cantExclAux -= ah.Habitacion.Capacidad;

                    row.Cells[1].Value = "No";
                }
            }
        }

        private void dGV_Habs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //CUANDO CAMBIE DE TIPO DE CLIENTE CHEQUEAR LA EXCLUSIVIDAD SI CAMBIARLA O NO
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && e.RowIndex >= 0)
            {
                var rowSelected = dGV_Habs.Rows[e.RowIndex];
                var ahAux = AlojHabs.Find(h => h.Habitacion.HabitacionId == (byte)rowSelected.Cells[0].Value);

                List<string> tiposCli = new List<string>() { "Titular", "Convenio", "Titular Exceptuado" };
                bool responsable = false;
                int cantParaExcl = 0;
                foreach (DataGridViewRow dgvRow in dGV_Habs.Rows)
                {
                    if ((byte)dgvRow.Cells[0].Value == (byte)rowSelected.Cells[0].Value)
                    {
                        //solo excl para una persona
                        if (dgvRow.Cells[2].Value != null)
                            cantParaExcl++;

                        if (tiposCli.Contains((string)dgvRow.Cells[2].Value))
                            responsable = true;
                    }
                }

                if (cantParaExcl != 1 || cantParaExcl == 1 && !responsable)
                {
                    foreach (DataGridViewRow rowExcl in dGV_excl.Rows)
                    {
                        if ((byte)rowExcl.Cells[0].Value == ahAux.Habitacion.HabitacionId)
                        {
                            ahAux.Exclusividad = false;

                            cantExclAux -= ahAux.Habitacion.Capacidad;

                            rowExcl.Cells[1].Value = "No";
                        }
                    }
                }

                ahAux.AgregarTarifaRow(e.RowIndex, (string)rowSelected.Cells[2].Value);
            }

        }

        private void dGV_Habs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.CurrentCell is DataGridViewComboBoxCell)
            {
                senderGrid.BeginEdit(true);
                ((ComboBox)senderGrid.EditingControl).DroppedDown = true;
            }
        }

        private void btn_EnabledChanged(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Enabled)
            {
                btn.ForeColor = Color.White;
                btn.BackColor = Color.Chocolate;
            }
            else
            {
                btn.ForeColor = Color.DarkGray;
                btn.BackColor = Color.SaddleBrown;
            }
        }

        private void dGV_Habs_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            ((sender as DataGridView).CurrentRow.Cells[2] as DataGridViewComboBoxCell).Value = (sender as DataGridView).CurrentRow.Cells[2].Value;
        }

        private void dGV_Habs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dGV_Habs_CellValueChanged(sender, e);
        }
    }
}
