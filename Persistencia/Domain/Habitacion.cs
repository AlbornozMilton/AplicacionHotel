using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    class Habitacion
    {
        public int HabitacionId { get; set; }

        public int Capacidad { get; set; }

        public int Planta { get; set; }

        public bool Exclusiva { get; set; }

        public List<Cupo> Cupos { get; set; }

        public List<Alojamiento> Alojamientos { get; set; }



    }
}
