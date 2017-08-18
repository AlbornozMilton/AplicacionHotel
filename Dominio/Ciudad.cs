using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ciudad
    {
        private int iCodPostal;
        private string iNombre;

        public Ciudad(int pCodPostal, string pNombre)
        {
            this.iCodPostal = pCodPostal;
            this.iNombre = pNombre;
        }

        public int CodPostal { get; }
        public string Nombre { get; }
    }
}
