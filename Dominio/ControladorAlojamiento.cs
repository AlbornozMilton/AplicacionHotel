using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;
using pers = Persistencia.Domain;
using AutoMapper;

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

        public void RegistrarReservaAloj(Alojamiento pAlojamiento)
        {
            var A = Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento);
            iUoW.RepositorioAlojamiento.Add(A);
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
            ControladorHabitacion iControladorHab = new ControladorHabitacion();
            DateTime fechaIni = new DateTime();
            DateTime fechaFin = new DateTime();
            List<Alojamiento> listaAlojActivos = ObtenerAlojamientosActivos(); //METODO DEFINIDO EN REPOSITORIO ALOJAMIENTO -> lista de alojamientos en estado de Alojado o Reservado
            List<Habitacion> listaHabitaciones = iControladorHab.ObtenerHabitacionesFullLibres(); //GENERAR LISTA DE HABITACION TODAS LIBRE (GET ALL CON REPOSITORY)lista de todas las habitaciones del hotel, solo los HabitacionesID
            foreach (var hab in listaHabitaciones.ToList<Habitacion>())
            {
                foreach (var aloj in listaAlojActivos)
                {
                    if (aloj.Habitacion.HabitacionId == hab.HabitacionId)
                    {
                        if (aloj.EstadoAlojamiento == EstadoAlojamiento.Alojado)
                        {
                            fechaIni = aloj.FechaIngreso;
                            fechaFin = aloj.FechaEstimadaEgreso;
                            if (((DateTime.Compare(fechaDesde, fechaFin) < 0) && (DateTime.Compare(fechaDesde, fechaIni) >= 0)) ||
                                ((DateTime.Compare(fechaHasta, fechaFin) < 0) && (DateTime.Compare(fechaHasta, fechaIni) > 0)))
                            //si las fechas son iguales la habitacion estaria desponible full ya que el check out es a las 10, 
                            //por eso solo se pone < o > segun corresponda
                            {
                                if (aloj.Habitacion.Exclusiva == true)
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
                            fechaIni = aloj.FechaEstimadaIngreso;
                            fechaFin = aloj.FechaEstimadaEgreso;
                            if (((DateTime.Compare(fechaDesde, fechaFin) < 0) && (DateTime.Compare(fechaDesde, fechaIni) >= 0)) ||
                                ((DateTime.Compare(fechaHasta, fechaFin) < 0) && (DateTime.Compare(fechaHasta, fechaIni) > 0)))
                            //si las fechas son iguales la habitacion estaria desponible full ya que el check out es a las 10, 
                            //por eso solo se pone < o > segun corresponda
                            {
                                if (aloj.Exclusividad == true)
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

        /// <summary>
        /// Recorre ambas listas y determina si esta correcto los tipos de clientes agregados
        /// </summary>
        /// <param name="pAlojEnAlta"> Alojamiento con Clientes completos</param>
        /// <param name="pClientesReserva">Clientes de la Reserva con Clientes Incompletos (falsos)</param>
        public void ComprobarClientesAltaConReserva(Alojamiento pAlojEnAlta, List<Cliente> pClientesReserva)
        {
            var auxClientesAloj = pAlojEnAlta.Clientes.OrderBy(t => t.TarifaCliente.TarifaClienteId).ToList();
            var auxClientesRes = pClientesReserva.OrderBy(t => t.TarifaCliente.TarifaClienteId).ToList();

            //auxListClientes.OrderBy(t => t.TarifaCliente.TarifaClienteId <= t.TarifaCliente.TarifaClienteId);
            //pClientesReserva.OrderBy(t => t.TarifaCliente.TarifaClienteId <= t.TarifaCliente.TarifaClienteId);

            try
            {
                for (int i = 0; i < auxClientesAloj.Count; i++)
                {
                    if (auxClientesAloj[i].TarifaCliente.TarifaClienteId != auxClientesRes[i].TarifaCliente.TarifaClienteId)
                    {
                        throw new Exception("Los Tipos de Cliente que ingreso no corresponden con los Clientes de la Reserva");
                    }
                }
            }
            catch (IndexOutOfRangeException E)
            {
                throw new Exception("Las cantidades de Clientes agregados no corresponden con la Reserva",E);
            }
        }

        /// <summary>
        /// Genera Clientes vacios solo con Tarifas más el Cliente Responsable
        /// </summary>
        public List<Cliente> GenerarTiposClientesReserva(decimal[] pContadores, Cliente pCliResponsable)
        {
            List<Cliente> lClinestes = new List<Cliente>();

            var tarifas = new ControladorCliente().DevolverListaTarifas();

            bool auxControl = true;
            //pContadores [contador_Titular, contador_Direc, contador_NoDirec, contador_Excep, contador_Conv]

            for (int j = 0; j < pContadores.Length; j++)
            {
                if (pContadores[j] > 0)
                {
                    //descontar una Tarifa de pContadores que referencia al Responsable
                    //se lo debe hacer una sola vez
                    if ((pCliResponsable.TarifaCliente.TarifaClienteId == tarifas[j].TarifaClienteId)&&(auxControl))
                    {
                        lClinestes.Add(pCliResponsable);
                        pContadores[j]--;

                        //para que lo haga una vez en caso de tener mas de un contador para el mismo tipo que el responsable
                        auxControl = false;
                    }

                    while (pContadores[j] > 0)
                    {
                        //la lista de tarifa tiene mismo orden que contadores, por eso se utiliza "j"
                        lClinestes.Add(new Cliente(tarifas[j]));
                        pContadores[j]--;
                    }
                            
                }
            }

            return lClinestes;
        }
    }
}
