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
        public bool Existe(string pUs, string pPass)
        {
            // return (base.iDbContext.Set<Cliente>().Find(pCliente.ClienteId) != null);
            Usuario Us = base.iDbContext.Usuarios.Find(pUs);
            return ((Us != null) && (Us.Password == pPass));
            base.iDbContext.Dispose();
        }
    }
}
