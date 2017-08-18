using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Servicio
    {
        private string iNombe;
        private string iDetalle;
        private double iCostoBase;

        //-----------------constructor

        public Servicio(string pNombre, string pDetalle, double pCostoBase)
        {
            this.iNombe = pNombre;
            this.iDetalle = pDetalle;
            this.iCostoBase = pCostoBase;
        }


        //--------------propiedades
        public string Nombre
        {
            get { return this.iNombe; }
            //    set { this.iNombe = value; }
        }

        public string Detalle
        {
            get { return this.iDetalle; }
            //  set { this.iDetalle = value; }
        }

        public double CostoBase
        {
            get { return this.iCostoBase; }
            //set { this.iCostoBase = value; }
        }

    }
}