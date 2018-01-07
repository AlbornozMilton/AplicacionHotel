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

        public bool VerificarSolicitdExclusividad(Habitacion pHab)
        {
            // se se cumple la igualdad, se puede pedir exclusividad
            return (pHab.CuposDoblesDisponibles() + pHab.CuposSimpleDisponibles()) == pHab.Capacidad();
        }

        public void VerificarCuposSeleccionados(Habitacion pHab, decimal pCantS, decimal pCantD)
        {
            if ((pHab.CuposSimpleDisponibles()<pCantS)||(pHab.CuposDoblesDisponibles()<pCantD))
            {
                throw new Exception("Las cantidades de Cupos ingresadas no son posibles para la Habitación en estos momentos.");
            }
        }
    }
}
