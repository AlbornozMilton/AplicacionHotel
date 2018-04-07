using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Alojamiento
    {
        private int iIdAlojamiento;
        private int iDniResponsable;
        public bool iEsTour;
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
     
        public Alojamiento() {}

        /// <summary>
        /// Constructor para el Alta Alojamiento sin Reserva
        /// </summary>
        public Alojamiento(List<AlojHab> pAlojHabes, Cliente unClienteResp, DateTime unaFechaIngreso, DateTime unaFechaEstimadaEgreso, bool pEsTour)
        {
            this.iEstadoAloj = EstadoAlojamiento.Alojado;
            this.iDniResponsable = unClienteResp.ClienteId;
			this.iAlojHabs = pAlojHabes;
			this.iFechaIngreso = unaFechaIngreso;
			this.iFechaEstimadaEgreso =
				new DateTime(
						unaFechaEstimadaEgreso.Year,
						unaFechaEstimadaEgreso.Month,
						unaFechaEstimadaEgreso.Day,
						11, 00, 00);
			this.iEsTour = pEsTour;
        }

        /// <summary>
        /// Contructor para la Reserva de Alojamiento
        /// </summary>
        public Alojamiento(List<AlojHab> pAlojHabes, int unClienteResp, DateTime unaFechaEstimadaIngreso, DateTime unaFechaEstimadaEgreso, bool pEsTour)
        {
            this.iEstadoAloj = EstadoAlojamiento.Reservado;
            this.iFechaReserva = DateTime.Now;
            this.iDniResponsable = unClienteResp;

            this.iAlojHabs = pAlojHabes;
            this.iFechaEstimadaIngreso = 
				new DateTime(
						unaFechaEstimadaIngreso.Year,
						unaFechaEstimadaIngreso.Month,
						unaFechaEstimadaIngreso.Day,
						10,00,00);
            this.iFechaEstimadaEgreso = 
				new DateTime(
						unaFechaEstimadaEgreso.Year,
						unaFechaEstimadaEgreso.Month,
						unaFechaEstimadaEgreso.Day,
						11, 00, 00);
			this.iEsTour = pEsTour;
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
		public bool EsTour
		{
			get { return this.iEsTour; }
			private set { this.iEsTour = value; }
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
		/// <summary>
		/// Cambio de Estado a "Alojado" y Set fecha de Ingreso
		/// </summary>
        public void AltaDeReserva()
        {
            this.EstadoAlojamiento = EstadoAlojamiento.Alojado;
            this.FechaIngreso = DateTime.Now;
        }

        public bool ExistePagoAlojamiento(Pago pPago)
        {
            return this.iPagos.Contains(pPago);
        }

		//Tener en cuenta que el Responsable no esta en la lista de contadores
        public void CalcularCostoBase()
        {
			// LA EXCLUSIVIDAD SE ACUMULA SEGUN CADA HABITACION
			double costoBase = 0;
			DateTime auxFechaDesde = new DateTime();
			//Cliente CliResposable = Clientes.Find(c => c.ClienteId == this.DniResponsable);

			if (this.iEstadoAloj == EstadoAlojamiento.Alojado)
			{
				auxFechaDesde = this.iFechaIngreso;

				foreach (AlojHab mAloHab in this.AlojHabes)
				{
					if (mAloHab.Clientes[0].TarifaCliente.TarifaClienteId != TipoCliente.Convenio)
					{
						foreach (Cliente cli in mAloHab.Clientes)
						{
							costoBase += cli.ObtenerSuPrecioTarifa(mAloHab.Exclusividad);
						}
					}
					else
						costoBase += mAloHab.Clientes[0].ObtenerSuPrecioTarifa(mAloHab.Exclusividad);
				}
			}
			else // RESERVADO
			{
				auxFechaDesde = this.iFechaEstimadaIngreso;

				foreach (AlojHab mAloHab in this.AlojHabes)
				{
					if (mAloHab.Tarifas[0].TarifaClienteId != TipoCliente.Convenio)
					{
						foreach (TarifaCliente tarifa in mAloHab.Tarifas)
						{
							costoBase += tarifa.GetTarifa(mAloHab.Exclusividad);
						}
					}
					else
						costoBase += mAloHab.Clientes[0].ObtenerSuPrecioTarifa(mAloHab.Exclusividad);
				}
			}


			this.iMontoTotal = costoBase * (Math.Abs(this.iFechaEstimadaEgreso.Date.Subtract(auxFechaDesde.Date).Days));
			this.iMontoDeuda = this.iMontoTotal;

			foreach (Pago pago in this.Pagos)
			{
				iMontoDeuda =- pago.Monto;
			}

			//Pago auxPago = this.Pagos.Find(p => p.Tipo == TipoPago.Deposito);
			//if (auxPago != null)
			//	this.iMontoDeuda = this.iMontoTotal - auxPago.Monto;
			//else
			//	this.iMontoDeuda = this.iMontoTotal;
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

        public void AgregarCliente(Cliente pCliente)
        {
            //this.iClientes.Add(pCliente);
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

        public void SetClientes(List<Cliente> pClientes)
        {
            //this.iClientes = pClientes;
        }

		public int CantidadAlojados()
		{
			//if (this.EstadoAlojamiento == EstadoAlojamiento.Alojado)
			//{
			//	return Clientes.Count;
			//}
			//else
			//{
			//	int auxCont = 0;
			//	for (int i = 0; i < ContadoresTarifas.Length; i++)
			//	{
			//		auxCont += Convert.ToInt32(ContadoresTarifas[i]);
			//	}
			//	return auxCont + 1;
			//}
			return 0;
		}
    }
}