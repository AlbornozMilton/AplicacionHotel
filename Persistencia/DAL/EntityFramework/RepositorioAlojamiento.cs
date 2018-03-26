using System;
using System.Collections.Generic;
using System.Linq;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    class RepositorioAlojamiento : Repositorio<Alojamiento, HotelContext>, IRepositorioAlojamiento
    {
        public RepositorioAlojamiento(HotelContext pContext) : base(pContext)
        {

        }

        public int UltimoAgregado()
        {
            return iDbContext.Alojamientos.Max(a => a.AlojamientoId);
        }
        /// <summary>
        /// Este Get devuelve el Alojamiento acompañado de la Habitacion y de la lista de Clientes
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public override Alojamiento Get(int pId)
        {
            try
            {
                return iDbContext.Alojamientos.Include("Servicios.Servicio").Include("Pagos").Include("Habitacion").Include("Clientes.TarifaCliente").Include("Clientes.Domicilio").Where(a => a.AlojamientoId == pId).SingleOrDefault();
            }
            catch (Exception)
            {
                throw new Exception("Alojamiento No Existe");
            }

        }

        public IEnumerable<Alojamiento> GetAllAlojamientosActivos()
        {
            var alojamientos = from aloj in this.iDbContext.Alojamientos.Include("Servicios.Servicio").Include("Habitacion").Include("Pagos").Include("Clientes.TarifaCliente").Include("Clientes.Domicilio")
                               where ((aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado) || (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado))
                               select aloj;

            return alojamientos.ToList<Alojamiento>();
        }

        public IEnumerable<Alojamiento> ListaPersonalizada(List<EstadoAlojamiento> pEstados, DateTime pDesde, DateTime pHasta)
        {
            var alojamientos = from aloj in this.iDbContext.Alojamientos.Include("Servicios.Servicio").Include("Pagos").Include("Clientes.TarifaCliente").Include("Clientes.Domicilio").Include("Habitacion")
							   where (
										(pEstados.Contains(aloj.EstadoAlojamiento))
                                        &&
                                        (
                                            (aloj.FechaEstimadaIngreso.ToString().CompareTo(pDesde.ToString()) > 0) && aloj.FechaEstimadaEgreso.ToString().CompareTo(pHasta.ToString()) <= 0
                                            ||
                                            (aloj.FechaIngreso.ToString().CompareTo(pDesde.ToString()) >= 0) && aloj.FechaIngreso.ToString().CompareTo(pHasta.ToString()) < 0
                                            ||
                                            (aloj.FechaEstimadaIngreso.ToString().CompareTo(pDesde.ToString()) >= 0) && aloj.FechaEstimadaIngreso.ToString().CompareTo(pHasta.ToString()) < 0
                                        )
                                    )
                               select aloj;

            return alojamientos.ToList<Alojamiento>();
        }

        /// <summary>
        /// Utilizado para Nueva Reserva o Nuevo Aloj
        /// </summary>
        public override void Add(Alojamiento unAloj)
        {
            List<Cliente> auxListCliente = new List<Cliente>();
            Habitacion auxHabitacion = unAloj.Habitacion;

			unAloj.Habitacion = iDbContext.Habitaciones.SingleOrDefault(h => h.HabitacionId == unAloj.HabitacionId);

			//Enlazar clientes
            foreach (var cli in unAloj.Clientes)
            {
                auxListCliente.Add(iDbContext.Clientes.Find(cli.ClienteId));
            }
            unAloj.Clientes = auxListCliente;


            if (unAloj.EstadoAlojamiento == EstadoAlojamiento.Alojado)
            {
				// condicion de que la HAB este en ALTA ??
                unAloj.Habitacion.Exclusiva = auxHabitacion.Exclusiva;
				unAloj.Habitacion.Ocupada = auxHabitacion.Ocupada;

            }

            iDbContext.Alojamientos.Add(unAloj);

            iDbContext.SaveChanges();
        }

		/// <summary>
		/// Utilizado para Alta de una Reserva
		/// </summary>
        public void AltaReserva(Alojamiento pAloj)
        {
            Alojamiento localAloj = this.Get(pAloj.AlojamientoId);
            localAloj.MontoDeuda = pAloj.MontoDeuda;//por si efectuo pago reserva 
            localAloj.EstadoAlojamiento = pAloj.EstadoAlojamiento;
            localAloj.FechaIngreso = pAloj.FechaIngreso;//para las altas

            localAloj.Habitacion.Exclusiva = pAloj.Habitacion.Exclusiva;
          
            List<Cliente> auxListCliente = new List<Cliente>();
            foreach (var cli in pAloj.Clientes)
            {
                auxListCliente.Add(iDbContext.Clientes.Find(cli.ClienteId));
            }
            localAloj.Clientes = auxListCliente;

            iDbContext.SaveChanges();
        }

        /// <summary>
        /// Se finaliza un Alojamiento por Cerrado o Cancelado
        /// </summary>
        public void FinalizarAlojamiento(Alojamiento unAloj)
        {
            Alojamiento localAuxAloj = this.Get(unAloj.AlojamientoId);
            localAuxAloj.EstadoAlojamiento = unAloj.EstadoAlojamiento;
			localAuxAloj.MontoTotal = unAloj.MontoTotal;
			localAuxAloj.MontoDeuda = unAloj.MontoDeuda;

            if (localAuxAloj.EstadoAlojamiento == EstadoAlojamiento.Cerrado)
                localAuxAloj.FechaEgreso = unAloj.FechaEgreso;
            else
			{
				localAuxAloj.FechaCancelacion = unAloj.FechaCancelacion;
				localAuxAloj.MontoDeuda = 0;
			}

			iDbContext.SaveChanges();
        }


        public void AddPago(Alojamiento unAloj, Pago pPago)
        {
            Alojamiento localAloj = this.Get(unAloj.AlojamientoId);

            localAloj.MontoTotal = unAloj.MontoTotal;
            localAloj.MontoDeuda = localAloj.MontoDeuda - pPago.Monto;

            pPago.AlojamientoId = localAloj.AlojamientoId;
            iDbContext.Pagos.Add(pPago);

            iDbContext.SaveChanges();
        }

        public void AddLineaServicio(Alojamiento unAloj, LineaServicio pLineaServicio)
        {
            Alojamiento lAuxAloj = iDbContext.Alojamientos.Where(a => a.AlojamientoId == unAloj.AlojamientoId).Single();

            lAuxAloj.MontoDeuda = unAloj.MontoDeuda;
            lAuxAloj.MontoTotal = unAloj.MontoTotal;
			//enlazar
            pLineaServicio.Servicio = iDbContext.Servicios.Find(pLineaServicio.Servicio.ServicioId);
			//agrear id aloj
            pLineaServicio.AlojamientoId = lAuxAloj.AlojamientoId;
            iDbContext.LineaServicios.Add(pLineaServicio);

            iDbContext.SaveChanges();
        }

        public IEnumerable<Alojamiento> AlojamientosConDeuda()
        {
            var alojamientos = from aloj in this.iDbContext.Alojamientos.Include("Servicios.Servicio").Include("Pagos").Include("Clientes.TarifaCliente").Include("Clientes.Domicilio").Include("Habitacion")
							   where ((aloj.EstadoAlojamiento == EstadoAlojamiento.Cerrado) && (aloj.MontoDeuda > 0))
                               select aloj;

            return alojamientos.ToList<Alojamiento>();
        }
    }
}
