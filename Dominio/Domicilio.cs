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
        private int iNumCalle;
        private int iNumDepto;
        private int iNumPiso;
        private Ciudad iCiudad;

        public Domicilio(string pCalle, int pNumCalle, int pNumDepto, int pNumPiso, Ciudad pCiudad)
        {
            this.iCalle = pCalle;
            this.iNumCalle = pNumCalle;
            this.iNumDepto = pNumDepto;
            this.iNumPiso= pNumPiso;
            this.iCiudad = pCiudad;

        }

        //----------------------------------------propiedades

        public int NumDepto { get { return this.iNumDepto; } }
        public int NumPiso { get { return this.iNumPiso; } }
        public string Calle { get { return this.iCalle; } }
        public int  NumCalle { get { return this.iNumCalle; } }
        public Ciudad Ciudad { get { return this.iCiudad; } }

        //--------------------------------------metodos
        public string Direccion()
        {
            return (this.iCalle +' '+this.iNumCalle.ToString());
        }
    }
}
