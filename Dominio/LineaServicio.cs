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
        private int iCantidad;
        private double iCostoServicio;
        private Servicio iServicio;


        //--------------------------Contructor
        public LineaServicio(int pId, int pCant, Servicio pServicio)
        {
            this.iCodLinServicio = pId;
            this.iCantidad = pCant;
            this.iServicio = pServicio;
            this.CalcularCostoServicio();
        }

        //------------------------Propiedades
        public int LineaServicioId { get { return this.iCodLinServicio; } private set { this.iCodLinServicio = value; } }

        public int Cantidad
        {
            get { return this.iCantidad; }
            private set { this.iCantidad = value; }
        }

        public double CostoServicio
        {
            get { return this.iCostoServicio; }
            private set { this.iCostoServicio = value; }
        }

        public Servicio Servicio
        {
            get { return this.iServicio; }
            private set { this.iServicio = value; }
        }
    
        private void CalcularCostoServicio()
        {
             this.iCostoServicio = this.iCantidad * this.iServicio.CostoBase; 
        }
    }
}