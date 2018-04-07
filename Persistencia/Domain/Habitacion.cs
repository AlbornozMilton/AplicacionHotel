using System.Collections.Generic;

namespace Persistencia.Domain
{
    public class Habitacion
    {
        public byte HabitacionId { get; set; }//Numero de la Habitacion
        public byte Capacidad { get; set; }
        public byte Planta { get; set; }
		public bool Ocupada { get; set; }
		public bool Alta { get; set; }

        public List<AlojHab> AlojHabs { get; set; }
    }
}
