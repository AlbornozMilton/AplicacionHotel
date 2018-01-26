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
        //private List<Domicilio> iDomicilios;

        public Ciudad()
        {

        }

        public Ciudad(int pCodPostal, string pNombre)
        {
            this.iCodPostal = pCodPostal;
            this.iNombre = pNombre;
        }

        //---Propiedades
        public int CiudadId { get { return this.iCodPostal; } private set { this.iCodPostal = value; } }
        public string Nombre { get { return this.iNombre; } private set { this.iNombre = value; } }
    }
}
