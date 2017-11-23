using Persistencia.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ControladorHabitacion
    {
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());
        public List<Habitacion> DeterminarDisponibilidad(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Alojamiento> listaAlojActivos = new List<Alojamiento>(); //lista de alojamientos en estado de Alojado o Reservado
            List<Habitacion> listaHabitaciones = new List<Habitacion>(); //lista de todas las habitaciones del hotel, solo los HabitacionesID
            List<Habitacion> listaHabDisponibles = new List<Habitacion>(); //lista de habitaciones con cupos disponibles en esas fechas
            foreach (var hab in listaHabitaciones)
            {
                foreach (var aloj in listaAlojActivos)
                {
                    if (aloj.Habitacion.HabitacionId == hab.HabitacionId)
                    {
                        if (aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado)
                        {
                            //DateTime fechaIni = aloj.getfechaIngreso()
                            //DateTime fechaFin = aloj.getfechaEstimadaEgreso();
                        }
                        else
                        {
                            //DateTime fechaIni = aloj.getfechaEstimadaIngreso();
                            //DateTime fechaFin = aloj.getfechaEstimadaEgreso();
                        }
                        if (fechaDesde>fechaFin) || (fechaHasta<fechaIni)
                        {
                            //obtenerCantidadCuposDoble()
                            //obtenerCantidadCuposSimples()
                            //determinarExclusividad()
                            //listaHabDisponlibles.Add(hab)
                        }
                    }
                    else
                    {
                        //obtenerCantidadCuposDoble()
                        //obtenerCantidadCuposSimples()
                        //determinarExclusividad()
                        //listaHabDisponlibles.Add(hab)
                    }
                }
            }
            return (listaHabDisponibles);
        }
    }
}
