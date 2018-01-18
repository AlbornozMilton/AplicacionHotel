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

        /// <summary>
        /// Retorna verdadero si la suma de cupos simples disponibles más la suma de cupos dobles disponibles es igual a la capacidad de la habitacíón
        /// </summary>
        public bool VerificarSolicitdExclusividad(Habitacion pHab)
        {
            // se se cumple la igualdad, se puede pedir exclusividad
            return pHab.CuposSimpleDisponibles() + (pHab.CuposDoblesDisponibles() * 2) == pHab.Capacidad();
        }

        public void VerificarCuposSimplesIngresados(Habitacion pHab, decimal pCantS)
        {
            if ((pHab.CuposSimpleDisponibles()<pCantS))
            {
                throw new Exception("Las cantidades de Cupos Simples que desea no son posibles para la Habitación en estos momentos.");
            }
        }

        public void VerificarCuposDoblesIngresados(Habitacion pHab, decimal pCantD)
        {
            if (pHab.CuposDoblesDisponibles() < pCantD)
            {
                throw new Exception("Las cantidades de Cupos Dobles que desea no son posibles para la Habitación en estos momentos.");
            }
        }

        public List<Habitacion> GetAllHabitaciones()
        {
            List<Habitacion> listaResultado = new List<Habitacion>();
            foreach (var hab in iUoW.RepositorioHabitacion.GetAllconCupos())
            {
                listaResultado.Add(Mapper.Map<pers.Habitacion, Habitacion>(hab));
            }
            return listaResultado;
        }

        public List<Alojamiento> ControlModificarAltaCupos(int pIdHabitacion)
        {
            List<Alojamiento> AlojsActivos = new ControladorAlojamiento().ObtenerAlojamientosActivos();
            List<Alojamiento> AlojsResltultado = new List<Alojamiento>();
                
            foreach (var aloj in AlojsActivos)
            {
                if (aloj.HabitacionId == pIdHabitacion)
                {
                    AlojsResltultado.Add(aloj);
                }
            }

            return AlojsResltultado;
        }

        public void ModificarAltaDeCupos(Habitacion pHabitacion)
        {
            iUoW.RepositorioHabitacion.ModificarAltaCupo(Mapper.Map<Habitacion, pers.Habitacion>(pHabitacion));
        }
    }
}
