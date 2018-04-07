using System.Collections.Generic;
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

        public List<Habitacion> GetAllHabitaciones()
        {
            List<Habitacion> listaResultado = new List<Habitacion>();
            foreach (var hab in iUoW.RepositorioHabitacion.GetAll())
            {
                listaResultado.Add(Mapper.Map<pers.Habitacion, Habitacion>(hab));
            }
            return listaResultado;
        }

		/// <summary>
		/// Devuelve las Habitaciones que estan solamente en Alta
		/// </summary>
		/// <returns></returns>
        public List<Habitacion> ObtenerHabitacionesFullLibres()
        {
            IEnumerable<pers.Habitacion> listaEnum = iUoW.RepositorioHabitacion.GetAll();
            List<Habitacion> lista = new List<Habitacion>();
            foreach (var hab in listaEnum)
            {
				if (hab.Alta)
				{
					Habitacion HabDom = Mapper.Map<pers.Habitacion, Habitacion>(hab);
					HabDom.DesocuparHabitacion();
					lista.Add(HabDom); 
				}
            }
            return (lista);
        }

		/// <summary>
		/// Devuelve una lista con Alojamiento Activos en los que se encuetra una Habitación
		/// </summary>
        public List<Alojamiento> ControlModificarAltaHabitacion(int pIdHabitacion)
        {
            List<Alojamiento> AlojsActivos = new ControladorAlojamiento().ObtenerAlojamientosActivos();
            List<Alojamiento> AlojsResltultado = new List<Alojamiento>();
                
            foreach (var aloj in AlojsActivos)
            {
				foreach (var alojHab in aloj.AlojHabes)
				{
					if (alojHab.Habitacion.HabitacionId == pIdHabitacion)
					{
						AlojsResltultado.Add(aloj);
					}
				}
            }
            return AlojsResltultado;
        }

        public void ModificarAltaDeHabitacion(Habitacion pHabitacion)
        {
			iUoW.RepositorioHabitacion.ModificarAltaHabitacion(Mapper.Map<Habitacion,pers.Habitacion>(pHabitacion));
        }
    }
}
