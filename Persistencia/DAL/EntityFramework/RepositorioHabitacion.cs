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

        public IEnumerable<Habitacion> GetAllconCupos()
        {
            var habitaciones = this.iDbContext.Habitaciones.Include("Cupos");

            return habitaciones.ToList<Habitacion>();
        }

        public void ModificarAltaCupo(Habitacion pHabitacion)
        {
            Habitacion localHab = iDbContext.Habitaciones.Include("Cupos").Where(h => h.HabitacionId == pHabitacion.HabitacionId).SingleOrDefault();

            //La pHabitacion viene con los cupos modificados
            for (int i = 0; i < pHabitacion.Cupos.Count; i++)
            {
                if (pHabitacion.Cupos[i].Alta != localHab.Cupos[i].Alta)
                {
                    localHab.Cupos[i].Alta = pHabitacion.Cupos[i].Alta;
                }
            }

            iDbContext.SaveChanges();
        }
    }
}
