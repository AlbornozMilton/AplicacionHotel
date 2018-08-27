﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class AltaAlojamientoSinReserva : Form
    {
        //public List<Habitacion> HabSeleccionadas;
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
            //dt_hora.Value = DateTime.Today.add(dtpicker_fechaAloj.Value.Hour, dtpicker_fechaAloj.Value.Minute);
            dGV_excl.AlternatingRowsDefaultCellStyle = null;
            dtp_fechaDesde.Value = DateTime.Now;
            FechaIni = DateTime.Now;
            dtp_fechaHasta.Value = DateTime.Now.AddDays(1);
            FechaFin = DateTime.Now.AddDays(1);  // si es reserva, se rellenan campos
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
                if (BuscarClienteForm.ClienteSeleccionado != null)
                {
                    //Excepción cliente activo
                    new ControladorCliente().ControlClienteActivo(BuscarClienteForm.ClienteSeleccionado, FechaIni, FechaFin, new ControladorAlojamiento().ObtenerAlojamientosActivos());

                    //AVISO DE CLIENTE DEUDOR

                    dGV_ClienteResponsable.Rows.Clear();
                    this.ClienteResponsable = BuscarClienteForm.ClienteSeleccionado;

                    switch (ClienteResponsable.TarifaCliente.TarifaClienteId)
                    {
                        case TipoCliente.Titular:
                            {
                                //ck_Exclusividad.Enabled = exclusividadCapacidad;
                            }
                            break;
                        case TipoCliente.AcompanianteDirecto:
                            {
                                VentanaEmergente ventanaEmergente = new VentanaEmergente("El Cliente Responsable que eligió no es Titular, queda a su criterio continuar con la carga", TipoMensaje.Alerta);
                                ventanaEmergente.ShowDialog();
                                //ck_Exclusividad.Enabled = exclusividadCapacidad;
                            }
                            break;
                        case TipoCliente.AcompanianteNoDirecto:
                            {
                                VentanaEmergente ventanaEmergente = new VentanaEmergente("El Cliente Responsable que eligió no es Titular, queda a su criterio continuar con la carga", TipoMensaje.Alerta);
                                ventanaEmergente.ShowDialog();
                                //ck_Exclusividad.Enabled = exclusividadCapacidad;
                            }
                            break;
                        case TipoCliente.TitularExceptuado:
                            {
                                //ck_Exclusividad.Checked = false;
                                //ck_Exclusividad.Enabled = exclusividadCapacidad;
                            }
                            break;
                        case TipoCliente.Convenio:
                            {
                                //ck_Exclusividad.Enabled = exclusividadCapacidad;
                            }
                            break;
                    }

                    dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Legajo, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.TarifaCliente.NombreTarifa);

                    groupBox3.Enabled = true; //ACOMPAÑANTES
                                              //btn_Comprobar.Enabled = true;
                    dGV_Habitaciones.Rows.Clear();
                    Acompañantes.Clear();
                    Acompañantes.Add(ClienteResponsable);
                }
                else
                if (ClienteResponsable == null)
                {
                    throw new Exception("Debe seleccionar un Cliente para continuar");
                }
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
                if (dGV_Habitaciones.Rows.Count == 0)
                    throw new Exception("Debe seleccionar al menos una Habitación");

                //COMPROBAR QUE EL RESPONSABLE ESTE SELECCIONADO

                //comprbar que todos los check esten en true

                if (!btn_VerificarDisponibilidad.Enabled) //se trata de alta de reserva
                {
                    this.NuevoAlojamiento.SetClientes(this.Acompañantes);
                    //new ControladorCliente().ControlCapacidadConClientes(this.NuevoAlojamiento.Clientes, HabSeleccionada);
                    //new ControladorAlojamiento().ComprobarClientesAltaConReserva(this.NuevoAlojamiento, txb_CostoBase.Text);
                    //NuevoAlojamiento.Habitacion.OcuparHabitacion();
                }
                else
                {
                    if (Acompañantes.Count == 1 && ClienteResponsable.TarifaCliente.TarifaClienteId == TipoCliente.TitularExceptuado)
                    {
                        throw new Exception("Un Titular Exceptuado debe estar Acompañado");
                    }

                    //new ControladorCliente().ControlCapacidadConClientes(Acompañantes, HabSeleccionada);
                    //HabSeleccionada.OcuparHabitacion();
                    //this.NuevoAlojamiento = new Alojamiento(HabSeleccionada, ClienteResponsable, Acompañantes, FechaIni, FechaFin, HabSeleccionada.Exclusiva);
                    //NuevoAlojamiento.CalcularCostoBase(new List<TarifaCliente>());
                }
                //txb_CostoBase.Text = NuevoAlojamiento.MontoTotal.ToString();
                //btn_Comprobar.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
                //groupBox4.Enabled = false;
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
                    //Habitacion auxHab = this.HabSeleccionadas.Find(h => h.HabitacionId == (byte)rowSelected.Cells[1].Value);

                    BuscarCliente BuscarClienteForm = new BuscarCliente();
                    BuscarClienteForm.setEnableAltas(false);
                    BuscarClienteForm.ShowDialog();

                    if (BuscarClienteForm.ClienteSeleccionado != null)
                    {
                        var ahAux = AlojHabs.Find(h => h.Habitacion.HabitacionId == (byte)rowSelected.Cells["Hab"/*1*/].Value);

                        if ((string)rowSelected.Cells[0].Value == "Agregar")
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

                            string nombreTarifa = (string)rowSelected.Cells["Tipo Cliente"/*4*/].Value;

                            //var ahAux = AlojHabs.Find(h => h.Habitacion.HabitacionId == (byte)rowSelected.Cells["Hab"/*1*/].Value);
                            ahAux.AgregarTarifaRow(e.RowIndex, nombreTarifa);

                            //check de su tarifa correspondiente para tal habitacion
                            ahAux.CheckinTarifaCliente(nombreTarifa);

                            //CHEQUEAR EL CAMBIO DE EXCL SEGUN EL TIPO DE CLIENTE
                            List<string> tiposCli = new List<string>() { "Titular", "Convenio", "Titular Exceptuado" };
                            if (!tiposCli.Contains(nombreTarifa))
                            {
                                foreach (DataGridViewRow rowExcl in dGV_excl.Rows)
                                {
                                    if ((byte)rowExcl.Cells["Nro"/*0*/].Value == ahAux.Habitacion.HabitacionId && (string)rowExcl.Cells["Excl"/*1*/].Value == "Si")
                                    {
                                        //AlojHabs.Find(h => h.Habitacion.HabitacionId == auxHab.HabitacionId).Exclusividad = false;
                                        ahAux.Exclusividad = false;

                                        cantExclAux -= ahAux.Habitacion.Capacidad;

                                        rowExcl.Cells["Excl"/*1*/].Value = "No";
                                    }
                                }
                            }

                            rowSelected.Cells[2].Value = CliAux.Apellido + " " + CliAux.Nombre;
                            rowSelected.Cells[3].Value = CliAux.ClienteId;
                            rowSelected.Cells[4].Value = CliAux.TarifaCliente.NombreTarifa;
                            if (CliAux.Domicilio.Ciudad != null)
                                rowSelected.Cells[5].Value = CliAux.Domicilio.Ciudad.Nombre + " - " + CliAux.Domicilio.Direccion();
                            else
                                rowSelected.Cells[5].Value = CliAux.Domicilio.Direccion();

                            ahAux.Clientes.Add(BuscarClienteForm.ClienteSeleccionado);
                        }
                        else // QUITAR
                        {
                            rowSelected.Cells[2].Value = "";
                            rowSelected.Cells[3].Value = "";
                            rowSelected.Cells[4].Value = "";
                            rowSelected.Cells[5].Value = "";

                            ahAux.Clientes.Remove(BuscarClienteForm.ClienteSeleccionado);

                            //Acomodar exclusividad
                            int auxCapacidad = 0;
                            foreach (DataGridViewRow dgvRow in dGV_Habitaciones.Rows)
                            {
                                if ((byte)dgvRow.Cells["Hab"].Value == ahAux.Habitacion.HabitacionId
                                    &&
                                    (string)dgvRow.Cells["DNI"].Value != ""
                                    )
                                {
                                    auxCapacidad++;
                                }
                            }
                            if (auxCapacidad == 0)
                            {
                                foreach (DataGridViewRow rowExcl in dGV_excl.Rows)
                                {
                                    if ((byte)rowExcl.Cells["Nro"/*0*/].Value == ahAux.Habitacion.HabitacionId && (string)rowExcl.Cells["Excl"/*1*/].Value == "Si")
                                    {
                                        //AlojHabs.Find(h => h.Habitacion.HabitacionId == auxHab.HabitacionId).Exclusividad = false;
                                        ahAux.Exclusividad = false;

                                        cantExclAux -= ahAux.Habitacion.Capacidad;

                                        rowExcl.Cells["Excl"/*1*/].Value = "No";
                                    }
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception E)
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente(E.Message, TipoMensaje.Alerta);
                ventanaEmergente.ShowDialog();
            }
        }

        private void dGV_excl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var row = dGV_excl.Rows[e.RowIndex];
                //Habitacion auxHab = this.HabSeleccionadas.Find(h => h.HabitacionId == (byte)row.Cells[0].Value);
                AlojHab ah = AlojHabs.Find(h => h.Habitacion.HabitacionId == (byte)row.Cells["Nro"].Value);

                if ((string)row.Cells[1].Value == "No")
                {
                    bool Excl = false;

                    //solo estos en pueden pedir excplusividad para su hab
                    List<string> tiposCli = new List<string>() { "Titular", "Convenio", "Titular Exceptuado" };
                    int cantParaExcl = 0;
                    foreach (DataGridViewRow item in dGV_Habitaciones.Rows)
                    {
                        if ((byte)item.Cells[1].Value == (byte)row.Cells[1].Value && tiposCli.Contains((string)item.Cells[4].Value))
                        {
                        Excl = true;
                            cantParaExcl++; //solo excl para una persona
                        }
                    }

                    if (Excl && cantParaExcl == 0)
                    {
                        cantExclAux += ah.Habitacion.Capacidad;

                        this.exclusividadCapacidad = new ControladorAlojamiento().ExclusividadSegunCapacidad(FechaIni, FechaFin, cantExclAux);

                        if (this.exclusividadCapacidad)
                        {
                            row.Cells[1].Value = "Si";

                            ah.Exclusividad = exclusividadCapacidad;
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
                        cantExclAux -= ah.Habitacion.Capacidad;

                        VentanaEmergente ventanaEmergente = new VentanaEmergente("Para exclusividad de la habitación debe poseer un Titular, Titular Exceptuado o Convenio solamente", TipoMensaje.Alerta);
                        ventanaEmergente.ShowDialog();
                    }
                }
                else
                {
                    ah.Exclusividad = false;

                    cantExclAux -= ah.Habitacion.Capacidad;

                    row.Cells[1].Value = "No";
                }
            }
        }
    }
}
