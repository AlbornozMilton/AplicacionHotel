using Persistencia.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioUsuario : Repositorio<Usuario, HotelContext>, IRepositorioUsuario
    {
        public RepositorioUsuario(HotelContext pContext) : base(pContext)
        {

        }
        
    }
}
