using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    class RepositorioCliente : Repositorio<Cliente,HotelContext> ,IRepositorioCliente
    {
        public RepositorioCliente(HotelContext pContext) : base(pContext)
        {
        }

    }
}
