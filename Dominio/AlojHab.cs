using System.Collections.Generic;

namespace Dominio
{
	public class AlojHab
	{
		int iAlojHabId;
		int iAlojId;
		byte iHabId;
		bool iExclusividad;
		List<Cliente> iClientes = new List<Cliente>();

		public AlojHab() {}

		public AlojHab(bool iExcl)
		{
			//something
		}

		public int AlojHabId { get { return this.iAlojHabId; } private set { this.iAlojHabId = value; } }
		public int AlojamientoId { get { return this.iAlojId; }	private set { this.iAlojId = value; } }
		public byte HabitacionId { get { return this.iHabId; }	private set { this.iHabId = value; } }
		public bool Exclusividad { get { return this.iExclusividad; }	set { this.iExclusividad = value; } }
		public List<Cliente> Clientes { get { return this.iClientes; }	private set { this.iClientes = value; } }

	}
}
