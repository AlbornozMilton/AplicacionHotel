using System;
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

        public Domicilio CargaDomicilio(Domicilio pDomicilio)
        {
            Ciudad ciudad = iDbContext.Ciudades.Include("Domicilios").Single(c => c.CiudadId == pDomicilio.Ciudad.CiudadId);

            Domicilio domicilio = null;

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
                    domicilio = dom;
                    break;
                }
            }

            if (domicilio == null)
            {
                pDomicilio.CiudadId = pDomicilio.Ciudad.CiudadId;
                pDomicilio.Ciudad = null;
                this.iDbContext.Domicilios.Add(pDomicilio);

                //futuro prox ID - para luego buscar domicilio por ID
                pDomicilio.DomicilioId = this.iDbContext.Domicilios.Max(d => d.DomicilioId) + 1;
                
                domicilio = pDomicilio;

                iDbContext.SaveChanges();
            }

            return domicilio;
        }
    }
}
