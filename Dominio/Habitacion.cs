using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
	public class Habitacion
	{
		private byte iNumero;
		private byte iPlanta;
		private byte iCapacidad;
		private bool iExclusiva;
		private bool iOcupada;
		private bool iAlta;

		//CONSTRUCTORES
		public Habitacion()
		{
		}

		public Habitacion(byte pNumero, byte pPlanta, bool pExclusiva, byte pCapacidad, bool pOcupada, bool pAlta)
		{
			this.iNumero = pNumero;
			this.iPlanta = pPlanta;
			this.iCapacidad = pCapacidad;
			this.iExclusiva = pExclusiva;
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
		public bool Exclusiva
		{
			get { return this.iExclusiva; }
			private set { this.iExclusiva = value; }
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

		//---------------------metodos
		public void OcuparHabitacion()
        {
			this.Ocupada = true;
		}

		public void DesocuparHabitacion()
		{
			this.Ocupada = false;
		}

		public void SetExclusividad(bool pExclusividad)
        {
            this.Exclusiva = pExclusividad;
        }

		public void DarDeBaja()
		{
			this.iAlta = false;
		}

		public void DarDeAlta()
		{
			this.iAlta = true;
		}
	}
}