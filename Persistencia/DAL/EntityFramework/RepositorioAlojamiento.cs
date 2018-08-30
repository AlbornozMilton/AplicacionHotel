using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                return iDbContext.Alojamientos.Include("Servicios.Servicio").Include("Pagos").Include("AlojHabes.Habitacion").Include("AlojHabes.Tarifas").Include("AlojHabes.Clientes")
                    .Where(a => a.AlojamientoId == pId).SingleOrDefault();
            }
            catch (Exception)
            {
                throw new Exception("Alojamiento No Existe");
            }

        }

        public IEnumerable<Alojamiento> GetAllAlojamientosActivos()
        {
            var alojamientos = from aloj in this.iDbContext.Alojamientos.Include("Servicios.Servicio").Include("AlojHabes.Habitacion").Include("AlojHabes.Tarifas").Include("AlojHabes.Clientes").Include("Pagos")
                               where ((aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado) || (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado))
                               select aloj;

            return alojamientos.ToList();
        }

        public IEnumerable<Alojamiento> ListaPersonalizada(List<EstadoAlojamiento> pEstados, DateTime pDesde, DateTime pHasta)
        {
            var alojamientos = from aloj in this.iDbContext.Alojamientos.Include("Servicios.Servicio").Include("Pagos").Include("AlojHabes.Habitacion").Include("AlojHabes.Tarifas").Include("AlojHabes.Clientes")
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

            return alojamientos.ToList();
        }

        public IEnumerable<Alojamiento> AlojamientosConDeuda()
        {
            var alojamientos = from aloj in this.iDbContext.Alojamientos.Include("Servicios.Servicio").Include("Pagos").Include("AlojHabes.Habitacion").Include("AlojHabes.Tarifas").Include("AlojHabes.Clientes")
                               where ((aloj.EstadoAlojamiento == EstadoAlojamiento.Cerrado) && (aloj.MontoDeuda > 0))
                               select aloj;

            return alojamientos.ToList();
        }

        /// <summary>
        /// Utilizado para Nueva Reserva o Nuevo Aloj
        /// </summary>
        public override void Add(Alojamiento unAloj)
        {
            //        iDbContext.Entry(tarifa).State = EntityState.Modified;
            foreach (var ah in unAloj.AlojHabes)
            {
                ah.HabitacionId = ah.Habitacion.HabitacionId;
                ah.Habitacion = null;

                foreach (var item in ah.Tarifas)
                {
                    iDbContext.Entry(item).State = EntityState.Modified;
                    //item.Clientes = null;
                }

                foreach (var item in ah.Clientes)
                {
                    item.DomicilioId = item.Domicilio.DomicilioId;
                    iDbContext.Entry(item).State = EntityState.Modified;
                    //item.TarifaCliente = null;
                }
            }

            iDbContext.Alojamientos.Add(unAloj);

            iDbContext.SaveChanges();
        }

        /// <summary>
        /// Utilizado para Alta de una Reserva
        /// </summary>
        public void AltaReserva(Alojamiento pAloj)
        {
            //        iDbContext.Entry(tarifa).State = EntityState.Modified;
            Alojamiento localAloj = this.Get(pAloj.AlojamientoId);
            localAloj.MontoDeuda = pAloj.MontoDeuda;//por si efectuo pago reserva 
            localAloj.EstadoAlojamiento = pAloj.EstadoAlojamiento;
            localAloj.FechaIngreso = pAloj.FechaIngreso;//para las altas
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
    }
}
