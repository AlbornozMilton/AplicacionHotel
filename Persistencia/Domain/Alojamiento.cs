using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    class Alojamiento
    {
        public int AlojamientoId { get; set; }

        public int DniResponsable { get; set; }

        public DateTime FechaReserva { get; set; }

        public DateTime FechaEstimadaIngreso { get; set; }

        public DateTime FechaEstimadaEgreso { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DateTime FechaEgreso { get; set; }

        public double MontoTotal { get; set; }

        public double MontoDeuda { get; set; }

        public int HabitacionId { get; set; }

        public Habitacion Habitacion {get;set;}

        public EstadoAlojamiento EstadoAlojamiento { get; set; }

        public List<Pago> Pagos { get; set; }

    }
    public enum EstadoAlojamiento
    {
        Reservado,
        Alojado,
        Cerrado,
        Cancelado
    }
}
