using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pago
    {
        private int iIdPago;
        private TipoPago iTipoPago;
        private double iMonto;
        private DateTime iFechaPago;
        private string iDetalle;

        public Pago(int pIdPago, TipoPago pTipoPago, double pMonto, string pDetalle)
        {
            this.iIdPago = pIdPago; //ver el idPago autoamtico
            this.iTipoPago = pTipoPago;
            this.iMonto = pMonto;
            this.iDetalle = pDetalle;
            this.iFechaPago = new DateTime(); //ver como generar la fecha y hora actual del sistema
        }

        public int IdPago { get;}

        public TipoPago TipoPago { get; }

        public double Monto { get; }

        public DateTime Fechapago { get { return this.Fechapago.Date; } } //ver si es necesario la hora

        public string Detalle { get; }
    }
}
