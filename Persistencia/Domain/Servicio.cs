using System.Collections.Generic;

namespace Persistencia.Domain
{
    public class Servicio
    {
        public byte ServicioId { get; set; }

        public string Nombre { get; set; }

        public string Detalle { get; set; }

        public double CostoBase { get; set; }

        public List<LineaServicio> Servicios { get; set; }
    }
}
