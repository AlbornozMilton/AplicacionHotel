using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Alojamiento
    {
        private List<LineaServicio> iServicios;
        private List<Cliente> iClientes;
        private Habitacion iHabitacion;
        private List<Pago> iPagos = new List<Pago>();

        private int iIdAlojamiento;
        private int iDniResponsable;
        private double iMontoTotal;
        private double iMontoDeuda;
        public bool iExclusividad;
        private DateTime iFechaReserva = new DateTime();
        private DateTime iFechaEstimadaEgreso = new DateTime();
        private DateTime iFechaEstimadaIngreso = new DateTime();
        private DateTime iFechaIngreso = new DateTime();
        private DateTime iFechaEgreso = new DateTime();
		private DateTime iFechaCancelacion = new DateTime();
        private EstadoAlojamiento iEstadoAloj;
        private string iContadoresTarifas;

        //-----------------------CONSTRUCTORES----------------------
     
        public Alojamiento()
        {

        }

        /// <summary>
        /// Contructor para el Alta Alojamiento sin Reserva
        /// </summary>
        public Alojamiento(Habitacion unaHab, Cliente unClienteResp, List<Cliente> listaAcompañantes, DateTime unaFechaIngreso, DateTime unaFechaEstimadaEgreso, bool HabExclusividad)
        {
            this.iEstadoAloj = EstadoAlojamiento.Alojado;

            this.iClientes = new List<Cliente>();
            this.iDniResponsable = unClienteResp.ClienteId;

            //El cliente responsable ya se encuentra en la lista de acompañantes - Verificar
            foreach (var cli in listaAcompañantes)
            {
                iClientes.Add(cli);
            }

            this.iHabitacion = unaHab;
            this.iFechaIngreso = unaFechaIngreso;
			this.iFechaEstimadaEgreso =
				new DateTime(
						unaFechaEstimadaEgreso.Year,
						unaFechaEstimadaEgreso.Month,
						unaFechaEstimadaEgreso.Day,
						11, 00, 00);
			this.iExclusividad = HabExclusividad;
        }

        /// <summary>
        /// Contructor para la Reserva de Alojamiento
        /// </summary>
        public Alojamiento(string pContTarifas, Habitacion unaHab, Cliente unClienteResp, DateTime unaFechaEstimadaIngreso, DateTime unaFechaEstimadaEgreso, bool HabExclusividad)
        {
            this.iEstadoAloj = EstadoAlojamiento.Reservado;
            this.iFechaReserva = DateTime.Now;

            this.iClientes = new List<Cliente>();
            this.iClientes.Add(unClienteResp);
            this.iDniResponsable = unClienteResp.ClienteId;

            this.iHabitacion = unaHab;
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
			this.iExclusividad = HabExclusividad;
            this.iContadoresTarifas = pContTarifas;
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

        public double Deposito
        {
            get { return this.iMontoDeuda * 0.5; }
        }

        public bool Exclusividad
        {
            get { return this.iExclusividad; }
            private set { this.iExclusividad = value; }
        }

        public EstadoAlojamiento EstadoAlojamiento
        {
            get { return this.iEstadoAloj; }
            private set { this.iEstadoAloj = value; }
        }

        public string ContadoresTarifas
        {
            get { return this.iContadoresTarifas; }
            private set { this.iContadoresTarifas = value; }
        }

        public List<Cliente> Clientes
        {
            get { return this.iClientes; }
            private set { this.iClientes = value; }
        }

        public int HabitacionId
        {
            get { return this.iHabitacion.HabitacionId; }
           // private set { this.iHabitacion. = value; }
        }

        public Habitacion Habitacion
        {
            get { return this.iHabitacion; }
            private set { this.iHabitacion = value; }
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
        public void CalcularCostoBase(List<TarifaCliente> pTarifas)
        {
            bool lExclusividad = this.iExclusividad;
            double costoBase = 0;
            DateTime auxFechaDesde;
			Cliente CliResposable = Clientes.Find(c => c.ClienteId == this.DniResponsable);

			if (this.iEstadoAloj == EstadoAlojamiento.Alojado)
            {
                auxFechaDesde = this.iFechaIngreso;

				if (CliResposable.TarifaCliente.TarifaClienteId != TipoCliente.Convenio)
				{
					foreach (var cliente in this.Clientes)
					{
						costoBase += cliente.ObtenerSuPrecioTarifa(lExclusividad);
					}
				}
				else
				{
					costoBase = CliResposable.ObtenerSuPrecioTarifa(this.Exclusividad);
				}
            }
            else // RESERVADO
            {
                auxFechaDesde = this.iFechaEstimadaIngreso;

				if (CliResposable.TarifaCliente.TarifaClienteId != TipoCliente.Convenio)
				{
					for (int i = 0; i < this.iContadoresTarifas.Length; i++)
					{
						byte aux = Convert.ToByte(this.iContadoresTarifas[i]);

						while (aux > Convert.ToByte('0'))
						{
							costoBase += pTarifas[i].GetTarifa(lExclusividad);
							aux--;
						}
					}//el resonsable no se encuentra en los contadores
					costoBase += CliResposable.ObtenerSuPrecioTarifa(this.Exclusividad);
				}
				else //si es por convenio
					costoBase = CliResposable.ObtenerSuPrecioTarifa(this.Exclusividad);
			}

			this.iMontoTotal = costoBase * (this.iFechaEstimadaEgreso.Date.Subtract(auxFechaDesde.Date).Days);

            Pago auxPago = this.Pagos.Find(p => p.Tipo == TipoPago.Deposito);
            if (auxPago != null)
                this.iMontoDeuda = this.iMontoTotal - auxPago.Monto;
            else
                this.iMontoDeuda = this.iMontoTotal;
        }

        public void RegistrarPago(Pago pPago)
        {
            this.iMontoDeuda -= pPago.Monto;

            //PARA EL CASO EN EL QUE SE AGREGA UN PRIMER PAGO
            if (this.Pagos!=null)
            {
                this.iPagos.Add(pPago);
            }
            else
            {
                this.Pagos = new List<Pago>() { pPago };
            }
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
            this.iClientes.Add(pCliente);
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
            this.iClientes = pClientes;
        }

		public int CantidadAlojados()
		{
			if (this.EstadoAlojamiento == EstadoAlojamiento.Alojado)
			{
				return Clientes.Count;
			}
			else
			{
				int auxCont = 0;
				for (int i = 0; i < ContadoresTarifas.Length; i++)
				{
					auxCont += Convert.ToInt32(ContadoresTarifas[i]);
				}
				return auxCont + 1;
			}
		}
    }
}