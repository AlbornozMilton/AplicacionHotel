using System.Collections.Generic;
namespace Dominio
{
	public class Habitacion: System.IEquatable<Habitacion>
	{
		private byte iNumero;
		private byte iPlanta;
		private byte iCapacidad;
		private bool iOcupada;
		private bool iAlta;
		private List<AlojHab> iAloHabs = new List<AlojHab>();

		//CONSTRUCTORES
		public Habitacion()	{}

		public Habitacion(byte pNumero, byte pPlanta, byte pCapacidad, bool pOcupada, bool pAlta)
		{
			this.iNumero = pNumero;
			this.iPlanta = pPlanta;
			this.iCapacidad = pCapacidad;
			this.iOcupada = pOcupada;
			this.iAlta = pAlta;
		}

		//PROPIEDADES
		public byte HabitacionId
		{
			get { return this.iNumero; }
			private set { this.iNumero = value; }
		}

		public byte Planta
		{
			get { return this.iPlanta; }
			private set { this.iPlanta = value; }
		}

		public byte Capacidad
		{
			get { return this.iCapacidad; }
			private set { this.iCapacidad = value; }
		}

		public bool Ocupada
		{
			get { return this.iOcupada; }
			private set { this.iOcupada = value; }
		}

		public bool Alta
		{
			get { return this.iAlta; }
			private set { this.iAlta = value; }
		}

		public List<AlojHab> AlojHabs { get { return this.iAloHabs; } private set { this.iAloHabs = value; } }

		//---------------------metodos
		public void OcuparHabitacion()
        {
			this.Ocupada = true;
		}

		public void DesocuparHabitacion()
		{
			this.Ocupada = false;
		}

		public void DarDeBaja()
		{
			this.iAlta = false;
		}

		public void DarDeAlta()
		{
			this.iAlta = true;
		}

		public bool Equals(Habitacion other)
		{
			return this.HabitacionId == other.HabitacionId;
		}
	}
}