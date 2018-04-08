using System.Collections.Generic;

namespace Persistencia.Domain
{
	public class AlojHab
	{
		public int AlojHabId { get; set; }
		public bool Exclusividad { get; set; }

		public int AlojamientoId { get; set; }
		public Alojamiento Alojamiento { get; set; }

		public byte HabitacionId { get; set; }
		public Habitacion Habitacion { get; set; }

		public List<TarifaCliente> Tarifas { get; set; }
		public List<Cliente> Clientes { get; set; }
	}
}
