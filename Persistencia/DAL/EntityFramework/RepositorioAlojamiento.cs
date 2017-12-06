﻿using System;
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
                return (iDbContext.Alojamientos.Include("Habitacion").Include("Clientes").Where(a => a.AlojamientoId == pId).First());
            }
        }
        public IEnumerable<Alojamiento> GetAllAlojamientosActivos()
        {
            var alojamientos = from aloj in this.iDbContext.Alojamientos.Include("Habitacion.Cupos").Include("Clientes")
                               where ((aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado) || (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado))
                               select aloj;

            return alojamientos.ToList<Alojamiento>();
        }

        public void AddReserva(Alojamiento unAloj)
        {
            foreach (var cli in unAloj.Clientes)
            {
                iDbContext.Clientes.Attach(cli);
            }
            iDbContext.Habitaciones.Attach(unAloj.Habitacion);
            iDbContext.Alojamientos.Add(unAloj);
        }
    }
}
