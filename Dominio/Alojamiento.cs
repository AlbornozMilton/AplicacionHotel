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

        // Reservar
        public Alojamiento(DateTime pFechaEstIngreso, DateTime pFechaEstEgreso)
        {
            this.iFechaReserva = DateTime.Now;
            this.iFechaEstimadaIngreso = pFechaEstIngreso;
            this.FechaEstimadaEgreso = pFechaEstEgreso;
        }

        // Sin Reservar
        public Alojamiento(DateTime pFechaEstEgreso)
        {
            this.iFechaIngreso = DateTime.Now;
            this.FechaEstimadaEgreso = pFechaEstEgreso;
        }

        //----------------------propiedades----------------------


        public int IdAlojamiento
        {
            get { return this.iIdAlojamiento; }
            set { this.iIdAlojamiento = value; }

        }

        public int DniResponsable
        {
            get { return this.iDniResponsable; }
            set { this.iDniResponsable = value; }

        }

        public DateTime FechaReserva
        {
            get { return this.iFechaReserva; }
            set { this.iFechaReserva = value; }
        }

        public DateTime FechaEstimadaIngreso
        {
            get { return this.iFechaEstimadaIngreso.Date; }
            set { this.iFechaEstimadaIngreso = value; }
        }

        public DateTime FechaEstimadaEgreso
        {
            get { return this.iFechaEstimadaEgreso.Date; }
            set { this.iFechaEstimadaEgreso = value; }
        }

        public DateTime FechaIngreso
        {
            get { return this.iFechaIngreso.Date; }
            set { this.iFechaIngreso = value; }
        }

        public DateTime FechaEgreso
        {
            get { return this.iFechaEgreso.Date; }
            set { this.iFechaEgreso = value; }
        }

        public double MontoTotal
        {
            get { return this.iMontoTotal; }
            set { this.iMontoTotal = value; }

        }

        public double MontoDeuda
        {
            get { return this.iMontoDeuda; }
            set { this.iMontoDeuda = value; }

        }

        public EstadoAlojamiento EstadoAloj
        {
            get { return this.iEstadoAloj; }
            set { this.iEstadoAloj = value; }
        }

        public List<Cliente> Clientes
        {
            get { return this.iClientes; }
            set { this.iClientes = value; }
        }

        public Habitacion Habitacion
        {
            get { return this.iHabitacion; }
            set { this.iHabitacion = value; }
        }

        public List<LineaServicio> Servicios
        {
            get { return this.iServicios; }
            set { this.iServicios = value; }
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

        public double CalcularCostoBase(TarifaCliente pTarifaCliente)
        {
            bool lExclusividad = this.iHabitacion.Exclusiva;

            double costoBase = 0;

            foreach (var item in iClientes)
            {
                costoBase += pTarifaCliente.DeterminarTarifa(item.TipoCliente, lExclusividad);
            }

            if (this.FechaEstimadaIngreso == default (DateTime)) // NO se realizó reserva
            {
                this.MontoDeuda = costoBase * this.FechaEstimadaEgreso.Subtract(this.FechaIngreso).Days;//se usa fechaIngreso
                this.MontoTotal = this.MontoDeuda;
                return this.MontoDeuda; 

            } else
            {
                this.MontoDeuda = costoBase * this.FechaEstimadaEgreso.Subtract(this.FechaEstimadaIngreso).Days; //se usa fechaESTIMADAIngreso
                this.MontoTotal = this.MontoDeuda;
                return this.MontoDeuda;
            }
        }

        public double Deposito
        {
            get { return this.iMontoTotal * 0.5; }
        }

        public void RegistrarPago(double pMonto, TipoPago pTipoPago,string pDetalle)
        {
            this.iMontoDeuda -= pMonto;
            if (this.iMontoDeuda < 0)
            {
                throw new Exception("Monto deuda menor a cero");
            }
            this.iPagos.Add(new Pago(pTipoPago, pMonto, pDetalle));
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