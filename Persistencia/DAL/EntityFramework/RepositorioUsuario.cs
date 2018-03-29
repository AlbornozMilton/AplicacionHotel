using Persistencia.Domain;
using System.Linq;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioUsuario : Repositorio<Usuario, HotelContext>, IRepositorioUsuario
    {
        public RepositorioUsuario(HotelContext pContext) : base(pContext)
        {
			
		}

		public void NuevoUsuario(string pUsuarioID, string pPass)
		{
			Usuario localUser = this.iDbContext.Usuarios.Where(user => user.UsuarioId == pUsuarioID).SingleOrDefault();
			if (localUser != null)
			{
				throw new System.Exception("Nombre de Usuario Existente");
			}
			iDbContext.Usuarios.Add(new Usuario{UsuarioId = pUsuarioID, Password = pPass});
			iDbContext.SaveChanges();
		}

		public void EliminarUsuario(string pUsuarioID, string pPass)
		{
			Usuario localUser = this.iDbContext.Usuarios.Where(user => user.UsuarioId == pUsuarioID && user.Password == pPass).SingleOrDefault();
			if (localUser == null)
			{
				throw new System.Exception("Nombre de Usuario o Contraseña Incorrecta");
			}
			iDbContext.Usuarios.Remove(localUser);
			iDbContext.SaveChanges();
		}

		public void ModifcarUsuario(string pUsuarioID, string pOldPass, string pNewPass)
		{
			Usuario localUser = this.iDbContext.Usuarios.Where(user => user.UsuarioId == pUsuarioID && user.Password == pOldPass).SingleOrDefault();
			if (localUser == null)
			{
				throw new System.Exception("Nombre de Usuario o Contraseña Incorrecta");
			}
			localUser.Password = pNewPass;
			iDbContext.SaveChanges();
		}
	}
}
