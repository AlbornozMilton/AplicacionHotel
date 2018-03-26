using System.Linq;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioHabitacion : Repositorio<Habitacion, HotelContext>, IRepositorioHabitacion
    {
        public RepositorioHabitacion(HotelContext pContext) : base(pContext)
        {

        }       

        public void ModificarAltaHabitacion(Habitacion pHabitacion)
        {
            Habitacion localHab = iDbContext.Habitaciones.Where(h => h.HabitacionId == pHabitacion.HabitacionId).SingleOrDefault();
			localHab.Alta = pHabitacion.Alta;
            iDbContext.SaveChanges();
        }
    }
}
