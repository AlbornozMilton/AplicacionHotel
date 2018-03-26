using System;

namespace Persistencia.Domain
{
    public class Pago
    {
        public int PagoId { get; set; }
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
        Alojado,
        Servicios,
        Deuda
    }
}
