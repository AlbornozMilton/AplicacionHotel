using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;
using AutoMapper;
using pers = Persistencia.Domain;

namespace Dominio
{
    public class ControladorHabitacion
    {
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        public Habitacion ObtenerHabitacion(int unId)
        {
            pers.Habitacion unaHab = iUoW.RepositorioHabitacion.Get(unId);
            Habitacion laHabBuscada = Mapper.Map<pers.Habitacion, Habitacion>(unaHab);
            return laHabBuscada;
        }
        public List<Habitacion> ObtenerHabitacionesFullLibres()
        {
            IEnumerable<pers.Habitacion> listaEnum = iUoW.RepositorioHabitacion.GetAllconCupos();
            List<Habitacion> lista = new List<Habitacion>();
            foreach (var hab in listaEnum)
            {
                hab.Exclusiva = false;
                foreach (var cupo in hab.Cupos)
                {
                    if (cupo.Disponible == false)
                    {
                        cupo.Disponible = true;
                    }
                }
                lista.Add(Mapper.Map<pers.Habitacion, Habitacion>(hab));
            }
            return (lista);
        }
    }
}
