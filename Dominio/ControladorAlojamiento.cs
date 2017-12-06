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
            var e = Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento);
                iUoW.RepositorioAlojamiento.AddReserva(e);
            iUoW.Complete();
            iUoW.Dispose();
        }

        public Alojamiento BuscarAlojamientoPorID(int unId)
        {
            return (Mapper.Map<pers.Alojamiento, Alojamiento>(iUoW.RepositorioAlojamiento.Get(unId)));
        }

        public bool ControlTipoPago(Alojamiento pAlojamiento, Pago pPago)
        {
            //EL CONTROL PARA EL FORMATO DE MONTO SE LO DEBE REALIZAR EN LA UI
            //CONTROLAR DESDE LA UI QUE EL MONTO SEA MAYOR QUE CERO

            switch (pPago.Tipo)
            {
                case TipoPago.Deposito:
                    {
                        if (pAlojamiento.EstadoAlojamiento != EstadoAlojamiento.Reservado)
                        {
                            throw new Exception("El Tipo de Pago no corresponde con el Estado de Alojamiento");
                        }
                        else if (pAlojamiento.ExistePagoAlojamiento(pPago))
                        {
                            throw new Exception("El Tipo de Pago ya existe");
                        }
                        else if (pPago.Monto != pAlojamiento.Deposito)
                        {
                            throw new Exception("Monto Incorrecto");
                        }

                        pAlojamiento.RegistrarPago(pPago);
                        //Agregar metodo al repositorio "AddPago"(pAlojamiento)
                        var e = Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento);
                        iUoW.RepositorioAlojamiento.AddPago(e);
                        iUoW.Complete();
                        iUoW.Dispose();
                    }
                    break;
                case TipoPago.Alojado:
                    {
                        if (pAlojamiento.EstadoAlojamiento != EstadoAlojamiento.Alojado)
                        {
                            throw new Exception("El Tipo de Pago no corresponde con el Estado de Alojamiento");
                        }
                        else if (pAlojamiento.ExistePagoAlojamiento(pPago))
                        {
                            throw new Exception("El Tipo de Pago ya existe");
                        }
                        else if (pPago.Monto != pAlojamiento.MontoDeuda)
                        {
                            throw new Exception("Monto Incorrecto");
                        }

                        pAlojamiento.RegistrarPago(pPago);
                        //Agregar metodo al repositorio "AddPago"(pAlojamiento)
                        var e = Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento);
                        iUoW.RepositorioAlojamiento.AddPago(e);
                        iUoW.Complete();
                        iUoW.Dispose();
                    }
                    break;
                case TipoPago.Servicios:
                    {
                        if (pAlojamiento.EstadoAlojamiento != EstadoAlojamiento.Cerrado)
                        {
                            throw new Exception("El Tipo de Pago no corresponde con el Estado de Alojamiento");
                        }
                        else if (pAlojamiento.ExistePagoAlojamiento(pPago))
                        {
                            throw new Exception("El Tipo de Pago ya existe");
                        }
                        else if (pPago.Monto > pAlojamiento.MontoDeuda)
                        {
                            throw new Exception("Monto Incorrecto");
                        }

                        pAlojamiento.RegistrarPago(pPago);
                        //Agregar metodo al repositorio "AddPago"(pAlojamiento)
                        var e = Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento);
                        iUoW.RepositorioAlojamiento.AddPago(e);
                        iUoW.Complete();
                        iUoW.Dispose();
                    }
                    break;
                case TipoPago.Deuda:
                    {
                        if (pAlojamiento.EstadoAlojamiento != EstadoAlojamiento.Cerrado)
                        {
                            throw new Exception("El Tipo de Pago elegido no corresponde con el Estado de Alojamiento");
                        }
                        else if (pAlojamiento.ExistePagoAlojamiento(pPago))
                        {
                            throw new Exception("El Tipo de Pago elegido ya existe");
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
                        //Agregar metodo al repositorio "AddPago"(pAlojamiento)
                        var e = Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento);
                        iUoW.RepositorioAlojamiento.AddPago(e);
                        iUoW.Complete();
                        iUoW.Dispose();
                    }
                    break;
            }
            return true;
        }
    }
}
