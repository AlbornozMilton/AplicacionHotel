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
        private string iTelefono;
        private string iCorreo;
        private Domicilio iDomicilio;
        private TarifaCliente iTarifa;

        //-------------------------------Constructores
        public Cliente() { } //Constructor utilizado por el AutoMapper para el mapeo inverso. De Persistencia a Dominio.

        public Cliente(int pDni, string pNombre, string pApellido, string pTel, string pCorreo, Domicilio pDom, TarifaCliente pTarifa)
        {
            this.iDni = pDni;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
            this.iCorreo = pCorreo;
            this.iDomicilio = pDom;
            this.iTarifa = pTarifa;
        }
        /// <summary>
        /// Contructor sin Correo
        /// </summary>
        //public Cliente(int pDni, string pNombre, string pApellido, string pTel, Domicilio pDom, TipoCliente pTipoCliente)
        //{
        //    this.iDni = pDni;
        //    this.iNombre = pNombre;
        //    this.iApellido = pApellido;
        //    this.iTelefono = pTel;
        //    this.iDomicilio = pDom;
        //    //this.iTipoCliente = pTipoCliente;
        //}

        //public Cliente(int pDni, string pNombre, string pApellido, string pTel)
        //{
        //    this.iDni = pDni;
        //    this.iNombre = pNombre;
        //    this.iApellido = pApellido;
        //    this.iTelefono = pTel;
        //}

        //----------------------------------Propiedades
        public int ClienteId { get { return this.iDni; } private set { this.iDni = value; } }
        public string Nombre { get { return this.iNombre; } private set { this.iNombre = value; } }
        public string Apellido { get { return this.iApellido; } private set { this.iApellido = value; } }
        public string Telefono { get { return this.iTelefono; } private set { this.iTelefono = value; } }
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
            private set { this.iCorreo = value; }
        }
        public Domicilio Domicilio { get { return this.iDomicilio; } }
        public TarifaCliente TarifaCliente { get { return this.iTarifa; } }

        //-------------------------------------Metodos




    }
}
