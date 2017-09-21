using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    class Domicilio
    {
        public int DomicilioId { get; set; }

        public string Calle { get; set; }

        public int Numero { get; set; }

        public int Piso { get; set; }


    }
}
