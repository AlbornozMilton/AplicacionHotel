using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    public class LineaServicio
    {
        public int LineaServicioId { get; set; }
        public int Cantidad { get; set; }
        public double CostoServicio { get; set; }
        public DateTime FechaServicio { get; set; }


        public int ServicioId { get; set; }
        public Servicio Servicio { get; set; }

        public int AlojamientoId { get; set; }
        public Alojamiento Alojamiento { get; set; }
    }
}
