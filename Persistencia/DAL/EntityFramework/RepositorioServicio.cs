using System.Linq;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    class RepositorioServicio : Repositorio<Servicio, HotelContext>, IRepositorioServicio
    {
        public RepositorioServicio(HotelContext pContext) : base(pContext)
        {

        }

		/// <summary>
		/// no se utiliza
		/// </summary>
        public Servicio GetByNombre(string pNombreServicio)
        {
            return iDbContext.Servicios.Where(s => s.Nombre == pNombreServicio).SingleOrDefault();
        }

		public void ActualizarCostoServicio(Servicio pServicio)
		{
			Servicio localServicio = iDbContext.Servicios.Find(pServicio.ServicioId);
			localServicio.CostoBase = pServicio.CostoBase;
			iDbContext.SaveChanges();
		}

		public void NuevoServicio(Servicio pServicio)
		{
			throw new System.NotImplementedException();
		}

		public void ElimiarServicio(Servicio pServicio)
		{
			iDbContext.Servicios.Remove
				(
					iDbContext.Servicios.Where(s => s.ServicioId == pServicio.ServicioId).Single()
				);

			iDbContext.SaveChanges();
		}
	}
}
