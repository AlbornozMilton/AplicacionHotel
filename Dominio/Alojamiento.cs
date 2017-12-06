using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /*
     EL VALOR NULL POR DEFECTO DE LA FECHA DATETIME ES "1/1/0001 12:00:00 AM" ....... EJEMPLOS

            Console.WriteLine( new DateTime()); // 1/1/0001 12:00:00 AM
            Console.WriteLine( default(DateTime)); // 1/1/0001 12:00:00 AM
            Console.WriteLine( DateTime.MinValue); // 1/1/0001 12:00:00 AM

            Alojamiento lAlojamiento2 = new Alojamiento(); //se instancian todos los atributos del Alojamiento por null o su default
            Console.WriteLine(lAlojamiento2.FechaEstimadaEgreso); // 1/1/0001 12:00:00 AM
            Console.WriteLine(lAlojamiento2.FechaReserva); // 1/1/0001 12:00:00 AM
    */

    public class Alojamiento
    {
        private List<LineaServicio> iServicios;
        private List<Cliente> iClientes;
        private Habitacion iHabitacion;
        private List<Pago> iPagos;

        private int iIdAlojamiento;
        private int iDniResponsable;
        private double iMontoTotal;
        private double iMontoDeuda;
        private DateTime iFechaReserva;//AGREGAR SIGNO ?
        private DateTime iFechaEstimadaEgreso;//AGREGAR SIGNO ?
        private DateTime iFechaEstimadaIngreso;//AGREGAR SIGNO ?
        private DateTime iFechaIngreso;//AGREGAR SIGNO ?
        private DateTime iFechaEgreso;//AGREGAR SIGNO ?
        private EstadoAlojamiento iEstadoAloj;


        //-----------------------constructores//----------------------
     
        public Alojamiento()
        {

        }

        public Alojamiento(Habitacion unaHab, int unId, int unDni, double unMontoT, EstadoAlojamiento unEstado, DateTime unaFecha)//Arreglar este constructor
        {
            this.iHabitacion = unaHab;
            this.iEstadoAloj = unEstado;
            this.iIdAlojamiento = unId;
            this.iDniResponsable = unDni;
            this.iMontoTotal = unMontoT;
            this.iFechaEgreso = unaFecha;

        }
        
        public Alojamiento (Habitacion unaHab, Cliente unClienteResp, DateTime unaFechaEstimadaIngreso, DateTime unaFechaEstimadaEgreso)
        {
            this.Clientes = new List<Cliente>();
            //Usado cuando se confirma reserva
            this.DniResponsable = unClienteResp.ClienteId;
            this.Habitacion = unaHab;
            this.FechaEstimadaIngreso = unaFechaEstimadaIngreso;
            this.FechaEstimadaEgreso = unaFechaEstimadaEgreso;
            this.Clientes.Add(unClienteResp);
            this.EstadoAlojamiento = EstadoAlojamiento.Reservado;
            this.FechaReserva = DateTime.Now;
        }

        public Alojamiento(DateTime pFechaEstIngreso, DateTime pFechaEstEgreso)
        {
            this.iFechaReserva = DateTime.Now;
            this.iFechaEstimadaIngreso = pFechaEstIngreso;
            this.iFechaEstimadaEgreso = pFechaEstEgreso;
        }

        /// <summary>
        /// Sin Reserva
        /// </summary>
        /// <param name="pFechaEstEgreso"></param>
        public Alojamiento(DateTime pFechaEstEgreso)
        {
            this.iFechaIngreso = DateTime.Now;
            //  this.FechaEstimadaEgreso = pFechaEstEgreso;
        }

        //----------------------PROP----------------------


        public int AlojamientoId
        {
            get { return this.iIdAlojamiento; }
            private set { this.iIdAlojamiento = value; }
        }
        public int DniResponsable
        {
            get { return this.iDniResponsable; }
            private set { this.iDniResponsable = value; }
        }
        public DateTime FechaReserva
        {
            get { return this.iFechaReserva.Date; }
            private set { this.iFechaReserva = value; }
        }
        public DateTime FechaEstimadaIngreso
        {
            get { return this.iFechaEstimadaIngreso.Date; }
            private set { this.iFechaEstimadaIngreso = value; }
        }
        public DateTime FechaEstimadaEgreso
        {
            get { return this.iFechaEstimadaEgreso.Date; }
            private set { this.iFechaEstimadaEgreso = value; }
        }
        public DateTime FechaIngreso
        {
            get { return this.iFechaIngreso.Date; }
            private set { this.iFechaIngreso = value; }
        }
        public DateTime FechaEgreso
        {
            get { return this.iFechaEgreso.Date; }
            private set { this.iFechaEgreso = value; }
        }
        public double MontoTotal
        {
            get { return this.iMontoTotal; }
            private set { this.iMontoTotal = value; }
        }
        public double MontoDeuda
        {
            get { return this.iMontoDeuda; }
            private set { this.iMontoDeuda = value; }
        }

        public double Deposito
        {
            get { return this.iMontoTotal * 0.5; }
        }

        public EstadoAlojamiento EstadoAlojamiento
        {
            get { return this.iEstadoAloj; }
            private set { this.iEstadoAloj = value; }
        }

        public List<Cliente> Clientes
        {
            get { return this.iClientes; }
            private set { this.iClientes = value; }
        }

        public Habitacion Habitacion
        {
            get { return this.iHabitacion; }
            private set { this.iHabitacion = value; }
        }

        public List<LineaServicio> Servicios
        {
            get { return this.iServicios; }
            private set { this.iServicios = value; }
        }

        public List<Pago> Pagos
        {
            get { return this.iPagos; }
            private set { this.iPagos = value; }
        }

        //----------------------métodos----------------------

        public bool ExistePagoAlojamiento(Pago pPago)
        {
            return this.Pagos.Contains(pPago);
        }

        public double CalcularCostoBaseReserva(decimal[] pContadores)
        {
            bool lExclusividad = this.iHabitacion.Exclusiva;
            List<TarifaCliente> Tarifas = new ControladorCliente().DevolverListaTarifas();
            double costoBase = 0;

            for (int i = 0; i < pContadores.Length; i++)
            {
                costoBase += Convert.ToDouble(pContadores[i])*Tarifas[i].DeterminarTarifa(lExclusividad);
            }

            this.MontoDeuda = costoBase * this.FechaEstimadaEgreso.Subtract(this.FechaEstimadaIngreso).Days; //se usa fechaESTIMADAIngreso
            this.MontoTotal = this.MontoDeuda;
            return this.MontoDeuda;
        }

        public void RegistrarPago(Pago pPago) //Ver si se pasa el ID
        {
                this.iMontoDeuda -= pPago.Monto;
                this.iPagos.Add(pPago);
        }

        public double TotalServicios()
        {
            double total = 0;
            foreach (var item in this.iServicios)
            {
                total += item.CostoServicio; // total = total + item.CostoServicio;
            }
            return total;
        }

        public void AgregarCliente(Cliente pCliente)
        {
            this.iClientes.Add(pCliente);
        }


    }
}