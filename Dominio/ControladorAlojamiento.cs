using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;

namespace Dominio
{
    public class ControladorAlojamiento
    {
        Alojamiento lAlojamiento = new Alojamiento((DateTime.Now).AddDays(2));

        public Alojamiento NuevoAlojSinReserva()
        {
            Alojamiento lAlojamiento = new Alojamiento((DateTime.Now).AddDays(2));
            TarifaCliente lTarifaCliente = new TarifaCliente();

            //-------determinar disponibilidad

            
            
            Habitacion lHabitacion = new Habitacion(1, 0, true); //exclusividad en true

            //-------------------------



            // ---------------BUSCAR y Asociar Cliente responsable
            bool op;
            do
            {
                int lDNI = 37115628; //dni desde la interfaz
                Cliente lResponsable = this.BuscarCliente(lDNI);
                op = false;

                if (lResponsable.TipoCliente != TipoCliente.Titular)
                {
                    //obtener el valor de "op" desde la interfaz

                    if (op == true)
                    {
                        lAlojamiento.DniResponsable = lResponsable.Dni;
                        lAlojamiento.AgregarCliente(lResponsable);
                        //op tendra el valor de true, que luego corta el while
                    }

                } else
                {
                    lAlojamiento.DniResponsable = lResponsable.Dni;
                    lAlojamiento.AgregarCliente(lResponsable);
                    op = true;
                    //mostrar en la interfaz
                }

            } while (op == false);
            //////-----------------------


            //----------------------- 

            //obtener cantS y cantD desde la interfaz
            // notificar si las cantidades no son del tipo byte como excepcion
            byte cantS = 2;
            byte cantD = 1;

            do
            {
                op = VerificarCuposIngresados(cantS, cantD, lAlojamiento);
                //notificar mediante interfaz cantidades no corresponden

            } while (op == false);


            //------------------------------------

            Cliente lCliente2 = new Cliente(37000000, "Josefina", "Chamorro", "3456542154", TipoCliente.AcompanianteDirecto);
            Cliente lCliente3 = new Cliente(13123412, "Jaimito", "Chamorro", "3456542154", TipoCliente.AcompanianteNoDirecto);
            Cliente lCliente4 = new Cliente(44134234, "Clara", "Burna", "3456542154", TipoCliente.TitularExceptuado);

            lAlojamiento.AgregarCliente(lCliente2);
            lAlojamiento.AgregarCliente(lCliente3);
            lAlojamiento.AgregarCliente(lCliente4);


            lAlojamiento.Habitacion = lHabitacion;

            lAlojamiento.FechaEstimadaIngreso = DateTime.Now;
            lAlojamiento.FechaEstimadaEgreso = (DateTime.Now).AddDays(2);

            return lAlojamiento;
        }

        public Cliente BuscarCliente(int pDNI)
        {
            // buscar en base de datos - repositorio de clientes ?? -
            return new Cliente(37115628, "Mauricio", "Chamorro", "3456542154", TipoCliente.Titular);
        }

        public double ObteberTarifa(Cliente pCliente, TarifaCliente pTarifa, bool pExclusividad)
        {

            return pTarifa.DeterminarTarifa(pCliente.TipoCliente, pExclusividad);

        }

        public void DeterminarDisponibilidad(DateTime pFechaDesde, DateTime pFechaHasta)
        {
            //fechas obtenidas desde la interfaz
            //hacer un try catch para que la fecha desde esa menor que fecha hasta
            //tambien notificar que ingrese datos obligatorios
            pFechaDesde = DateTime.Now;
            pFechaHasta = (DateTime.Now).AddDays(2);

            List<Habitacion> lHabitacionesDisponibles = new List<Habitacion>();

            List<Alojamiento> lRepoAlojamiento = new List<Alojamiento>(); // obtner como respositorio de alojamientos??



        }

        public bool VerificarCuposIngresados(byte pCantS, byte pCantD, Alojamiento pAlojamiento)
        {
            //verifica si la cantidad de clientes agregados al alojamiento es igual a la cantidad de cupos que ingresó
            return (pAlojamiento.Clientes.LongCount() == pCantS + pCantD * 2);
        }
        
