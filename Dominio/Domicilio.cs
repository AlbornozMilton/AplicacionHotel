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
        private List<Cliente> iClientes;

        public Domicilio()
        {

        }

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
        public int DomicilioId { get { return this.iDomicilioId; } private set { this.iDomicilioId = value; } }
        public string Calle { get { return this.iCalle; } private set { this.iCalle = value; } }
        public string  Numero { get { return this.iNumCalle; } private set { this.iNumCalle = value; } }
        public string Piso { get { return this.iNumPiso; } private set { this.iNumPiso = value; } }
        public string NroDepto { get { return this.iNumDepto; } private set { this.iNumPiso = value; } }
        public Ciudad Ciudad { get { return this.iCiudad; } private set { this.iCiudad = value; } }
        public List<Cliente> Clientes { get { return this.iClientes; } private set { this.iClientes = value; } }
        //--------------------------------------metodos
        public string Direccion()
        {
            return (this.iCalle +' '+this.iNumCalle);
        }
    }
}
