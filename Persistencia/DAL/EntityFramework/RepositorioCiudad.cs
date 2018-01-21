using Persistencia.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioCiudad : Repositorio<Ciudad, HotelContext>, IRepositorioCiudad
    {
        public RepositorioCiudad(HotelContext pContext) : base(pContext)
        {

        }

        //public override IEnumerable<Ciudad> GetAll()
        //{
        //    return iDbContext.Ciudades.Include("Domicilios");
        //}

        public override Ciudad Get(int pId)
        {
            return iDbContext.Ciudades.Include("Domicilios").SingleOrDefault(c => c.CiudadId == pId);
        }

        public IEnumerable<string> CallesDeCiudad(int pCodPostal)
        {
            var calles = from domicilio in iDbContext.Domicilios
                         where pCodPostal == domicilio.CiudadId
                         select domicilio.Calle;

            return calles.Distinct();
        }
    }
}
