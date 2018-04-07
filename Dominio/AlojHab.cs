using System.Collections.Generic;

namespace Dominio
{
	public class AlojHab
	{
		int iAlojHabId;
		bool iExclusividad;
		Alojamiento iAloj;
		Habitacion iHab;
		List<TarifaCliente> iTarifas;
		List<Cliente> iClientes = new List<Cliente>();

		public AlojHab() {}

		public AlojHab(bool pExcl, List<TarifaCliente> pTarifas)
		{
			iExclusividad = pExcl;
			iTarifas = pTarifas;
			//something
		}

		public int AlojHabId { get { return this.iAlojHabId; } private set { this.iAlojHabId = value; } }
		public bool Exclusividad { get { return this.iExclusividad; }	set { this.iExclusividad = value; } }
		public Alojamiento Alojamiento { get { return this.iAloj; }	private set { this.iAloj = value; } }
		public Habitacion Habitacion { get { return this.iHab; }	private set { this.iHab = value; } }
		public List<TarifaCliente> Tarifas { get { return this.iTarifas; } private set { this.iTarifas = value; } }
		public List<Cliente> Clientes { get { return this.iClientes; }	private set { this.iClientes = value; } }

	}
}
