using Persistencia.Domain;

namespace Persistencia.DAL
{
    public interface IRepositorioHabitacion:IRepositorio<Habitacion>
    {
        void ModificarAltaHabitacion(Habitacion pHabitacion);
    }
}
