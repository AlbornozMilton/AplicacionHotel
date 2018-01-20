using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    public class Cupo
    {
        public byte CupoId { get; set; }
        public TipoCupo Tipo { get; set; }
        public bool Disponible { get; set; }
        public bool Alta { get; set; }

        public byte HabitacionId { get; set; }
        public Habitacion Habitacion { get; set; }

    }
    public enum TipoCupo
    {
        simple,
        doble
    }
}
