using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class ControladorHabitacion
    {
        public List<Habitacion> DeterminarDisponibilidad()
        {
            return (new List<Habitacion> { new Habitacion(2, 4, false) });
        }
    }
}
