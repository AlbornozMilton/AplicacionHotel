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

        public Pago(int pCodPago, TipoPago pTipoPago, double pMonto, string pDetalle, DateTime pFechaPago)
        {
            this.iCodPago = pCodPago;
            this.iTipoPago = pTipoPago;
            this.iMonto = pMonto;
            this.iDetalle = pDetalle;
            this.iFechaPago = pFechaPago; 
        }

        //-----------------------Propiedades
        public int PagoId { get { return this.iCodPago; } }

        public TipoPago TipoPago { get { return this.iTipoPago; } }

        public double Monto { get { return this.iMonto; } }

        public DateTime FechaPago { get { return this.iFechaPago; } } //ver si es necesario la hora

        public string Detalle { get { return this.iDetalle; } }

        /// <summary>
        /// Nuevo o Actualiza el campo Detalle
        /// </summary>
        public void AgregarDetalle(string pDetalle)
        {
            this.iDetalle = pDetalle;
        }
    }
}
