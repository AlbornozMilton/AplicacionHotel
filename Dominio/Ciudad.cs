using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ciudad
    {
		private int iId;
        private int iCodPostal;
        private string iNombre;

        public Ciudad()
        {

        }

        //public Ciudad(int pCodPostal, string pNombre)
        //{
        //    this.iCodPostal = pCodPostal;
        //    this.iNombre = pNombre;
        //}

        //---Propiedades
        public int CiudadId { get { return this.iId; } private set { this.iId = value; } }
		public int CodPostal { get { return this.iCodPostal; } private set { this.iCodPostal = value; } }
        public string Nombre { get { return this.iNombre; } private set { this.iNombre = value; } }
    }
}
