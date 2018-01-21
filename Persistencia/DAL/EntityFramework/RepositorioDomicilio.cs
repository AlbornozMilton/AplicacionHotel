﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioDomicilio: Repositorio<Domicilio, HotelContext>, IRepositorioDomicilio
    {
        public RepositorioDomicilio(HotelContext pContext) : base(pContext)
        {

        }

        /// <summary>
        /// Retorna el numero ID en la BD si encuentra el Domicilio. Sino retorna el nuevo ID
        /// </summary>
        /// <param name="pDomicilio"></param>
        /// <returns></returns>
        public int ComprobarDomicilio(Domicilio pDomicilio)
        {
            Ciudad ciudad = iDbContext.Ciudades.Include("Domicilios").SingleOrDefault(c => c.CiudadId == pDomicilio.Ciudad.CiudadId);

            foreach (var dom in ciudad.Domicilios)
            {
                if 
                    (
                     dom.Calle == pDomicilio.Calle &&
                     dom.Numero == pDomicilio.Numero &&
                     dom.NroDepto == pDomicilio.NroDepto &&
                     dom.Piso == pDomicilio.Piso
                    )
                {
                    return dom.DomicilioId;
                }
            }

            pDomicilio.CiudadId = pDomicilio.Ciudad.CiudadId;
            pDomicilio.Ciudad = null;
            this.iDbContext.Domicilios.Add(pDomicilio);

            this.iDbContext.SaveChanges();

            return this.iDbContext.Domicilios.Max(d => d.DomicilioId);
        }
    }
}
