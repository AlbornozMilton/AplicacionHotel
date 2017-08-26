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

        /*
        //contructor para alojamiento sin reserva
        public Alojamiento(DateTime fechaActual)
        //puede ser que no sea necesario pasarle fecha actual, sino en el mismo constructor inidicar fecha acutal del sistema
        {
            this.iFechaIngreso = fechaActual;
            //this.iFechaIngreso = new DateTime(); //chequear que sea fecha actual 
        } */


        //----------------------propiedades----------------------

        //get EstadoAlojamiento


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

        //----------------------métodos----------------------

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
                return costoBase * this.FechaEstimadaEgreso.Subtract(this.FechaIngreso).Days; //se usa fechaIngreso

            } else
            {
                return costoBase * this.FechaEstimadaEgreso.Subtract(this.FechaEstimadaIngreso).Days; //se usa fechaESTIMADAIngreso
            }
        }

        public void RegistrarPago()
        {

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