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

        public Ciudad GetCiudad(int pCodPostal, string pNombre)
        {
            return iDbContext.Ciudades.Include("Domicilios").SingleOrDefault(c => c.CodPostal == pCodPostal && c.Nombre == pNombre);
        }

        public IEnumerable<string> CallesDeCiudad(int pCodPostal, string pNombre)
        {
            var calles = from domicilio in iDbContext.Domicilios
                         where pCodPostal == domicilio.Ciudad.CodPostal && pNombre == domicilio.Ciudad.Nombre
                         select domicilio.Calle;

            return calles.Distinct();
        }
    }
}
