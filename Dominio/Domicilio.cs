using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Domicilio
    {
        private string iCalle;
        private string iNumCalle;
        private int iNumDepto;
        private int iNumPiso;
        private Ciudad iCiudad;

        public Domicilio(string pCalle, string pNumCalle, int pNumDepto, int pNumPiso, Ciudad pCiudad)
        {
            this.iCalle = pCalle;
            this.iNumCalle = pNumCalle;
            this.iNumDepto = pNumDepto;
            this.iNumPiso= pNumPiso;
            this.iCiudad = pCiudad;

        }

        //----------------------------------------propiedades

        public int NumDepto { get; }
        public int NumPiso { get; }
        public string Calle { get; }
        public string  NumCalle { get; }

        //--------------------------------------metodos
        public string Direccion()
        {
            return (this.iCalle +' '+this.iNumCalle);
        }
    }
}
