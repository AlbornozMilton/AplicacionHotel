using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Domicilio
    {
        private int iDomicilioId;
        private string iCalle;
        private string iNumCalle;
        private string iNumDepto;
        private string iNumPiso;
        private Ciudad iCiudad;

        public Domicilio(int pDomId, string pCalle, string pNumCalle, string pNumDepto, string pNumPiso, Ciudad pCiudad)
        {
            this.iDomicilioId = pDomId;
            this.iCalle = pCalle;
            this.iNumCalle = pNumCalle;
            this.iNumDepto = pNumDepto;
            this.iNumPiso = pNumPiso;
            this.iCiudad = pCiudad;

        }

        public Domicilio(string pCalle, string pNumCalle, string pNumDepto, string pNumPiso)
        {
            this.iCalle = pCalle;
            this.iNumCalle = pNumCalle;
            this.iNumDepto = pNumDepto;
            this.iNumPiso = pNumPiso;
        }

        //----------------------------------------propiedades
        public int DomicilioId { get { return this.iDomicilioId; } }
        public string Calle { get { return this.iCalle; } }
        public string  Numero { get { return this.iNumCalle; } }
        public string Piso { get { return this.iNumPiso; } }
        public string NroDepto { get { return this.iNumDepto; } }
        public Ciudad Ciudad { get { return this.iCiudad; } }
        //--------------------------------------metodos
        public string Direccion()
        {
            return (this.iCalle +' '+this.iNumCalle);
        }
    }
}
