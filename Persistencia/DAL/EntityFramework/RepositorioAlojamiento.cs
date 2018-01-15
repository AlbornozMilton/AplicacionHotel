using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    class RepositorioAlojamiento : Repositorio<Alojamiento,HotelContext>, IRepositorioAlojamiento
    {
        public RepositorioAlojamiento(HotelContext pContext) : base(pContext)
        {

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
                return iDbContext.Alojamientos.Include("Servicios.Servicio").Include("Habitacion.Cupos").Include("Pagos").Include("Clientes.TarifaCliente").Include("Clientes.Domicilio").Where(a => a.AlojamientoId == pId).Single();
            }
            catch (Exception)
            {
                throw new Exception("Alojamiento No Existe");
            }
            
        }
        public IEnumerable<Alojamiento> GetAllAlojamientosActivos()
        {
            var alojamientos = from aloj in this.iDbContext.Alojamientos.Include("Habitacion.Cupos").Include("Clientes").Include("Servicios.Servicio").Include("Pagos")
                               where ((aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado) || (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado))
                               select aloj;

            return alojamientos.ToList<Alojamiento>();
        }

        /// <summary>
        /// Utilizado para todos los tipos de Altas
        /// </summary>
        public override void Add(Alojamiento unAloj)
        {
            List<Cliente> auxListCliente = new List<Cliente>();

            Habitacion auxHabitacion = unAloj.Habitacion;
            unAloj.Habitacion = iDbContext.Habitaciones.Include("Cupos").Single(h => h.HabitacionId == unAloj.HabitacionId);

            foreach (var cli in unAloj.Clientes)
            {
                auxListCliente.Add(iDbContext.Clientes.Find(cli.ClienteId));
            }
            unAloj.Clientes = auxListCliente;

            if (unAloj.EstadoAlojamiento == EstadoAlojamiento.Alojado)
            {
                unAloj.Habitacion.Exclusiva = auxHabitacion.Exclusiva;
                
                ////la que se ocupo en dominio
                for (int i = 0; i < unAloj.Habitacion.Cupos.Count; i++)
                {
                    if ((unAloj.Habitacion.Cupos[i].Disponible)&&(!auxHabitacion.Cupos[i].Disponible))
                    {
                        unAloj.Habitacion.Cupos[i].Disponible = false;
                    }
                }
            }

            iDbContext.Alojamientos.Add(unAloj);

            iDbContext.SaveChanges();
        }

        public void AltaReserva(Alojamiento pAloj)
        {
            Alojamiento localAloj = this.Get(pAloj.AlojamientoId);
            localAloj.MontoDeuda = pAloj.MontoDeuda;
            localAloj.EstadoAlojamiento = pAloj.EstadoAlojamiento;
            localAloj.FechaIngreso = pAloj.FechaIngreso;

            localAloj.Habitacion.Exclusiva = pAloj.Habitacion.Exclusiva;
            for (int i = 0; i < localAloj.Habitacion.Cupos.Count; i++)
            {
                //se va a ocupar--------------------------------//asegurar de que este disponible : control
                if ((localAloj.Habitacion.Cupos[i].Disponible) && (!pAloj.Habitacion.Cupos[i].Disponible))
                {
                    pAloj.Habitacion.Cupos[i].Disponible = false;
                }
            }

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
            Habitacion alojHabitacion = unAloj.Habitacion;

            localAuxAloj.EstadoAlojamiento = unAloj.EstadoAlojamiento;

            if (localAuxAloj.EstadoAlojamiento == EstadoAlojamiento.Cerrado)
            {
                localAuxAloj.FechaEgreso = unAloj.FechaEgreso;
                localAuxAloj.Habitacion.Exclusiva = alojHabitacion.Exclusiva;
                ////la que se ocupo en dominio
                for (int i = 0; i < unAloj.Habitacion.Cupos.Count; i++)
                {
                    if ((!localAuxAloj.Habitacion.Cupos[i].Disponible) && (alojHabitacion.Cupos[i].Disponible))
                    {
                        localAuxAloj.Habitacion.Cupos[i].Disponible = true;
                    }
                }
            }

            iDbContext.SaveChanges();
        }


        public void AddPago(Alojamiento unAloj, Pago pPago)
        {
            Alojamiento lAuxAloj = iDbContext.Alojamientos.Where(a => a.AlojamientoId == unAloj.AlojamientoId).Single();

            lAuxAloj.MontoTotal = unAloj.MontoTotal;
            lAuxAloj.MontoDeuda = unAloj.MontoTotal - pPago.Monto;

            pPago.AlojamientoId = unAloj.AlojamientoId;
            iDbContext.Pagos.Add(pPago);

            iDbContext.SaveChanges();
        }

        public void AddLineaServicio(Alojamiento unAloj, LineaServicio pLineaServicio)
        {
            Alojamiento lAuxAloj = iDbContext.Alojamientos.Where(a => a.AlojamientoId == unAloj.AlojamientoId).Single();

            lAuxAloj.MontoDeuda = unAloj.MontoDeuda;
            lAuxAloj.MontoTotal = unAloj.MontoTotal;
            pLineaServicio.Servicio = iDbContext.Servicios.Find(pLineaServicio.Servicio.ServicioId);

            pLineaServicio.AlojamientoId = unAloj.AlojamientoId;
            iDbContext.LineaServicios.Add(pLineaServicio);

            iDbContext.SaveChanges();
        }
    }
}
