using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {

        private int iDni { get; set; }
        private string iNombre { get; set; }
        private string iApellido { get; set; }
        private string iTelefono { get; set; }
        private string iCorreo { get; set; }
        private Domicilio iDomicilio { get; set; }
        private TipoCliente iTipoCliente { get; set; }

        //-------------------------------Constructores
        public Cliente()
        {

        }
        public Cliente(int pDni, string pNombre, string pApellido, string pTel, string pCorreo, Domicilio pDom, TipoCliente pTipoCliente)
        {
            this.iDni = pDni;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
            this.iCorreo = pCorreo;
            this.iDomicilio = pDom;
            this.iTipoCliente = pTipoCliente;
        }
        /// <summary>
        /// Contructor sin Correo
        /// </summary>
        public Cliente(int pDni, string pNombre, string pApellido, string pTel, Domicilio pDom, TipoCliente pTipoCliente)
        {
            this.iDni = pDni;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
            this.iDomicilio = pDom;
            this.iTipoCliente = pTipoCliente;
        }

        public Cliente(int pDni, string pNombre, string pApellido, string pTel)
        {
            this.iDni = pDni;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
        }

        //usado para pruebas
        public Cliente(int pDni, string pNombre, string pApellido, string pTel, TipoCliente pTipoCliente)
        {
            this.iDni = pDni;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
            // this.iDomicilio = pDom; provicionalemnte, luego agregar
            this.iTipoCliente = pTipoCliente;
        }

        //----------------------------------Propiedades
        public int ClienteId { get { return this.iDni; } }
        public string Nombre { get { return this.iNombre; } }
        public string Apellido { get { return this.iApellido; } }
        public string Telefono { get { return this.iTelefono; } }
        public string Correo
        {
            get
            {
                if (this.iCorreo == null)
                {
                    return " ";
                }
                else
                {
                    return this.iCorreo;
                }
            }
        }
        public Domicilio Domicilio { get { return this.iDomicilio; } }
        public TipoCliente TipoCliente { get { return this.iTipoCliente; } }

        //-------------------------------------Metodos




    }
}
