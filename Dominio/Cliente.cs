using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        private int iDni;
        private string iNombre;
        private string iApellido;
        private int iTelefono;
        private string iCorreo;
        private Domicilio iDomicilio;
        private TipoCliente iTipoCliente;
        
        //-------------------------------Constructores
        public Cliente(int pDni, string pNombre, string pApellido, int pTel, string pCorreo, Domicilio pDom, TipoCliente pTipoCliente)
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
        public Cliente(int pDni, string pNombre, string pApellido, int pTel, Domicilio pDom, TipoCliente pTipoCliente)
        {
            this.iDni = pDni;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
            this.iDomicilio = pDom;
            this.iTipoCliente = pTipoCliente;
        }

        public Cliente(int pDni, string pNombre, string pApellido, int pTel)
        {
            this.iDni = pDni;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
        }

        //usado para pruebas---------------!!!!!!!!!!!!!!!!!!!!!!!!
        public Cliente(int pDni, string pNombre, string pApellido, int pTel, TipoCliente pTipoCliente)
        {
            this.iDni = pDni;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
            // this.iDomicilio = pDom; provicionalemnte, luego agregar
            this.iTipoCliente = pTipoCliente;
        }

        //----------------------------------Peopiedades//----------------------------------

        public int Dni
        {
            get { return this.iDni; }
         //   set { this.iDni = value; }
        }

        public string Nombre { get { return this.iNombre; } }
        public string Apellido { get { return this.iApellido; } }
        public int Telefono { get { return this.iTelefono; } }
        public string Correo
        {
            get
            {
                if (this.iCorreo == null)
                    return "";
                else return this.iCorreo; 
            }
        }
        public Domicilio Domicilio { get { return this.iDomicilio; } }
        public TipoCliente TipoCliente { get { return this.iTipoCliente; } }

        //-------------------------------------Metodos




    }
}