        //en este contexto, para registrar el pago de cierre se debe verificar que no presente deuda
        // siempre se va a registrar un pago monto total aunque no se hallan consumido servicios, el pMonto = pMontoTotal 
        public void CierreAlojamiento()
        {
            if (this.lAlojamiento.EstadoAloj == EstadoAlojamiento.Alojado)
            {
                if (this.lAlojamiento.MontoDeuda == 0)
                {
                    this.lAlojamiento.FechaEgreso = DateTime.Now;
                    this.lAlojamiento.EstadoAloj = EstadoAlojamiento.Cerrado;

                    //si ya tiene registro de TipoPago = MontoTotal devido al cosnumo de servicios, no se realiza un pago 
                    //si no consumió servivicios se registra un TipoPago = MontoTotal igual al Monto Total
                    if (this.lAlojamiento.TotalServicios() == 0)
                    {
                        this.RegistrarPagoAlojamiento(this.lAlojamiento.MontoTotal, TipoPago.Total, "Alojamiento Cerrado sin Servicios; ");
                        //Esto se debe a que un Alojamiento siempre va a tener los tres tipos de pago
                    }
                }
                else
                {
                    throw new Exception("El alojamiento presenta deuda");//catchear esta excepcion y tratarla para que realice un pago
                }
            }
            else
            {
                throw new Exception("El estado alojamiento no es correspondinte para el cierre");
            }

        } 
          
        // BUSCAR ALOJAMIENTO

        //para ejecutar este metodo se tiene que controlar que los pagos se realicen en el contexto corresponidente MEDIANTE ESTADO DE ALOJAMIENTO
        //por ejemplo para realizar pago de deposito, EL ESTADO DEBE SER RESERVADO; se puede hacer un pago total solo cuando se este por cerrar un alojamiento; entre otras 
        //pMonto es distindo de null y mayor que cero (flujos de excepcion)
        /// <summary>
        /// Registrar Pago una vez pasado el control de contexto
        /// </summary>
        public void RegistrarPagoAlojamiento(double pMonto, TipoPago pTipoPago, string pDetalle)
        {
            if (!(this.ExistePago(pTipoPago)))
            {
                switch (pTipoPago)
                {
                    case TipoPago.Deposito: //EL MONTO TOTAL ESTA ACTUALIZO Y HASTA ENOTNCES NO SE AGREGARON SERVICIOS
                        if (pMonto == lAlojamiento.Deposito)
                        {
                            lAlojamiento.RegistrarPago(pMonto,pTipoPago,pDetalle);
                        }
                        else
                        {
                            throw new Exception("Monto de Deposito No Correspondiente");
                        }
                        break;
                    case TipoPago.Complemento:
                        if (pMonto == lAlojamiento.MontoDeuda) // LA DEUDA SE ACTUALIZO CUANDO SE HIZO EL DEPOSITO o NOOO se realizo deposito
                        {
                            lAlojamiento.RegistrarPago(pMonto, pTipoPago, pDetalle);
                        }
                        else
                        {
                            throw new Exception("Monto de Complemento Incorrecto");
                        }
                        break;
                    case TipoPago.Total:
                        if (pMonto == lAlojamiento.TotalServicios())
                        {
                            lAlojamiento.RegistrarPago(pMonto, pTipoPago, pDetalle);
                        }
                        else
                        {
                            throw new Exception("Monto de Deposito No Correspondiente");
                        }
                        break;
                }
            }
            else
            {
                throw new Exception("Tipo de Pago Incorrecto");
            }
        }

        /// <summary>
        /// Usado para registrar un Tipo de Pago de un Alojamiento
        /// </summary>
        /// <param name="pTipopago"> Tipo de Pago que se desea registrar sobre el Alojamiento</param>
        /// <returns>Devuelve true si el Tipo de Pago ya existe en el Alojamiento</returns>
        public bool ExistePago(TipoPago pTipopago)
        {
            bool resultado = true;
          //  List<Pago> lPagos = new List<Pago>(lAlojamiento.Pagos);
            foreach (Pago pago in this.lAlojamiento.Pagos)
            {
                if (pago.TipoPago == pTipopago)
                {
                    resultado = false;
                    break;
                }
            }
            return resultado;
        }

    }
}
