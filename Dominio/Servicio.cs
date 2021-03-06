﻿namespace Dominio
{
    public class Servicio
    {
        private byte iCodServicio;
        private string iNombe;
        private string iDetalle;
        private double iCostoBase;

        //-----------------constructor
        public Servicio()
        {

        }

        public Servicio(string pNombre, string pDetalle, double pCostoBase)
        {
            this.iNombe = pNombre;
            this.iDetalle = pDetalle;
            this.iCostoBase = pCostoBase;
        }

        //--------------propiedades
        public byte ServicioId { get { return this.iCodServicio; } private set { this.iCodServicio = value; }  }

        public string Nombre
        {
            get { return this.iNombe; }
            private set { this.iNombe = value; }
        }

        public string Detalle
        {
            get { return this.iDetalle; }
            private set { this.iDetalle = value; }
        }

        public double CostoBase
        {
            get { return this.iCostoBase; }
            private set { this.iCostoBase = value; }
        }

        //--------------------Metodos
        public void ActualizarDetalle(string pDetalle)
        {
            this.iDetalle = pDetalle;
        }

		public void ActualizarCosto(double pCosto)
		{
			this.iCostoBase = pCosto;
		}
	}
}