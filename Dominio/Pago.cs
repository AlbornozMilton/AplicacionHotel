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

        public Pago(TipoPago pTipoPago, double pMonto, string pDetalle)
        {
            this.iTipoPago = pTipoPago;
            this.iMonto = pMonto;
            this.iDetalle = pDetalle;
            this.iFechaPago = DateTime.Now; //ver como generar la fecha y hora actual del sistema
        }

        public int IdPago { get { return this.iIdPago; } }

        public TipoPago TipoPago { get { return this.iTipoPago; } }

        public double Monto { get { return this.iMonto; } }

        public DateTime Fechapago { get { return this.Fechapago; } } //ver si es necesario la hora

        public string Detalle { get { return this.iDetalle; } }
    }
}
