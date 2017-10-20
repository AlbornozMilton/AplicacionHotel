using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    public class Servicio
    {
        public int ServicioId { get; set; }

        public string Nombre { get; set; }

        public string Detalle { get; set; }

        public double CostoBase { get; set; }
    }
}
