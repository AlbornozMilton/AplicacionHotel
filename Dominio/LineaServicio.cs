using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class LineaServicio
    {
        private int iCodLinServicio;
        private byte iCantidad;
        private double iCostoServicio;
        private DateTime iFechaServicio;
        private Servicio iServicio;
        private Alojamiento iAlojamiento;


        //--------------------------Contructor
        public LineaServicio()
        {

        }

        public LineaServicio(byte pCant, Servicio pServicio)
        {
            this.iCantidad = pCant;
            this.iServicio = pServicio;
            this.CalcularCostoServicio();
        }

        //------------------------Propiedades
        public int LineaServicioId { get { return this.iCodLinServicio; } private set { this.iCodLinServicio = value; } }
        public byte Cantidad
        {
            get { return this.iCantidad; }
            private set { this.iCantidad = value; }
        }
        public double CostoServicio
        {
            get { return this.iCostoServicio; }
            private set { this.iCostoServicio = value; }
        }
        public DateTime FechaServicio { get { return this.iFechaServicio; } private set { this.iFechaServicio = value; } }
        public Servicio Servicio
        {
            get { return this.iServicio; }
            private set { this.iServicio = value; }
        }
        public Alojamiento Alojamiento
        {
            get { return this.iAlojamiento; }
            private set { this.iAlojamiento = value; }
        }

        //---------------------------------------------------------
        private void CalcularCostoServicio()
        {
             this.iCostoServicio = this.iCantidad * this.iServicio.CostoBase; 
        }
    }
}