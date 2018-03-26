using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioUsuario : Repositorio<Usuario, HotelContext>, IRepositorioUsuario
    {
        public RepositorioUsuario(HotelContext pContext) : base(pContext)
        {

        }
        
    }
}
