using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Servicio
    {
        private int iCodServicio;
        private string iNombe;
        private string iDetalle;
        private double iCostoBase;

        //-----------------constructor

        public Servicio(int pCodServicio, string pNombre, string pDetalle, double pCostoBase)
        {
            this.iCodServicio = pCodServicio;
            this.iNombe = pNombre;
            this.iDetalle = pDetalle;
            this.iCostoBase = pCostoBase;
        }

        //--------------propiedades
        public int ServicioId { get { return this.iCodServicio; } }

        public string Nombre
        {
            get { return this.iNombe; }
        }

        public string Detalle
        {
            get { return this.iDetalle; }
        }

        public double CostoBase
        {
            get { return this.iCostoBase; }
        }

        //--------------------Metodos
        public void ColocarDetalle(string pDetalle)
        {
            this.iDetalle = pDetalle;
        }
    }
}