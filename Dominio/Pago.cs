using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pago
    {
        private int iCodPago;
        private TipoPago iTipoPago;
        private double iMonto;
        private DateTime iFechaPago;
        private string iDetalle;
        private Alojamiento iAlojamiento;

        public Pago()
        {

        }

        public Pago(int pCodPago, TipoPago pTipoPago, double pMonto, string pDetalle, DateTime pFechaPago)
        {
            this.iCodPago = pCodPago;
            this.iTipoPago = pTipoPago;
            this.iMonto = pMonto;
            this.iDetalle = pDetalle;
            this.iFechaPago = pFechaPago; 
        }

        //-----------------------Propiedades
        public int PagoId { get { return this.iCodPago; } private set { this.iCodPago = value; } }
        public TipoPago Tipo { get { return this.iTipoPago; } private set { this.iTipoPago = value; } }
        public double Monto { get { return this.iMonto; } private set { this.iMonto = value; } }
        public DateTime FechaPago { get { return this.iFechaPago; } private set { this.iFechaPago = value; } } //ver si es necesario la hora
        public string Detalle { get { return this.iDetalle; } private set { this.iDetalle = value; } }
        public Alojamiento Alojamiento { get { return this.iAlojamiento; } private set { this.iAlojamiento = value; } }

        /// <summary>
        /// Nuevo o Actualiza el campo Detalle
        /// </summary>
        public void AgregarDetalle(string pDetalle)
        {
            this.iDetalle = pDetalle;
        }
    }
}
