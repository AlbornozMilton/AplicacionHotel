using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
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
        public byte iCantCuposSimples;
        public byte iCantCuposDobles;
        public bool iExclusividad;
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
        /// <summary>
        /// Contructor para el Alta Reserva Alojamiento
        /// </summary>
        public Alojamiento(Habitacion unaHab, Cliente unClienteResp, DateTime unaFechaEstimadaIngreso, DateTime unaFechaEstimadaEgreso, byte cantCuposSimples, byte cantCuposDobles, bool ck_Exclusividad)
        {
            this.Clientes = new List<Cliente>();
            this.DniResponsable = unClienteResp.ClienteId;
            this.Habitacion = unaHab;
            this.FechaEstimadaIngreso = unaFechaEstimadaIngreso;
            this.FechaEstimadaEgreso = unaFechaEstimadaEgreso;
            this.CantCuposSimples = cantCuposSimples;
            this.CantCuposDobles = cantCuposDobles;
            this.Exclusividad = ck_Exclusividad;
            this.Clientes.Add(unClienteResp);
            this.EstadoAlojamiento = EstadoAlojamiento.Reservado;
            this.FechaReserva = DateTime.Now;
        }
        /// <summary>
        /// Contructor para el Alta Alojamiento sin Reserva
        /// </summary>
        public Alojamiento(Habitacion unaHab, Cliente unClienteResp, List<Cliente> listaAcompañantes, DateTime unaFechaIngreso, DateTime unaFechaEstimadaEgreso, byte cantCuposSimples, byte cantCuposDobles, bool ck_Exclusividad)
        {
            this.Clientes = new List<Cliente>();
            this.DniResponsable = unClienteResp.ClienteId;
            this.Habitacion = unaHab;
            this.FechaIngreso = unaFechaIngreso;
            this.FechaEstimadaEgreso = unaFechaEstimadaEgreso;
            this.CantCuposSimples = cantCuposSimples;
            this.CantCuposDobles = cantCuposDobles;
            this.Exclusividad = ck_Exclusividad;
            this.Clientes.Add(unClienteResp);
            foreach (var cli in listaAcompañantes)
            {
                Clientes.Add(cli);
            }
            this.EstadoAlojamiento = EstadoAlojamiento.Alojado;
            this.FechaReserva = DateTime.Now;
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
            get { return this.iMontoDeuda * 0.5; }
        }

        public byte CantCuposSimples
        {
            get { return this.iCantCuposSimples; }
            private set { this.iCantCuposSimples = value; }
        }

        public byte CantCuposDobles
        {
            get { return this.iCantCuposDobles; }
            private set { this.iCantCuposDobles = value; }
        }

        public bool Exclusividad
        {
            get { return this.iExclusividad; }
            private set { this.iExclusividad = value; }
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

        public int HabitacionId
        {
            get { return this.iHabitacion.HabitacionId; }
           // private set { this.iHabitacion. = value; }
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

        //----------------------METHODS----------------------

        public bool ExistePagoAlojamiento(Pago pPago)
        {
            return this.Pagos.Contains(pPago);
        }

        /// <summary>
        /// Calcular Costo Base de un Alojamiento en momentos de Reserva
        /// </summary>
        /// <param name="pContadores">Contadores obtenidos desde la UI</param>
        public double CalcularCostoBase(decimal[] pContadores)
        {
            //bool lExclusividad = this.iHabitacion.Exclusiva;
            List<TarifaCliente> Tarifas = new ControladorCliente().DevolverListaTarifas();
            double costoBase = 0;

            for (int i = 0; i < pContadores.Length; i++)
            {
                costoBase += Convert.ToDouble(pContadores[i])*Tarifas[i].DeterminarTarifa(this.iHabitacion.Exclusiva);
            }

            this.MontoDeuda = costoBase * this.FechaEstimadaEgreso.Subtract(this.FechaEstimadaIngreso).Days; //se usa fechaESTIMADAIngreso
            this.MontoTotal = this.MontoDeuda;
            return this.MontoDeuda;
        }

        /// <summary>
        /// Calcular Costo Base de un Alojamiento en momentos de Alta sin Reserva
        /// </summary>
        public double CalcularCostoBase()
        {
            //bool lExclusividad = this.iHabitacion.Exclusiva;
            //List<TarifaCliente> Tarifas = new ControladorCliente().DevolverListaTarifas();
            double costoBase = 0;
            foreach (var cliente in this.Clientes)
            {
                costoBase += cliente.ObtenerSuPrecioTarifa(this.iHabitacion.Exclusiva);
            }

            //se utiliza FechaEstimadaEgreso y FechaIngreso
            this.MontoDeuda = costoBase * this.FechaEstimadaEgreso.Subtract(this.FechaIngreso).Days; 
            this.MontoTotal = this.MontoDeuda;
            return this.MontoDeuda;
        }
        public void RegistrarPago(Pago pPago) //Ver si se pasa el ID
        {
            this.iMontoDeuda -= pPago.Monto;

            //PARA EL CASO EN EL QUE SE AGREGA UN PRIMER PAGO
            if (this.Pagos!=null)
            {
                this.iPagos.Add(pPago);
            }
            else
            {
                this.Pagos = new List<Pago>() { pPago };
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

        /// <summary>
        /// Agrega una linea servicio y actualiza sus montos
        /// </summary>
        public void AgregarLineaServicio(LineaServicio pLineaServicio)
        {
            if (Servicios.Count == 0)
            {
                Servicios = new List<LineaServicio>() { pLineaServicio };
            }
            else
            {
                Servicios.Add(pLineaServicio);
            }

            MontoTotal += pLineaServicio.CostoServicio;
            MontoDeuda += pLineaServicio.CostoServicio;
        }

        /// <summary>
        /// Asinga la fecha parámetro como Fecha de Egreso y cambia el Estado Alojamiento a Cerrado
        /// </summary>
        public void Cerrar(DateTime pFechaEgreso)
        {
            this.FechaEgreso = pFechaEgreso;
            this.iEstadoAloj = EstadoAlojamiento.Cerrado;
        }


    }
}