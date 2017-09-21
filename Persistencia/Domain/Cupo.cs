using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    class Cupo
    {
        public int CupoId { get; set; }

        public TipoCupo Tipo { get; set; }

        public bool Disponible { get; set; }

        public int HabitacionId { get; set; }

        public Habitacion Habitacion { get; set; }

    }
    public enum TipoCupo
    {
        simple,
        doble
    }
}
