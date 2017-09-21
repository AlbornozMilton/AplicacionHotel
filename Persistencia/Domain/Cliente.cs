using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    class Cliente
    {
        public int ClienteId { get; set; } //dni

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Telefono { get; set; }

        public string Correo { get; set; }

        public int AlojamientoId { get; set; }

        public int TipoHuespedId { get; set; }

        public int DomicilioId { get; set; }

        //public Domicilio Domicilio { get; set; }

        //public TipoHuesped TipoHuesped { get; set; }

        public Alojamiento Alojamiento { get; set; }

    }
}
