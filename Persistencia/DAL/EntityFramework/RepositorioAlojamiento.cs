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
                return iDbContext.Alojamientos.Include("Servicios.Servicio").Include("Habitacion.Cupos").Include("Pagos").Include("Clientes.TarifaCliente").Where(a => a.AlojamientoId == pId).Single();
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
            unAloj.Habitacion = iDbContext.Habitaciones.Find(unAloj.HabitacionId);

            //modificar unAloj.Habitacion segun auxHab

            if (unAloj.EstadoAlojamiento == EstadoAlojamiento.Alojado)
            {
                //------- modificar pensado en el alta con reserva...................................

                foreach (var cli in unAloj.Clientes)
                {
                    auxListCliente.Add(iDbContext.Clientes.Find(cli.ClienteId));
                }
                unAloj.Clientes = auxListCliente;
               
                //Para el caso que se modifique la exclusividad de la habitacion
                //iDbContext.Entry(unAloj.Habitacion).State = System.Data.Entity.EntityState.Modified;

                //foreach (var cupo in unAloj.Habitacion.Cupos)
                //{
                //    iDbContext.Entry(cupo).State = System.Data.Entity.EntityState.Modified;
                //}
            }

            //-----------------------------------------------------
            if (unAloj.EstadoAlojamiento == EstadoAlojamiento.Reservado)
            {

                foreach (var cli in unAloj.Clientes)
                {
                    //cliebte debido a los contadores
                    if (cli.ClienteId == 0)
                    {
                        do
                        {
                            //un digito menos que los DNI
                            cli.ClienteId = new Random().Next(1, 9999999);
                            
                            //mientras lo encuentre. cuando lo encuentre va a ser "null" y corta
                        } while (iDbContext.Clientes.Find(cli.ClienteId)!=null);

                        cli.Legajo = 0000;
                        cli.Nombre = "";
                        cli.Apellido = "";
                        cli.Telefono = "";
                        cli.EnAlta = false;
                        //correo se permite null

                        //luego se debe reemplazar por domicilio real
                        cli.Domicilio = iDbContext.Domicilios.First();

                        iDbContext.Entry(cli.TarifaCliente).State = System.Data.Entity.EntityState.Unchanged;

                        auxListCliente.Add(cli);

                    }
                    else
                    {
                        auxListCliente.Add(iDbContext.Clientes.Find(cli.ClienteId));
                    }
                }

                //unAloj.Habitacion = iDbContext.Habitaciones.Find(unAloj.HabitacionId);

            }

            unAloj.Clientes = auxListCliente;

            iDbContext.Alojamientos.Add(unAloj);

            iDbContext.SaveChanges();
        }

        /// <summary>
        /// Se finaliza un Alojamiento por Cerrado o Cancelado
        /// </summary>
        public void FinalizarAlojamiento(Alojamiento unAloj)
        {
            Alojamiento localAuxAloj = this.Get(unAloj.AlojamientoId);

            localAuxAloj.EstadoAlojamiento = unAloj.EstadoAlojamiento;
            if (localAuxAloj.EstadoAlojamiento == EstadoAlojamiento.Cerrado)
            {
                localAuxAloj.FechaEgreso = unAloj.FechaEgreso;
            }
            //else if (localAuxAloj.EstadoAlojamiento == EstadoAlojamiento.Cancelado)
            //{
            //    //modificar fechas --> fecha de cancelacion en caso de agregar el atributo fechaCancelacion
            //}

            //IMPLICITAMENTE SE MODIFICAN LOS CUPOS????? - PARECE QUE SI
            //localAuxAloj.Habitacion.Exclusiva = unAloj.Habitacion.Exclusiva;


            iDbContext.Entry(localAuxAloj).State = System.Data.Entity.EntityState.Modified;
            //iDbContext.Entry(localAuxAloj.Habitacion).State = System.Data.Entity.EntityState.Modified;
            iDbContext.SaveChanges();
        }


        public void AddPago(Alojamiento unAloj, Pago pPago)
        {
            Alojamiento lAuxAloj = iDbContext.Alojamientos.Where(a => a.AlojamientoId == unAloj.AlojamientoId).Single();

            lAuxAloj.MontoDeuda = unAloj.MontoDeuda;

            //if (lAuxAloj.Pagos.Count == 0)
            //{
            //    lAuxAloj.Pagos = new List<Pago>() { pPago };
            //    iDbContext.Pagos.Add(pPago);
            //}
            //else
            //{
            //    iDbContext.Pagos.Add(pPago);

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
