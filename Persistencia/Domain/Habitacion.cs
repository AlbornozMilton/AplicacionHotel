using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    public class Habitacion
    {
        public byte HabitacionId { get; set; }//Numero de la Habitacion
        public byte Capacidad { get; set; }
        public byte Planta { get; set; }
        public bool Exclusiva { get; set; }
		public bool Ocupada { get; set; }
		public bool Alta { get; set; }

        public List<Alojamiento> Alojamientos { get; set; }
    }
}
