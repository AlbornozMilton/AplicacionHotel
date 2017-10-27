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
    }
}
