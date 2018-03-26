using AutoMapper;
using Persistencia.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using pers = Persistencia.Domain;

namespace Dominio
{
    public class ControladorAlojamiento
    {
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        //Alta sin Reserva - Nueva Reserva
        public int RegistrarAloj(Alojamiento pAlojamiento)
        {
            var A = Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento);
            iUoW.RepositorioAlojamiento.Add(A);
            return iUoW.RepositorioAlojamiento.UltimoAgregado();
        }

        //Alta con Reserva - no genera un ID
        public void RegistrarAltaReserva(Alojamiento pAlojamiento)
        {
            var A = Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento);
            iUoW.RepositorioAlojamiento.AltaReserva(A);
        }

        public Alojamiento BuscarAlojamientoPorID(int unId)
        {
            return (Mapper.Map<pers.Alojamiento, Alojamiento>(iUoW.RepositorioAlojamiento.Get(unId)));
        }

        public List<Alojamiento> ObtenerAlojamientosActivos() //Devuelve la lista de alojamientos activos mappeandolos de Pers a Dominio
        {
            IEnumerable<pers.Alojamiento> listaEnum = iUoW.RepositorioAlojamiento.GetAllAlojamientosActivos();
            List<Alojamiento> listaAlojamientos = new List<Alojamiento>();
            foreach (var aloj in (listaEnum.ToList<pers.Alojamiento>()))
            {
                listaAlojamientos.Add(Mapper.Map<pers.Alojamiento, Alojamiento>(aloj));
            }
            return (listaAlojamientos);
        }

        public List<Alojamiento> ListaPersonalizada(List<EstadoAlojamiento> pEstados, DateTime pDesde, DateTime pHasta)
        {
            List<pers.EstadoAlojamiento> auxEstados = new List<pers.EstadoAlojamiento>();
            foreach (var estado in pEstados)
            {
                auxEstados.Add(Mapper.Map<EstadoAlojamiento, pers.EstadoAlojamiento>(estado));
            }

            IEnumerable<pers.Alojamiento> listaEnum = iUoW.RepositorioAlojamiento.ListaPersonalizada(auxEstados, pDesde, pHasta);
            List<Alojamiento> listaAlojamientos = new List<Alojamiento>();
            foreach (var aloj in (listaEnum.ToList<pers.Alojamiento>()))
            {
                listaAlojamientos.Add(Mapper.Map<pers.Alojamiento, Alojamiento>(aloj));
            }
            return (listaAlojamientos);
        }

        public List<Alojamiento> AlojamientosConDeuda()
        {
            IEnumerable<pers.Alojamiento> listaEnum = iUoW.RepositorioAlojamiento.AlojamientosConDeuda();
            List<Alojamiento> listaAlojamientos = new List<Alojamiento>();
            foreach (var aloj in (listaEnum.ToList<pers.Alojamiento>()))
            {
				listaAlojamientos.Add(Mapper.Map<pers.Alojamiento, Alojamiento>(aloj)); 
            }
            return listaAlojamientos;
        }
		/// <summary>
		/// Realiza la Ocupación para una fechas determinadas
		/// </summary>
		/// <returns>Habitaciones con los campos Ocupada y Exclusividad modificados</returns>
		public List<Habitacion> DeterminarDisponibilidad(DateTime fechaDesde, DateTime fechaHasta)
        {
            //ControladorHabitacion iControladorHab = new ControladorHabitacion();
            DateTime auxFechaIniAloj;
            DateTime auxFechaFinAloj;
            List<Alojamiento> listaAlojActivos = ObtenerAlojamientosActivos(); //METODO DEFINIDO EN REPOSITORIO ALOJAMIENTO -> lista de alojamientos en estado de Alojado o Reservado
            List<Habitacion> listaHabitaciones = new ControladorHabitacion().ObtenerHabitacionesFullLibres(); //GENERAR LISTA DE HABITACION TODAS LIBRE (GET ALL CON REPOSITORY)lista de todas las habitaciones del hotel, solo los HabitacionesID

            foreach (var aloj in listaAlojActivos)
            {
				//inicializar fechas locales
                auxFechaFinAloj = aloj.FechaEstimadaEgreso.Date;
                if (aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado)
                {
                    auxFechaIniAloj = aloj.FechaIngreso.Date;
                }
                else
                {
                    auxFechaIniAloj = aloj.FechaEstimadaIngreso.Date;
                }

                //control fechas
                if (
                     !(auxFechaFinAloj.CompareTo(fechaDesde.Date) <= 0 || auxFechaIniAloj.CompareTo(fechaHasta.Date) >= 0)
                   )
                {
                    foreach (var hab in listaHabitaciones)
                    {
                        if (hab.HabitacionId == aloj.HabitacionId)
                        {
							hab.OcuparHabitacion();
                            hab.SetExclusividad(aloj.Exclusividad);
                        }
                    }
                }

            }
            return (listaHabitaciones);
        }

        public bool ExclusividadSegunCapacidad(DateTime pFechaDesde, DateTime pFechaHasta, int pPorcentaje)
        {
			//este valor puede variar devido a los Alta de las Habitacioes, no es un valor fijo en la BD
            int auxCapacidadTotal = 0;

            List<Habitacion> Habitaciones = new ControladorHabitacion().ObtenerHabitacionesFullLibres();
            foreach (var hab in Habitaciones)
            {
                auxCapacidadTotal += hab.Capacidad;
            }

			//acumulará la cantidad respecto a las Hab exlcusivas
			int auxCantExclusiva = 0;

            List<Alojamiento> auxListaActivos = this.ObtenerAlojamientosActivos();

            foreach (var aloj in auxListaActivos)
            {
				//Acumular si se solicito exclusividad
				//se evalua exclsuvidad antes de entrar a hacer todo los demas calculos
                if (aloj.Exclusividad)
                {
                    DateTime alojFechaDesde = new DateTime();
                    
					//la cantidad exclusiva se acumula tanto si es alojado o reservado
                    if (aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado)
                        alojFechaDesde = aloj.FechaIngreso.Date;
                    else //reservado
                        alojFechaDesde = aloj.FechaEstimadaIngreso.Date;

					// Si hay interseccion entre las fechas acumular la cantidad de exclusividad
					if (!(
							(alojFechaDesde.CompareTo(pFechaDesde) < 0 && aloj.FechaEstimadaEgreso.Date.CompareTo(pFechaDesde) <=0)
                            ||
							(alojFechaDesde.Date.CompareTo(pFechaHasta) >= 0 && aloj.FechaEstimadaEgreso.Date.CompareTo(pFechaHasta) > 0)
						))
					{
                        auxCantExclusiva += aloj.Habitacion.Capacidad;
                    }
                }
            }
			return auxCantExclusiva < ((auxCapacidadTotal * pPorcentaje) / 100);
        }

        public void AddPago(Alojamiento pAlojamiento,Pago pPago)
        {
           iUoW.RepositorioAlojamiento.AddPago(Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento), Mapper.Map<Pago, pers.Pago>(pPago));
        }

        public void AgregarServicio (Servicio pServicio, byte pCant, Alojamiento pAlojamiento)
        {
            LineaServicio nuevaLineaServicio = new LineaServicio(pCant, pServicio);
            pAlojamiento.AgregarLineaServicio(nuevaLineaServicio);
            iUoW.RepositorioAlojamiento.AddLineaServicio(Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento), Mapper.Map<LineaServicio, pers.LineaServicio>(nuevaLineaServicio));
        }

		/// <summary>
		/// Control de Tipos y Cantidades. Cambia estado y fecha. Recalcula costo base.
		/// </summary>
		public void ComprobarClientesAltaConReserva(Alojamiento pAlojEnAlta, string pCostoBase)
		{
			List<Cliente> ClientesAloj = new List<Cliente>(pAlojEnAlta.Clientes);
			ClientesAloj.Remove(pAlojEnAlta.Clientes.Find(c => c.ClienteId == pAlojEnAlta.DniResponsable)); //Responsable
			ClientesAloj.OrderBy(t => t.TarifaCliente.TarifaClienteId).ToList();

			string pContadores = pAlojEnAlta.ContadoresTarifas;

			for (int indiceTipo = 0; indiceTipo < pContadores.Length; indiceTipo++)
            {
				int cantTipo = Convert.ToInt32(pContadores[indiceTipo]);
				/*
				indiceTipo
					0	Titular
					1	Acompañante Directo
					2	Acompañante No Directo
					3	Titular Exceptuado
					4	Convenio
				 */
				while (cantTipo > Convert.ToByte('0'))
				{
					Cliente cli = ClientesAloj.Find(c => Convert.ToInt32(c.TarifaCliente.TarifaClienteId) == indiceTipo);
					if (cli !=null)
						ClientesAloj.Remove(cli);
					else
						throw new Exception("Los Clientes cargados NO corresponden con los cargados en la Reserva");
					cantTipo--;
				}
			}

			if (ClientesAloj.Count != 0)
			{
				throw new Exception("Los Clientes cargados NO corresponden con los cargados en la Reserva");
			}

			pAlojEnAlta.AltaDeReserva();

            pAlojEnAlta.CalcularCostoBase(new List<TarifaCliente>()); 

            if (pAlojEnAlta.MontoTotal.ToString() != pCostoBase)
            {
                throw new Exception("Costo Base Incorrecto.");
            }
        }
       
        /// <summary>
        /// Cotrola excepciones previamente para dar de Alta una Reserva: Estado Reservado - Fecha de Alta
        /// </summary>
        public void ControlInicioAltaReserva(Alojamiento pAloj)
        {
            if (pAloj.EstadoAlojamiento != EstadoAlojamiento.Reservado)
            {
                throw new Exception("El Alojamiento seleccionado debe estar en estado Reservado solamente. Vea los detalles.");
            }

            if (pAloj.FechaEstimadaIngreso.Date.CompareTo(DateTime.Now.Date) > 0)
            {
                throw new Exception("La Fecha Estimada de Ingreso de la Reserva no coincide con la Fecha Actual. Vea los detalles.");
            }
        }

        public void ControlPlazoParaReservar(DateTime pFechaEstimadaIngreso)
        {
            if (pFechaEstimadaIngreso.Subtract(DateTime.Now.Date).Days > 30)
            {
                throw new Exception("Solo se puede realizar Reservas dentro de los 30 Días respecto la Fecha Estimada Ingreso.");
            }
        }

        /// <summary>
        /// Devulve una Lista de Alojamientos Reservados que pasaron 72hs sin realizar depósito
        /// </summary>
        public List<Alojamiento> AlojsReservadosConDepositoVencidos()
        {
            List <Alojamiento> auxLista = this.ObtenerAlojamientosActivos();
            List<Alojamiento> ListaResultado = new List<Alojamiento>();
            foreach (var aloj in auxLista)
            {
                if (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado)
                {
                    if (
                        (DateTime.Now.Subtract(aloj.FechaReserva).Ticks >= (TimeSpan.TicksPerHour * 72))
                        &
                        (aloj.Pagos.Find(p => p.Tipo == TipoPago.Deposito) == null)//no existe pago de deposito
                        )
                    {
                        ListaResultado.Add(aloj);
                    }
                }
            }
            return ListaResultado;
        }

        /// <summary>
        /// Para que se realice este método el Alojamiento debe tener un Pago Alojado (Realizar control en UI)
        /// </summary>
        public void CerrarAlojamiento(Alojamiento pAlojamiento)
        {
            //Siempre se va a colocar en "false" la exclusividad
            pAlojamiento.Habitacion.SetExclusividad(false);
            pAlojamiento.Habitacion.DesocuparHabitacion();
			//fecha de hoy y cambio de estado
			pAlojamiento.Cerrar();


            //registrar fecha de egreso y cambia el Estado del Alojamiento a Cerrado
            iUoW.RepositorioAlojamiento.FinalizarAlojamiento(Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento));
        }

        public void CancelarAlojamiento(Alojamiento pAlojamiento)
        {
            pAlojamiento.Cancelar();
            iUoW.RepositorioAlojamiento.FinalizarAlojamiento(Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento));
        }
    }
}
