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

        public override Alojamiento Get(int pId)
        {
            try
            {
                return iDbContext.Alojamientos
                    .Include("Servicios.Servicio")
                    .Include("Pagos")
                    .Include("AlojHabes.Habitacion")
                    .Include("AlojHabes.Tarifas")
                    .Include("AlojHabes.Clientes.TarifaCliente")
                    .Include("AlojHabes.Clientes.Domicilio.Ciudad")
                    .Where(a => a.AlojamientoId == pId).SingleOrDefault();
            }
            catch (Exception)
            {
                throw new Exception("Alojamiento No Existe");
            }

        }

        public IEnumerable<Alojamiento> GetAllAlojamientosActivos()
        {
            var alojamientos = from aloj in this.iDbContext.Alojamientos
                                .Include("Servicios.Servicio")
                                .Include("Pagos")
                                .Include("AlojHabes.Habitacion")
                                .Include("AlojHabes.Tarifas")
                                .Include("AlojHabes.Clientes.Cliente.TarifaCliente")
                                .Include("AlojHabes.Clientes.Cliente.Domicilio.Ciudad")
                               where ((aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado) || (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado))
                               select aloj;

            return alojamientos.ToList();
        }

        public IEnumerable<Alojamiento> ListaPersonalizada(List<EstadoAlojamiento> pEstados, DateTime pDesde, DateTime pHasta)
        {
            var alojamientos = from aloj in this.iDbContext.Alojamientos
                                .Include("Servicios.Servicio")
                                .Include("Pagos")
                                .Include("AlojHabes.Habitacion")
                                .Include("AlojHabes.Tarifas")
                                .Include("AlojHabes.Clientes.Cliente.TarifaCliente")
                                .Include("AlojHabes.Clientes.Cliente.Domicilio.Ciudad")
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
            var alojamientos = from aloj in this.iDbContext.Alojamientos
                                .Include("Servicios.Servicio")
                                .Include("Pagos")
                                .Include("AlojHabes.Habitacion")
                                .Include("AlojHabes.Tarifas")
                                .Include("AlojHabes.Clientes.TarifaCliente")
                                .Include("AlojHabes.Clientes.Domicilio.Ciudad")
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
                    //if (!(iDbContext.Entry(item).CurrentValues == EntityState.Modified))
                    //    iDbContext.Entry(item).State = EntityState.Modified;
                }

                //iDbContext.Entry(ah.Clientes).State = EntityState.Modified;
                foreach (var cli in ah.Clientes)
                {
                    //cli.DomicilioId = cli.Domicilio.DomicilioId;
                    //cli.Domicilio.Clientes = null;
                    ////cli.TarifaCliente = null;
                    //cli.TarifaClienteId = cli.TarifaCliente.TarifaClienteId;
                    //cli.TarifaCliente.Clientes = null;
                    //cli.TarifaCliente.AlojHabs = null;
                    ////cli.TarifaCliente. = null;
                    //cli.AlojHabs = null;
                    ////cli.


                    //iDbContext.Entry(cli.TarifaCliente).State = EntityState.Modified;
                    //iDbContext.Entry(cli.Domicilio).State = EntityState.Modified;
                    iDbContext.Entry(cli).State = EntityState.Modified;
                }

                //iDbContext.Alojamientos.Add(unAloj);
                iDbContext.SaveChanges();
            }

            iDbContext.Alojamientos.Add(unAloj);

            iDbContext.SaveChanges();
        }

        /// <summary>
        /// Utilizado para Alta de una Reserva
        /// </summary>
        public void AltaReserva(Alojamiento pAloj)
        {
            var auxAlojHabes = pAloj.AlojHabes;
            pAloj.AlojHabes = null;
            iDbContext.Entry(pAloj).State = EntityState.Modified;
            iDbContext.SaveChanges();

            foreach (var ah in auxAlojHabes)
            {
                ah.AlojamientoId = pAloj.AlojamientoId;
                iDbContext.Entry(ah.Habitacion).State = EntityState.Modified;

                ah.Tarifas = null;

                foreach (var cli in ah.Clientes)
                {
                    //cli.DomicilioId = cli.Domicilio.DomicilioId;
                    //iDbContext.Entry(cli.TarifaCliente).State = EntityState.Modified;
                    //iDbContext.Entry(cli.Domicilio).State = EntityState.Modified;
                    //iDbContext.Entry(cli).State = EntityState.Modified;
                }

                iDbContext.AlojHabs.Add(ah);
            }

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
    }
}
