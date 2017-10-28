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
        private List<LineaServicio> iServicios = new List<LineaServicio>();
        private List<Cliente> iClientes = new List<Cliente>();
        private Habitacion iHabitacion;
        private List<Pago> iPagos = new List<Pago>();
        private EstadoAlojamiento iEstadoAloj;

        private int iIdAlojamiento;
        private int iDniResponsable;
        private double iMontoTotal;
        private double iMontoDeuda;
        private DateTime iFechaReserva;
        private DateTime iFechaEstimadaEgreso;
        private DateTime iFechaEstimadaIngreso;
        private DateTime iFechaIngreso;
        private DateTime iFechaEgreso;

        //-----------------------constructores//----------------------
        //
        public Alojamiento()
        {
        }

        public Alojamiento(DateTime pFechaEstIngreso, DateTime pFechaEstEgreso)
        {
            this.iFechaReserva = DateTime.Now;
            this.iFechaEstimadaIngreso = pFechaEstIngreso;
         //   this.FechaEstimadaEgreso = pFechaEstEgreso;
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


        public int IdAlojamiento { get { return this.iIdAlojamiento; } }

        public int DniResponsable { get { return this.iDniResponsable; } }

        public DateTime FechaReserva { get { return this.iFechaReserva; } }

        public DateTime FechaEstimadaIngreso { get { return this.iFechaEstimadaIngreso.Date; } }

        public DateTime FechaEstimadaEgreso { get { return this.iFechaEstimadaEgreso.Date; } }

        public DateTime FechaIngreso { get { return this.iFechaIngreso.Date; } }

        public DateTime FechaEgreso { get { return this.iFechaEgreso.Date; } }

        public double MontoTotal { get { return this.iMontoTotal; } }

        public double MontoDeuda { get { return this.iMontoDeuda; } }

        public EstadoAlojamiento EstadoAlojamiento { get { return this.iEstadoAloj; } }

        public List<Cliente> Clientes
        {
            get { return this.iClientes; }
        }

        public Habitacion Habitacion
        {
            get { return this.iHabitacion; }
        }

        public List<LineaServicio> Servicios
        {
            get { return this.iServicios; }
        }

        public List<Pago> Pagos
        {
            get { return this.iPagos; }
        }

        //----------------------métodos----------------------

        public void ConfirmarReserva()
        {
            this.iFechaIngreso = DateTime.Now;
        }

        //public double CalcularCostoBase(TarifaCliente pTarifaCliente)
        //{
        //    bool lExclusividad = this.iHabitacion.Exclusiva;

        //    double costoBase = 0;

        //    foreach (var item in iClientes)
        //    {
        //        costoBase += pTarifaCliente.DeterminarTarifa(item.TipoCliente, lExclusividad);
        //    }

        //    if (this.FechaEstimadaIngreso == default (DateTime)) // NO se realizó reserva
        //    {
        //        this.MontoDeuda = costoBase * this.FechaEstimadaEgreso.Subtract(this.FechaIngreso).Days;//se usa fechaIngreso
        //        this.MontoTotal = this.MontoDeuda;
        //        return this.MontoDeuda; 

        //    } else
        //    {
        //        this.MontoDeuda = costoBase * this.FechaEstimadaEgreso.Subtract(this.FechaEstimadaIngreso).Days; //se usa fechaESTIMADAIngreso
        //        this.MontoTotal = this.MontoDeuda;
        //        return this.MontoDeuda;
        //    }
        //}

        public double Deposito
        {
            get { return this.iMontoTotal * 0.5; }
        }

        public void RegistrarPago(double pMonto, TipoPago pTipoPago,string pDetalle)
        {
            if ((this.iMontoDeuda -= pMonto) < 0)
            {
                throw new Exception("Monto deuda menor a cero");
            }
            else
            {
                this.iMontoDeuda -= pMonto;
                this.iPagos.Add(new Pago(1,pTipoPago, pMonto, pDetalle,DateTime.Now));
            }
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