using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    class RepositorioServicio : Repositorio<Servicio, HotelContext>, IRepositorioServicio
    {
        public RepositorioServicio(HotelContext pContext) : base(pContext)
        {

        }

        public Servicio GetByNombre(string pNombreServicio)
        {
            var servicio = iDbContext.Servicios.Where(s => s.Nombre == pNombreServicio).SingleOrDefault();
            return servicio;
        }
    }
}
