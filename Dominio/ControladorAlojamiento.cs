﻿using AutoMapper;
using Persistencia.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using pers = Persistencia.Domain;

namespace Dominio
{
    public class ControladorAlojamiento
    {
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        public List<Alojamiento> ObtenerAlojamientosActivos() //Devuelve la lista de alojamientos activos mappeandolos de Pers a Dominio
        {
            IEnumerable<pers.Alojamiento> listaEnum = iUoW.RepositorioAlojamiento.GetAllAlojamientosActivos();
            List<Alojamiento> listaAlojamientos = new List<Alojamiento>();
            foreach (var aloj in (listaEnum.ToList<pers.Alojamiento>()))
            {
                listaAlojamientos.Add(Mapper.Map<pers.Alojamiento, Alojamiento>(aloj));
            }
            return (listaAlojamientos);
        }

        public void RegistrarAloj(Alojamiento pAlojamiento)
        {
            var A = Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento);
            iUoW.RepositorioAlojamiento.Add(A);
        }

        public void RegistrarAltaReserva(Alojamiento pAlojamiento)
        {
            var A = Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento);
            iUoW.RepositorioAlojamiento.AltaReserva(A);
        }

        public Alojamiento BuscarAlojamientoPorID(int unId)
        {
            return (Mapper.Map<pers.Alojamiento, Alojamiento>(iUoW.RepositorioAlojamiento.Get(unId)));
        }

        public void ControlTipoPago(Alojamiento pAlojamiento, Pago pPago)
        {
            //EL CONTROL PARA EL FORMATO DE MONTO SE LO DEBE REALIZAR EN LA UI
            //CONTROLAR DESDE LA UI QUE EL MONTO SEA MAYOR QUE CERO
            switch (pPago.Tipo)
            {
                case TipoPago.Deposito:
                    {
                        if (pAlojamiento.ExistePagoAlojamiento(pPago))
                        {
                            throw new Exception("El Tipo de Pago ya existe");
                        }
                        else if (pAlojamiento.EstadoAlojamiento != EstadoAlojamiento.Reservado)
                        {
                            throw new Exception("El Tipo de Pago no corresponde con el Estado de Alojamiento");
                        }
                        else if (pPago.Monto != pAlojamiento.Deposito)
                        {
                            throw new Exception("Monto Incorrecto");
                        }
                        pAlojamiento.RegistrarPago(pPago);
                    }
                    break;
                case TipoPago.Alojado:
                    {
                        if (pAlojamiento.ExistePagoAlojamiento(pPago))
                        {
                            throw new Exception("El Tipo de Pago ya existe");
                        }
                        else if (pAlojamiento.EstadoAlojamiento != EstadoAlojamiento.Alojado)
                        {
                            throw new Exception("El Tipo de Pago no corresponde con el Estado de Alojamiento");
                        }
                        else if (pPago.Monto != pAlojamiento.MontoDeuda)
                        {
                            throw new Exception("Monto Incorrecto");
                        }
                        pAlojamiento.RegistrarPago(pPago);
                    }
                    break;
                case TipoPago.Servicios:
                    {
                        if(pAlojamiento.ExistePagoAlojamiento(pPago))
                        {
                            throw new Exception("El Tipo de Pago ya existe");
                        }
                        else if (pAlojamiento.EstadoAlojamiento != EstadoAlojamiento.Cerrado)
                        {
                            throw new Exception("El Tipo de Pago no corresponde con el Estado de Alojamiento");
                        }
                        else if (pPago.Monto > pAlojamiento.MontoDeuda)
                        {
                            throw new Exception("Monto Incorrecto");
                        }
                        pAlojamiento.RegistrarPago(pPago);
                    }
                    break;
                case TipoPago.Deuda:
                    {
                        if (pAlojamiento.ExistePagoAlojamiento(pPago))
                        {
                            throw new Exception("El Tipo de Pago elegido ya existe");
                        }
                        else if (pAlojamiento.EstadoAlojamiento != EstadoAlojamiento.Cerrado)
                        {
                            throw new Exception("El Tipo de Pago elegido no corresponde con el Estado de Alojamiento");
                        }
                        else if (pAlojamiento.ExistePagoAlojamiento(new Pago(TipoPago.Servicios, pPago.Monto, "")))
                        {
                            throw new Exception("El Tipo de Pago elegido requiere un Pago de Servicios");
                        }
                        else if (pPago.Monto != pAlojamiento.MontoDeuda)
                        {
                            throw new Exception("Monto Incorrecto");
                        }
                        pAlojamiento.RegistrarPago(pPago);
                    }
                    break;
            }
        }

        public List<Habitacion> DeterminarDisponibilidad(DateTime fechaDesde, DateTime fechaHasta)
        {
            //ControladorHabitacion iControladorHab = new ControladorHabitacion();
            DateTime fechaIni = new DateTime();
            DateTime fechaFin = new DateTime();
            List<Alojamiento> listaAlojActivos = ObtenerAlojamientosActivos(); //METODO DEFINIDO EN REPOSITORIO ALOJAMIENTO -> lista de alojamientos en estado de Alojado o Reservado
            List<Habitacion> listaHabitaciones = new ControladorHabitacion().ObtenerHabitacionesFullLibres(); //GENERAR LISTA DE HABITACION TODAS LIBRE (GET ALL CON REPOSITORY)lista de todas las habitaciones del hotel, solo los HabitacionesID
            foreach (var hab in listaHabitaciones.ToList<Habitacion>())
            {
                foreach (var aloj in listaAlojActivos)
                {
                    if (aloj.Habitacion.HabitacionId == hab.HabitacionId)
                    {
                        if (aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado)
                        {
                            fechaIni = aloj.FechaIngreso.Date;
                            fechaFin = aloj.FechaEstimadaEgreso.Date;
                            if (((DateTime.Compare(fechaDesde.Date, fechaFin) < 0) && (DateTime.Compare(fechaDesde.Date, fechaIni) >= 0)) ||
                                ((DateTime.Compare(fechaHasta.Date, fechaFin) < 0) && (DateTime.Compare(fechaHasta.Date, fechaIni) > 0)))
                            //si las fechas son iguales la habitacion estaria desponible full ya que el check out es a las 10, 
                            //por eso solo se pone < o > segun corresponda
                            {
                                if (aloj.Habitacion.Exclusiva == true || aloj.Habitacion.Capacidad() == 0)
                                {
                                    listaHabitaciones.Remove(hab);
                                }
                                else
                                {
                                    listaHabitaciones.Remove(hab);
                                    listaHabitaciones.Add(aloj.Habitacion); 
                                }
                            }
                        }
                        else if (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado)
                        {
                            fechaIni = aloj.FechaEstimadaIngreso.Date;
                            fechaFin = aloj.FechaEstimadaEgreso.Date;
                            if (((DateTime.Compare(fechaDesde.Date, fechaFin) < 0) && (DateTime.Compare(fechaDesde.Date, fechaIni) >= 0)) ||
                                ((DateTime.Compare(fechaHasta.Date, fechaFin) < 0) && (DateTime.Compare(fechaHasta.Date, fechaIni) > 0)))
                            //si las fechas son iguales la habitacion estaria desponible full ya que el check out es a las 10, 
                            //por eso solo se pone < o > segun corresponda
                            {
                                if (aloj.Exclusividad == true || aloj.Habitacion.Capacidad() == 0)
                                {
                                    listaHabitaciones.Remove(hab);
                                }
                                else
                                {
                                    listaHabitaciones.Remove(hab);
                                    hab.OcuparCupos(aloj.CantCuposSimples, aloj.CantCuposDobles);
                                    listaHabitaciones.Add(hab);
                                }
                            }
                        }
                    }
                }
            }
            return (listaHabitaciones);
        }

        public void AddPago(Alojamiento pAlojamiento)
        {
            var e = Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento);
            iUoW.RepositorioAlojamiento.AddPago(e,e.Pagos[0]);
        }

        public void AgregarServicio (string pServicio, byte pCant, Alojamiento pAlojamiento)
        {
            Servicio unServicio = Mapper.Map<pers.Servicio, Servicio>(iUoW.RepositorioServicio.GetByNombre(pServicio));
            LineaServicio nuevaLineaServicio = new LineaServicio(pCant, unServicio);
            pAlojamiento.AgregarLineaServicio(nuevaLineaServicio);
            iUoW.RepositorioAlojamiento.AddLineaServicio(Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento), Mapper.Map<LineaServicio, pers.LineaServicio>(nuevaLineaServicio));
        }

        /// <summary>
        /// Para que se realice este método el Alojamiento debe tener un Pago Alojado (Realizar control en UI)
        /// </summary>
        public void CerrarAlojamiento(Alojamiento pAlojamiento, DateTime pFechaEgreso)
        {
            if (!pAlojamiento.Pagos.Exists(p => p.Tipo == TipoPago.Alojado))
            {
                throw new Exception("Se debe realizar un Pago de Alojado antes de Cerrar el Alojamiento");
            }
            else if (!(pAlojamiento.EstadoAlojamiento == EstadoAlojamiento.Alojado))
            {
                throw new Exception("Operacion Cancelada. Solo se puede Cerrar un Alojamiento que esta Alojado");
            }

            //Siempre se va a colocar en "false" la exclusividad
            pAlojamiento.Habitacion.SetExclusividad(false);

            //para la BD
            pAlojamiento.Habitacion.DesocuparCupos(pAlojamiento.CantCuposSimples,pAlojamiento.CantCuposDobles);

            //registrar fecha de egreso y cambia el Estado del Alojamiento a Cerrado
            pAlojamiento.Cerrar(pFechaEgreso);

            iUoW.RepositorioAlojamiento.FinalizarAlojamiento(Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento));
        }

        public void CancelarAlojamiento(Alojamiento pAlojamiento, DateTime pFechaCancelacion)
        {
            //EL PAGO DE DEPOSITO NO SE REMUNERA EN CASO DE CANCELAR Y HABER REALIZADO UN DEPOSITO
            //if (!pAlojamiento.Pagos.Exists(p => p.Tipo == TipoPago.Alojado))
            //{
            //    throw new Exception("Se debe realizar un Pago de Alojado antes de Cerrar el Alojamiento");
            //}
            if (!(pAlojamiento.EstadoAlojamiento == EstadoAlojamiento.Reservado))
            {
                throw new Exception("Operacion Cancelada. Solo se puede Cancelar un Alojamiento que esta Reservado");
            }

            //registra fecha de cancelacion y cambia el Estado del Alojamiento a Cancelado
            pAlojamiento.Cerrar(pFechaCancelacion);

            iUoW.RepositorioAlojamiento.FinalizarAlojamiento(Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento));
        }

        public void ComprobarClientesAltaConReserva(Alojamiento pAlojEnAlta, string pCostoBase)
        {
            var auxClientesAloj = pAlojEnAlta.Clientes.OrderBy(t => t.TarifaCliente.TarifaClienteId).ToList();
            string pContadores = pAlojEnAlta.ContadoresTarifas;

            for (int i = 0; i < auxClientesAloj.Count; i++)
            {
                byte aux = Convert.ToByte(pContadores[i]);

                while (aux > Convert.ToByte('0'))
                {
                    if (Convert.ToInt32(auxClientesAloj[i].TarifaCliente.TarifaClienteId) != i)
                    {
                        throw new Exception("Error de Tipos Cliente");
                    }
                    aux--;
                }
            }

            pAlojEnAlta.AltaDeReserva();

            pAlojEnAlta.CalcularCostoBase(new List<TarifaCliente>());

            if (pAlojEnAlta.MontoTotal.ToString() != pCostoBase)
            {
                throw new Exception("Costo base incorrecto.");
            }
        }
       
        public void ControlInicioAltaReserva(Alojamiento pAloj)
        {
            if (pAloj.EstadoAlojamiento != EstadoAlojamiento.Reservado)
            {
                throw new Exception("El Alojamiento seleccionado debe estar en estado Reservado solamente. Vea los detalles.");
            }

            if (pAloj.FechaEstimadaIngreso.Date.CompareTo(DateTime.Now.Date) != 0)
            {
                throw new Exception("La Fecha Estimada de Ingreso de la Reserva que quiere dar de Alta, no coincide con la Fecha Actual. Vea los detalles.");
            }
        }

        public void ControlPlazoRereva(DateTime pFechaEstimadaIngreso)
        {
            if (pFechaEstimadaIngreso.Subtract(DateTime.Now.Date).Days > 30)
            {
                throw new Exception("Solo se puede realizar Reservas dentro de los 30 Días respecto la Fecha Estimada Ingreso.");
            }
        }

        /// <summary>
        /// Devulve una Lista de Alojamientos Reservados que pasaron 72hs sin realizar depósito
        /// </summary>
        public List<Alojamiento> AlojReservadosSinDepositoVencidos()
        {
            List <Alojamiento> auxLista = this.ObtenerAlojamientosActivos();
            List<Alojamiento> ListaResultado = new List<Alojamiento>();
            foreach (var aloj in auxLista)
            {
                if (aloj.EstadoAlojamiento == EstadoAlojamiento.Reservado)
                {
                    if (
                        (DateTime.Now.Date.Subtract(aloj.FechaReserva.Date).Ticks >= (TimeSpan.TicksPerHour * 72))
                        &
                        (aloj.Pagos.Find(p => p.Tipo == TipoPago.Deposito) == null)//no existe pago de deposito
                        )
                    {
                        ListaResultado.Add(aloj);
                    }
                }
            }
            return ListaResultado;
        }

        /// <summary>
        /// Determina si aún no se a superado capacidad de exlcusividad total en cuanto a un porcentaje determinado.
        /// El cálulo es una estimación basado en fechas límites.
        /// Si aún se permite exclusividad, se admite exclusividad aunque los nuevos cupos sobrepasen la exclusivdad por unas pocas unidades.
        /// </summary>
        /// <param name="pFechaDesde">Fecha Inicial que compara con cada Alojamiento Activo</param>
        /// <param name="pFechaHasta">Fecha Final la que compara con cada Alojamiento Activo</param>
        /// <param name="pPorcentaje">Porcentaje de la capacidad límite de exlcusividad para el total del Hotel</param>
        /// <returns>Retorna verdadero si ya se ha superado la exclusividad límite</returns>

        public bool ExclusividadSegunCapacidad(DateTime pFechaDesde, DateTime pFechaHasta, int pPorcentaje)
        {
            int auxCapacidadTotal = 0;
            List <Habitacion> Habitaciones = new ControladorHabitacion().ObtenerHabitacionesFullLibres();

            foreach (var hab in Habitaciones)
            {
                auxCapacidadTotal += hab.Capacidad();
            }

            //acumulará la cantidad de cupos que estan exlcusivos
            int auxCantExclusiva = 0;

            List<Alojamiento> auxLista = this.ObtenerAlojamientosActivos();

            foreach (var aloj in auxLista)
            {
                if (aloj.Exclusividad)
                {
                    DateTime alojFechaDesde = DateTime.Now; 
                    //no importa el Now, solo para instanciar
                    //la cantidad exclusiva se acumula tanto si es alojado o reservado, ya que solo importan para esas fechas parametro
                    //se acumula cuando para cada aloj sus fechas intersectan con las fechas de parametros

                    if (aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado)
                    {
                        alojFechaDesde = aloj.FechaIngreso.Date;
                    }
                    else
                    {
                        alojFechaDesde = aloj.FechaEstimadaIngreso.Date;
                    }

                    // Hay interseccion entre las fechas
                    if ( 
                            //si fecha de ingreso del aloj se encuetra entre las fechas de parametro
                            (alojFechaDesde.CompareTo(pFechaDesde.Date) >= 0 && alojFechaDesde.CompareTo(pFechaHasta.Date) <= 0) 
                            |
                            //si fecha de egreso del aloj se encuetra entre las fechas de parametro
                            (aloj.FechaEstimadaEgreso.Date.CompareTo(pFechaDesde.Date) >= 0 && aloj.FechaEstimadaEgreso.Date.CompareTo(pFechaHasta.Date) <= 0)
                       )
                    {
                        auxCantExclusiva += aloj.CantCuposSimples + (aloj.CantCuposDobles * 2);
                    } 
                }
            }

            return auxCantExclusiva < ((auxCapacidadTotal * pPorcentaje) / 100);
        }
    }
}
