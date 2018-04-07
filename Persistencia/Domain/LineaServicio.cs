using System;

namespace Persistencia.Domain
{
    public class LineaServicio
    {
        public int LineaServicioId { get; set; }
        public byte Cantidad { get; set; }
        public double CostoServicio { get; set; }
        public DateTime FechaServicio { get; set; }

        public byte ServicioId { get; set; }
        public Servicio Servicio { get; set; }

        public int AlojamientoId { get; set; }
        public Alojamiento Alojamiento { get; set; }
    }
}
