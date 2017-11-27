using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;



namespace Dominio
{
    public class ControladorHabitacion
    {








































        public List<Habitacion> DeterminarDisponibilidad(DateTime fechaDesde, DateTime fechaHasta)
        {
            DateTime fechaIni = new DateTime();
            DateTime fechaFin = new DateTime();
            List<Alojamiento> listaAlojActivos = new List<Alojamiento>(); //lista de alojamientos en estado de Alojado o Reservado
            List<Habitacion> listaHabitaciones = new List<Habitacion>(); //GENERAR LISTA DE HABITACION TODAS LIBRE (GET ALL CON REPOSITORY)lista de todas las habitaciones del hotel, solo los HabitacionesID
            //List<Habitacion> listaHabDisponibles = new List<Habitacion>(); //lista de habitaciones con cupos disponibles en esas fechas
            foreach (var hab in listaHabitaciones)
            {
                foreach (var aloj in listaAlojActivos)
                {
                    if (aloj.Habitacion.HabitacionId == hab.HabitacionId) //agregar condicion de exclusividad
                    {
                        if (aloj.Habitacion.Exclusiva == true)
                        {
                            listaHabitaciones.Remove(hab);
                        }
                        else if (aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado)
                        {
                            fechaIni = aloj.FechaIngreso;
                            fechaFin = aloj.FechaEstimadaEgreso;
                        }
                        else if(aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado)
                        {
                            fechaIni = aloj.FechaEstimadaIngreso;
                            fechaFin = aloj.FechaEstimadaEgreso;
                        }

                        if ((DateTime.Compare(fechaDesde,fechaFin)<0) || ((DateTime.Compare(fechaHasta,fechaIni)>1)))
                           //si las fechas son iguales la habitacion estaria desponible full ya que el check out es a las 10
                        {
                            //modificar la habitacion de la lista de acuerdo a su ocupacion actual para luego sacar lo libre
                            //obtenerCantidadCuposDoble()
                            //obtenerCantidadCuposSimples()
                            //determinarExclusividad()
                            //listaHabDisponlibles.Add(hab)
                        }
                    }
                }
            }
            return (listaHabitaciones);
        }
    }
}
