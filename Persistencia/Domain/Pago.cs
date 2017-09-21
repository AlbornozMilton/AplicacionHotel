using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    class Pago
    {
        public int PublicId { get; set; }

        public TipoPago Tipo { get; set; }

        public double Monto { get; set; }

        public DateTime FechaPago { get; set; }

        public string Detalle { get; set; }

        public int AlojamientoId { get; set; }

        public Alojamiento Alojamiento { get; set; }
    }
    public enum TipoPago
    {
        Deposito,
        Complemento,
        Total
    }
}
