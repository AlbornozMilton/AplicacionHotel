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
            if (iDbContext.Alojamientos.Find(pId) == null)
            {
                throw new Exception("Alojamiento No Existe");
            }
            else
            {
                return (iDbContext.Alojamientos.Include("Habitacion").Include("Pagos").Include("Clientes").Where(a => a.AlojamientoId == pId).First());
            }
        }
        public IEnumerable<Alojamiento> GetAllAlojamientosActivos()
        {
            var alojamientos = from aloj in this.iDbContext.Alojamientos.Include("Habitacion.Cupos").Include("Clientes")
                               where ((aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado) || (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado))
                               select aloj;

            return alojamientos.ToList<Alojamiento>();
        }

        // MODIFICAR PENSANDO EN HABITACION.ADD
        public override void Add(Alojamiento unAloj)
        {
            List<Cliente> auxListCliente = new List<Cliente>();
            foreach (var cli in unAloj.Clientes)
            {
                auxListCliente.Add(iDbContext.Clientes.Find(cli.ClienteId));
            }
            unAloj.Clientes = auxListCliente;


            if (unAloj.EstadoAlojamiento == EstadoAlojamiento.Alojado)
            {
                //Para el caso que se modifique la exclusividad de la habitacion
                iDbContext.Entry(unAloj.Habitacion).State = System.Data.Entity.EntityState.Modified;

                foreach (var cupo in unAloj.Habitacion.Cupos)
                {
                    iDbContext.Entry(cupo).State = System.Data.Entity.EntityState.Modified;
                }
            }
            
            iDbContext.Alojamientos.Add(unAloj);

            iDbContext.SaveChanges();
        }

        public void AddPago(Alojamiento unAloj, Pago pPago)
        {
            Alojamiento lAuxAloj = iDbContext.Alojamientos.Include("Pagos").Where(a => a.AlojamientoId == unAloj.AlojamientoId).First();

            lAuxAloj.MontoDeuda = unAloj.MontoDeuda;

            if (lAuxAloj.Pagos.Count == 0)
            {
                lAuxAloj.Pagos = new List<Pago>() { pPago };
                iDbContext.Pagos.Add(pPago);
            }
            else
            {
                iDbContext.Pagos.Add(pPago);
            }
        }
    }
}
