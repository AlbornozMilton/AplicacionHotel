using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            iDbContext.SaveChanges();
        }
    }
}
