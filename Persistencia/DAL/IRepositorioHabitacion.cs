using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL
{
    public interface IRepositorioHabitacion:IRepositorio<Habitacion>
    {
        IEnumerable<Habitacion> GetAllconCupos();
        void ModificarAltaHabitacion(Habitacion pHabitacion);
    }
}
