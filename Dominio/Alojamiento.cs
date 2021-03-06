﻿using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Alojamiento
    {
        private int iIdAlojamiento;
        private int iDniResponsable;
        private bool iEsTour;
        private string iAtendio;
        private DateTime iFechaAloj;
        private DateTime iFechaReserva = new DateTime();
        private DateTime iFechaEstimadaEgreso = new DateTime();
        private DateTime iFechaEstimadaIngreso = new DateTime();
        private DateTime iFechaIngreso = new DateTime();
        private DateTime iFechaEgreso = new DateTime();
        private DateTime iFechaCancelacion = new DateTime();
        private double iMontoTotal;
        private double iMontoDeuda;
        private EstadoAlojamiento iEstadoAloj;

        private List<LineaServicio> iServicios = new List<LineaServicio>();
        private List<AlojHab> iAlojHabs = new List<AlojHab>();
        private List<Pago> iPagos = new List<Pago>();

        //-----------------------CONSTRUCTORES----------------------

        public Alojamiento() { }

        /// <summary>
        /// Constructor para el Alta Alojamiento sin Reserva
        /// </summary>
        public Alojamiento(List<AlojHab> pAlojHabes, Cliente unClienteResp, DateTime pFechaAloj, DateTime unaFechaIngreso, DateTime unaFechaEstimadaEgreso, bool pEsTour, string pAtendio)
        {
            this.iEstadoAloj = EstadoAlojamiento.Alojado;
            this.iDniResponsable = unClienteResp.ClienteId;
            this.iAlojHabs = pAlojHabes;
            this.iFechaIngreso = unaFechaIngreso;
            this.iFechaAloj = pFechaAloj;
            this.iFechaEstimadaEgreso =
                new DateTime(
                        unaFechaEstimadaEgreso.Year,
                        unaFechaEstimadaEgreso.Month,
                        unaFechaEstimadaEgreso.Day,
                        11, 00, 00);
            this.iEsTour = pEsTour;
            this.iAtendio = pAtendio;
        }

        /// <summary>
        /// Contructor para la Reserva de Alojamiento
        /// </summary>
        public Alojamiento(List<AlojHab> pAlojHabes, int unClienteResp, DateTime pFechaAloj, DateTime unaFechaEstimadaIngreso, DateTime unaFechaEstimadaEgreso, bool pEsTour, string pAtendio)
        {
            this.iEstadoAloj = EstadoAlojamiento.Reservado;
            this.iFechaReserva = DateTime.Now;
            this.iDniResponsable = unClienteResp;

            this.iAlojHabs = pAlojHabes;
            this.iFechaAloj = pFechaAloj;
            this.iFechaEstimadaIngreso =
                new DateTime(
                        unaFechaEstimadaIngreso.Year,
                        unaFechaEstimadaIngreso.Month,
                        unaFechaEstimadaIngreso.Day,
                        10, 00, 00);
            this.iFechaEstimadaEgreso =
                new DateTime(
                        unaFechaEstimadaEgreso.Year,
                        unaFechaEstimadaEgreso.Month,
                        unaFechaEstimadaEgreso.Day,
                        11, 00, 00);
            this.iEsTour = pEsTour;
            this.iAtendio = pAtendio;
        }

        //----------------------PROP----------------------
        public int AlojamientoId
        {
            get { return this.iIdAlojamiento; }
            private set { this.iIdAlojamiento = value; }
        }
        public int DniResponsable
        {
            get { return this.iDniResponsable; }
            private set { this.iDniResponsable = value; }
        }
        public string Atendio { get { return this.iAtendio; } private set { this.iAtendio = value; } }

        public bool EsTour
        {
            get { return this.iEsTour; }
            private set { this.iEsTour = value; }
        }
        public DateTime FechaAloj
        {
            get { return this.iFechaAloj; }
            private set { this.iFechaAloj = value; }
        }
        public DateTime FechaReserva
        {
            get { return this.iFechaReserva; }
            private set { this.iFechaReserva = value; }
        }
        public DateTime FechaEstimadaIngreso
        {
            get { return this.iFechaEstimadaIngreso; }
            private set { this.iFechaEstimadaIngreso = value; }
        }
        public DateTime FechaEstimadaEgreso
        {
            get { return this.iFechaEstimadaEgreso; }
            private set { this.iFechaEstimadaEgreso = value; }
        }
        public DateTime FechaIngreso
        {
            get { return this.iFechaIngreso; }
            private set { this.iFechaIngreso = value; }
        }
        public DateTime FechaEgreso
        {
            get { return this.iFechaEgreso; }
            private set { this.iFechaEgreso = value; }
        }
        public DateTime FechaCancelacion
        {
            get { return this.iFechaCancelacion; }
            private set { this.iFechaCancelacion = value; }
        }
        public double MontoTotal
        {
            get { return this.iMontoTotal; }
            private set { this.iMontoTotal = value; }
        }
        public double MontoDeuda
        {
            get { return this.iMontoDeuda; }
            private set { this.iMontoDeuda = value; }
        }
        public EstadoAlojamiento EstadoAlojamiento
        {
            get { return this.iEstadoAloj; }
            private set { this.iEstadoAloj = value; }
        }
        public List<AlojHab> AlojHabes
        {
            get { return this.iAlojHabs; }
            private set { this.iAlojHabs = value; }
        }
        public List<LineaServicio> Servicios
        {
            get { return this.iServicios; }
            private set { this.iServicios = value; }
        }
        public List<Pago> Pagos
        {
            get { return this.iPagos; }
            private set { this.iPagos = value; }
        }

        //----------------------METHODS----------------------

        public double Deposito(int pPorcentajeDepo)
        {
            return this.iMontoTotal * pPorcentajeDepo * 0.01;
        }

        public double MontoDepositado()
        {
            foreach (Pago p in this.Pagos)
            {
                if (p.Tipo == TipoPago.Deposito)
                {
                    return p.Monto;
                }
            }

            return 0;
        }

        /// <summary>
        /// Cambio de Estado a "Alojado"
        /// </summary>
        public void AltaDeReserva(List<AlojHab> pAH, DateTime pFechaAloj, DateTime pFechaIngreso)
        {
            this.EstadoAlojamiento = EstadoAlojamiento.Alojado;
            this.iAlojHabs = pAH;
            this.iFechaAloj = pFechaAloj;
            this.FechaIngreso = pFechaIngreso;
        }

        public bool ExistePagoAlojamiento(Pago pPago)
        {
            return this.iPagos.Contains(pPago);
        }

        public void CalcularCostoBase()
        {
            TarifaCliente tarifa = new ControladorCliente().BuscarClientePorDni(iDniResponsable, true).TarifaCliente;
            DateTime auxFechaDesde = new DateTime();
            double costoBase = 0;

            // LA EXCLUSIVIDAD SE ACUMULA SEGUN CADA HABITACION
            if (this.iEstadoAloj == EstadoAlojamiento.Alojado)
            {
                auxFechaDesde = this.iFechaIngreso;

                foreach (AlojHab mAloHab in this.AlojHabes)
                {
                    if (tarifa.TarifaClienteId != TipoCliente.Convenio)
                    {
                        foreach (AHCliente cli in mAloHab.Clientes)
                        {
                            costoBase += cli.Cliente.ObtenerSuPrecioTarifa(mAloHab.Exclusividad);
                        }
                    }
                    else if (mAloHab.Exclusividad)
                        costoBase += tarifa.TarifaExclusiva;
                    else
                        costoBase += tarifa.Tarifa;
                }
            }
            else // RESERVADO
            {
                auxFechaDesde = this.iFechaEstimadaIngreso;

                foreach (AlojHab mAloHab in this.AlojHabes)
                {
                    if (tarifa.TarifaClienteId != TipoCliente.Convenio)
                    {
                        foreach (AHTarifa tarifaLocal in mAloHab.Tarifas)
                        {
                            costoBase += tarifaLocal.TarifaCliente.GetTarifa(mAloHab.Exclusividad);
                        }
                    }
                    else if (mAloHab.Exclusividad)
                        costoBase += tarifa.TarifaExclusiva;
                    else
                        costoBase += tarifa.Tarifa;
                }
            }

            this.iMontoTotal = costoBase * (Math.Abs(this.iFechaEstimadaEgreso.Date.Subtract(auxFechaDesde.Date).Days));

            if (this.iEsTour)
                this.iMontoTotal -= this.iMontoTotal * new ControladorExtra().ObtenerValorMetada(TipoMetadaHotel.PorcentajeTour) * 0.01;

            this.iMontoDeuda = this.iMontoTotal;

            foreach (Pago pago in this.Pagos)
            {
                iMontoDeuda -= pago.Monto;
            }
        }

        public void RegistrarPago(Pago pPago)
        {
            this.iMontoDeuda -= pPago.Monto;
            this.iPagos.Add(pPago);
        }

        public double TotalServicios()
        {
            double total = 0;
            foreach (var item in this.iServicios)
            {
                total += item.CostoServicio; // total = total + item.CostoServicio;
            }
            return total;
        }

        /// <summary>
        /// Agrega una linea servicio y actualiza sus montos
        /// </summary>
        public void AgregarLineaServicio(LineaServicio pLineaServicio)
        {
            if (iServicios.Count == 0)
            {
                iServicios = new List<LineaServicio>() { pLineaServicio };
            }
            else
            {
                iServicios.Add(pLineaServicio);
            }

            iMontoTotal += pLineaServicio.CostoServicio;
            iMontoDeuda += pLineaServicio.CostoServicio;
        }

        /// <summary>
        /// Asinga la fecha parámetro como Fecha de Egreso y cambia el Estado Alojamiento a Cerrado
        /// </summary>
        public void Cerrar()
        {
            this.iFechaEgreso = DateTime.Now;
            this.iEstadoAloj = EstadoAlojamiento.Cerrado;
        }
        /// <summary>
        /// Registra fecha de cancelacion y cambia el Estado del Alojamiento a Cancelado
        /// </summary>
        public void Cancelar()
        {
            this.iFechaCancelacion = DateTime.Now;
            this.iEstadoAloj = EstadoAlojamiento.Cancelado;
        }

        public Cliente ClienteResponsable()
        {
            Cliente cliResponsable = null;
            foreach (AlojHab alojHab in this.AlojHabes)
            {
                foreach (AHCliente cli in alojHab.Clientes)
                {
                    if (cli.Cliente.ClienteId == this.iDniResponsable)
                    {
                        cliResponsable = cli.Cliente;
                        break;
                    }
                }
                break;
            }
            return cliResponsable;
        }
    }
}