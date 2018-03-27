using Persistencia.Domain;
using System.Linq;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioUsuario : Repositorio<Usuario, HotelContext>, IRepositorioUsuario
    {
        public RepositorioUsuario(HotelContext pContext) : base(pContext)
        {

        }

		public void ModifcarUsuario(string pUsuarioID, string pOldPass, string pNewPass)
		{
			Usuario localUser = this.iDbContext.Usuarios.Where(user => user.UsuarioId == pUsuarioID && user.Password == pOldPass).SingleOrDefault();
								;
			if (localUser != null)
			{
				localUser.Password = pNewPass;
			}
			else
			{
				throw new System.Exception("Nombre de Usuario o Contraseña Incorrecta");
			}

			iDbContext.SaveChanges();
		}
	}
}
