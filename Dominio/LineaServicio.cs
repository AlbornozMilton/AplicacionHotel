using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class LineaServicio
    {
        private int iCantidad;
        private double iCostoServicio;
        private Servicio iServicio;


        //----contructor

        //propiedades

        public int Cantidad
        {
            get { return this.iCantidad; }
            set { this.iCantidad = value; }
        }

        public double CostoServicio
        {
            get { return this.iCostoServicio; }
            set { this.iCostoServicio = this.iCantidad * this.iServicio.CostoBase; }
        }

        public Servicio Servicio
        {
            get { return this.iServicio; }
            set { this.iServicio = value; }
        }

    }
}