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
        private List<Pago> iPagos = new List<Pago>();

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
        private string iContadoresTarifas;

        //-----------------------CONSTRUCTORES----------------------
     
        public Alojamiento()
        {

        }

        /// <summary>
        /// Contructor para el Alta Alojamiento sin Reserva
        /// </summary>
        public Alojamiento(Habitacion unaHab, Cliente unClienteResp, List<Cliente> listaAcompañantes, DateTime unaFechaIngreso, DateTime unaFechaEstimadaEgreso, byte cantCuposSimples, byte cantCuposDobles, bool HabExclusividad)
        {
            this.iEstadoAloj = EstadoAlojamiento.Alojado;

            this.iClientes = new List<Cliente>();
            //this.iClientes.Add(unClienteResp);
            this.iDniResponsable = unClienteResp.ClienteId;
            //El cliente responsable ya se encuentra en la lista de acompañantes - Verificar
            foreach (var cli in listaAcompañantes)
            {
                iClientes.Add(cli);
            }

            this.iHabitacion = unaHab;
            this.iFechaIngreso = unaFechaIngreso;
            this.iFechaEstimadaEgreso = unaFechaEstimadaEgreso;
            this.iCantCuposSimples = cantCuposSimples;
            this.iCantCuposDobles = cantCuposDobles;
            this.iExclusividad = HabExclusividad;
        }

        /// <summary>
        /// Contructor para la Reserva de Alojamiento
        /// </summary>
        public Alojamiento(string pContTarifas, Habitacion unaHab, Cliente unClienteResp, DateTime unaFechaEstimadaIngreso, DateTime unaFechaEstimadaEgreso, byte cantCuposSimples, byte cantCuposDobles, bool HabExclusividad)
        {
            this.iEstadoAloj = EstadoAlojamiento.Reservado;
            this.iFechaReserva = DateTime.Now;

            this.iClientes = new List<Cliente>();
            this.iClientes.Add(unClienteResp);
            this.iDniResponsable = unClienteResp.ClienteId;

            this.iHabitacion = unaHab;
            this.iFechaEstimadaIngreso = unaFechaEstimadaIngreso;
            this.iFechaEstimadaEgreso = unaFechaEstimadaEgreso;
            this.iCantCuposSimples = cantCuposSimples;
            this.iCantCuposDobles = cantCuposDobles;
            this.iExclusividad = HabExclusividad;
            this.iContadoresTarifas = pContTarifas;
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

        public string ContadoresTarifas
        {
            get { return this.iContadoresTarifas; }
            private set { this.iContadoresTarifas = value; }
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
        public void AltaDeReserva()
        {
            this.EstadoAlojamiento = EstadoAlojamiento.Alojado;
            this.FechaIngreso = DateTime.Now.Date;
        }

        public bool ExistePagoAlojamiento(Pago pPago)
        {
            return this.iPagos.Contains(pPago);
        }

        public void CalcularCostoBase(List<TarifaCliente> pTarifas)
        {
            //bool lExclusividad = this.iHabitacion.Exclusiva;
            bool lExclusividad = this.iExclusividad;
            double costoBase = 0;
            DateTime auxFechaDesde;

            if (this.iEstadoAloj == EstadoAlojamiento.Alojado)
            {
                auxFechaDesde = this.iFechaIngreso;

                foreach (var cliente in this.Clientes)
                {
                    costoBase += cliente.ObtenerSuPrecioTarifa(lExclusividad);
                }
            }
            else
            {
                auxFechaDesde = this.iFechaEstimadaIngreso;

                for (int i = 0; i < this.iContadoresTarifas.Length; i++)
                {
                    byte aux = Convert.ToByte(this.iContadoresTarifas[i]);

                    while (aux > Convert.ToByte('0'))
                    {
                        costoBase += pTarifas[i].GetTarifa(lExclusividad);
                        aux--;
                    }
                }
            }

            this.iMontoTotal = costoBase * (this.iFechaEstimadaEgreso.Date.Subtract(auxFechaDesde.Date).Days);

            Pago auxPago = this.Pagos.Find(p => p.Tipo == TipoPago.Deposito);
            if (auxPago != null)
            {
                this.iMontoDeuda = this.iMontoTotal - auxPago.Monto;
            }
            else
            {
                this.iMontoDeuda = this.iMontoTotal;
            }
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
            if (iServicios.Count == 0)
            {
                iServicios = new List<LineaServicio>() { pLineaServicio };
            }
            else
            {
                iServicios.Add(pLineaServicio);
            }

            iMontoTotal += pLineaServicio.CostoServicio;
            iMontoDeuda += pLineaServicio.CostoServicio;
        }

        /// <summary>
        /// Asinga la fecha parámetro como Fecha de Egreso y cambia el Estado Alojamiento a Cerrado
        /// </summary>
        public void Cerrar(DateTime pFechaEgreso)
        {
            this.iFechaEgreso = pFechaEgreso.Date;
            this.iEstadoAloj = EstadoAlojamiento.Cerrado;
        }

        public void Cancelar(DateTime pFechaCancelacion)
        {
            //this.iFechaCancelacion = pFechaCancelacion;
            this.iEstadoAloj = EstadoAlojamiento.Cancelado;
        }

        public void SetClientes(List<Cliente> pClientes)
        {
            this.iClientes = pClientes;
        }
    }
}