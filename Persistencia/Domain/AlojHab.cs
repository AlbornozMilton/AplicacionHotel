using System.Collections.Generic;

namespace Persistencia.Domain
{
	public class AlojHab
	{
		public int AlojHabId { get; set; }
		public int AlojamientoId { get; set; }
		public byte HabitacionId { get; set; }
		public bool Exclusividad { get; set; }

		public List<Cliente> Clientes { get; set; }
	}
}
