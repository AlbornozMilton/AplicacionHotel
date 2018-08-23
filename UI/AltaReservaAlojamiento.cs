﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;

namespace UI
{
    public partial class AltaReservaAlojamiento : Form
    {
        public List<Habitacion> HabSeleccionadas;
        private int cantExclAux = 0;

        public DateTime FechaIni;
        public DateTime FechaFin;
        public Cliente ClienteResponsable;
        private Alojamiento NuevoAlojamiento;
        private List<AlojHab> AlojHabs = new List<AlojHab>();
        private bool exclusividadCapacidad;

        public AltaReservaAlojamiento()
        {
            InitializeComponent();
            txb_fechaActual.Text = DateTime.Now.ToString("dd/MM/yy");
            dtp_fechaDesde.Value = DateTime.Now;
            dtp_fechaHasta.Value = DateTime.Now.AddDays(1);
        }

        private void AltaReservaAlojamiento_Load(object sender, EventArgs e)
        {
            FechaIni = DateTime.Now;
            FechaFin = DateTime.Now.AddDays(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_VerificarDisponibilidad_Click(object sender, EventArgs e)
        {
            //llenar alojhabs
            if (FechaIni.Date.CompareTo(FechaFin.Date) == -1)
            {
                TablaDisponibilidad TablaDisp = new TablaDisponibilidad(FechaIni, FechaFin, true);
                TablaDisp.ShowDialog();

                if (TablaDisp.HabSeleccionadas.Count != 0)
                {
                    this.HabSeleccionadas = TablaDisp.HabSeleccionadas;

                    this.exclusividadCapacidad = new ControladorAlojamiento().ExclusividadSegunCapacidad(FechaIni, FechaFin, 0);

                    AlojHabs.Clear();
                    dGV_Habs.Rows.Clear();
                    dGV_excl.Rows.Clear();
                    cantExclAux = 0;

                    foreach (Habitacion hab in this.HabSeleccionadas)
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
                    button2.Enabled = true;
                }
                else if (HabSeleccionadas.Count == 0)
                {
                    VentanaEmergente ventanaEmergente = new VentanaEmergente("Debe seleccionar al menos una Habitación para continuar", TipoMensaje.Alerta);
                    ventanaEmergente.ShowDialog();
                }
            }
            else
            {
                VentanaEmergente ventanaEmergente = new VentanaEmergente("La Fecha de Egreso debe ser Mayor a la Fecha de Ingreso", TipoMensaje.Alerta);
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
                if (BuscarClienteForm.ClienteSeleccionado != null)
                {
                    if (BuscarClienteForm.ClienteSeleccionado.TarifaCliente.TarifaClienteId == TipoCliente.AcompanianteDirecto
                        ||
                        BuscarClienteForm.ClienteSeleccionado.TarifaCliente.TarifaClienteId == TipoCliente.AcompanianteNoDirecto)
                    {
                        throw new Exception("El Cliente Responsable solo puede ser Titular, Titular Exceptuado o Convenio");
                    }

                    //Excepción cliente activo
                    new ControladorCliente().ControlClienteActivo(BuscarClienteForm.ClienteSeleccionado, FechaIni, FechaFin, new ControladorAlojamiento().ObtenerAlojamientosActivos());

                    //<-------------AVISO DE CLIENTE DEUDOR --------------------------

                    this.ClienteResponsable = BuscarClienteForm.ClienteSeleccionado;
                    dGV_ClienteResponsable.Rows.Clear();
                    dGV_ClienteResponsable.Rows.Add(ClienteResponsable.ClienteId, ClienteResponsable.Legajo, ClienteResponsable.Apellido, ClienteResponsable.Nombre, ClienteResponsable.TarifaCliente.NombreTarifa);

                    //btn_Confirmar.Enabled = true;
                }
                else if (ClienteResponsable == null)
                    throw new Exception("Debe seleccionar un Cliente Responsable para continuar");
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
                if (ClienteResponsable != null) //requisito
                {
                    bool result = true;
                    bool responsable = false;
                    int cantNull = 0;

                    for (int i = 0; i < dGV_Habs.Rows.Count; i++)
                    {
                        var valorCell = (DataGridViewComboBoxCell)dGV_Habs.Rows[i].Cells[2];

                        if (valorCell != null && (string)valorCell.Value == ClienteResponsable.TarifaCliente.NombreTarifa)
                            responsable = true;
                        else if (valorCell == null)
                            cantNull++;
                    }

                    if (!responsable)
                        throw new Exception("Debe incluir un Responsable Titular");

                    int capTotal = 0;
                    foreach (var hab in HabSeleccionadas)
                    {
                        capTotal += hab.Capacidad;
                    }

                    if (cantNull != capTotal)
                    {
                        VentanaEmergente ventanaEmergente = new VentanaEmergente("Hay habitaciones con espacio disponible", TipoMensaje.SiNo);
                        ventanaEmergente.ShowDialog();
                        result = ventanaEmergente.Aceptar;
                    }

                    if (result && responsable)
                    {
                        new ControladorHabitacion().GenerarTarifas(AlojHabs);

                        this.NuevoAlojamiento = new Alojamiento(AlojHabs, ClienteResponsable.ClienteId, FechaIni, FechaFin, button1.Text == "ES TOUR" ? true : false);

                        this.NuevoAlojamiento.CalcularCostoBase();

                        txb_CostoBase.Text = NuevoAlojamiento.MontoTotal.ToString();

                        int porcDeposito = new ControladorExtra().ObtenerValorMetada(TipoMetadaHotel.PorcentajeDeposito);
                        txb_Deposito.Text = NuevoAlojamiento.Deposito(porcDeposito).ToString();

                        groupBox4.Enabled = false;
                        groupBox2.Enabled = false;
                        groupBox1.Enabled = false;

                        //btn_Confirmar.Image = UI.Properties.Resources.Boton_Ok_Seleccion_3;
                        //btn_Confirmar.Enabled = false;
                        button1.Enabled = false;
                        button2.Enabled = false;

                        btn_Aceptar.Enabled = true;
                    }
                }
                else if (ClienteResponsable == null)
                    throw new Exception("Debe elegir un Cliente como Responsable");
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

        private void ck_Exclusividad_CheckedChanged(object sender, EventArgs e)
        {
            //if (ClienteResponsable != null && ClienteResponsable.TarifaCliente.TarifaClienteId == TipoCliente.TitularExceptuado)
            //{
            //	if (ck_Exclusividad.Checked == false)
            //	{
            //		VentanaEmergente ventanaEmergente = new VentanaEmergente("No se permite Exclusividad para Cliente Exceptuado", TipoMensaje.Alerta);
            //		ventanaEmergente.ShowDialog();
            //	}
            //	ck_Exclusividad.Checked = false;

            //	groupBox3.Enabled = true;
            //}
            //else if (ck_Exclusividad.Checked == true)
            //{
            //	groupBox3.Enabled = false;
            //	contador_Titular.Value = 0;
            //	contador_Convenio.Value = 0;
            //	contador_Directo.Value = 0;
            //	contador_NoDirecto.Value = 0;
            //	contador_Exceptuado.Value = 0;
            //}
            //else if (ck_Exclusividad.Checked == false)
            //{
            //	groupBox3.Enabled = true;
            //}
            //this.HabSeleccionada.SetExclusividad(this.ck_Exclusividad.Checked);
        }

        #region Ingreso de Fechas en Calendario
        //Cuando se lanze estos dos eventos, obligar a que realice una verificacion de disponibilidad o algo similar
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

            //btn_Confirmar.Enabled = false;
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
                Habitacion auxHab = this.HabSeleccionadas.Find(h => h.HabitacionId == (byte)row.Cells[0].Value);

                if ((string)row.Cells[1].Value == "No")
                {
                    //int cant = auxHab.Capacidad;
                    cantExclAux += auxHab.Capacidad;

                    this.exclusividadCapacidad = new ControladorAlojamiento().ExclusividadSegunCapacidad(FechaIni, FechaFin, cantExclAux);

                    if (this.exclusividadCapacidad)
                    {
                        row.Cells[1].Value = "Si";

                        AlojHabs.Find(h => h.Habitacion.HabitacionId == auxHab.HabitacionId).Exclusividad = exclusividadCapacidad;
                    }
                    else
                    {
                        cantExclAux -= auxHab.Capacidad;

                        VentanaEmergente ventanaEmergente = new VentanaEmergente("Se supera la cantidad de exclusividad", TipoMensaje.Alerta);
                        ventanaEmergente.ShowDialog();
                    }
                }
                else
                {
                    row.Cells[1].Value = "No";
                    AlojHabs.Find(h => h.Habitacion.HabitacionId == auxHab.HabitacionId).Exclusividad = false;

                    cantExclAux = this.HabSeleccionadas.Find(h => h.HabitacionId == (byte)row.Cells[0].Value).Capacidad;
                }
            }
        }

        private void dGV_Habs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && e.RowIndex >= 0)
            {
                var row = dGV_Habs.Rows[e.RowIndex];

                var ah = AlojHabs.Find(h => h.Habitacion.HabitacionId == (byte)row.Cells[0].Value);

                ah.AgregarTarifa(e.RowIndex, (string)row.Cells[2].Value);
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
    }
}
