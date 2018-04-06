using System.Collections.Generic;

namespace Dominio
{
	public class AlojHab
	{
		int iAlojId;
		byte iHabiD;
		bool iExclusividad;
		List<Cliente> iClientes = new List<Cliente>();

		public AlojHab() {}

		public AlojHab(bool iExcl)
		{

		}

		public int AlojamientoID { get { return this.iAlojId; }	private set { this.iAlojId = value; } }
		public byte HabitacionID { get { return this.iHabiD; }	private set { this.iHabiD = value; } }
		public bool Exclusividad { get { return this.iExclusividad; }	set { this.iExclusividad = value; } }
		public List<Cliente> Cliente { get { return this.iClientes; }	private set { this.iClientes = value; } }

	}
}
