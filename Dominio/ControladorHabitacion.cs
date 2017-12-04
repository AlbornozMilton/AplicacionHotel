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
        public List<Habitacion> DeterminarDisponibilidad(DateTime fechaDesde, DateTime fechaHasta)
        {
            ControladorAlojamiento iControladoAloj = new ControladorAlojamiento(); //Otra forma de hacerlo? instanciar con la UoW?
            DateTime fechaIni = new DateTime();
            DateTime fechaFin = new DateTime();
            List<Alojamiento> listaAlojActivos = iControladoAloj.ObtenerAlojamientosActivos(); //METODO DEFINIDO EN REPOSITORIO ALOJAMIENTO -> lista de alojamientos en estado de Alojado o Reservado
            List<Habitacion> listaHabitaciones = ObtenerHabitacionesFullLibres(); //GENERAR LISTA DE HABITACION TODAS LIBRE (GET ALL CON REPOSITORY)lista de todas las habitaciones del hotel, solo los HabitacionesID
            foreach (var hab in listaHabitaciones.ToList<Habitacion>())
            {
                foreach (var aloj in listaAlojActivos)
                {
                    if (aloj.Habitacion.HabitacionId == hab.HabitacionId)
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
                        else if (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado)
                        {
                            fechaIni = aloj.FechaEstimadaIngreso;
                            fechaFin = aloj.FechaEstimadaEgreso;
                        }

                        if (((DateTime.Compare(fechaDesde, fechaFin) < 0) && (DateTime.Compare(fechaDesde, fechaIni) >= 0)) || 
                            ((DateTime.Compare(fechaHasta, fechaFin) < 0) && (DateTime.Compare(fechaHasta, fechaIni) > 0)))
                        //si las fechas son iguales la habitacion estaria desponible full ya que el check out es a las 10, 
                        //por eso solo se pone < o > segun corresponda
                        {
                            //modificar la habitacion de la lista de acuerdo a su ocupacion actual para luego sacar lo libre
                            //obtenerCantidadCuposDoble()
                            //obtenerCantidadCuposSimples()
                            //determinarExclusividad()
                            //listaHabitaciones.Add(hab)
                            listaHabitaciones.Remove(hab);
                            listaHabitaciones.Add(aloj.Habitacion);
                        }
                    }
                }
            }
            return (listaHabitaciones);
        }
    }
}
