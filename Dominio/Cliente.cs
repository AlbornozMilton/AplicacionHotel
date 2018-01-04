using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente:IEquatable<Cliente>
    {
        private int iDni;
        private int iLegajo;
        private string iNombre;
        private string iApellido;
        private string iTelefono;
        private string iCorreo;
        public bool iEnAlta;
        private Domicilio iDomicilio;
        private TarifaCliente iTarifa;
        private List<Alojamiento> iAlojamientos;

        //-------------------------------Constructores
        public Cliente() { } 

        public Cliente(int pDni, int pLegajo, string pNombre, string pApellido, string pTel, string pCorreo, Domicilio pDom, TarifaCliente pTarifa)
        {
            this.iDni = pDni;
            this.iLegajo = pLegajo;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
            this.iCorreo = pCorreo;
            this.iDomicilio = pDom;
            this.iTarifa = pTarifa;
        }

        /// <summary>
        /// Constructor para Reserva. Para mantener registro del Tipo Cliente
        /// </summary>
        public Cliente(TarifaCliente pTarifaCliente)
        {
            this.iTarifa = pTarifaCliente;
            //el resto de los atributos es Null o Default.
        }

        public Cliente(int pDni, int pLegajo, string pNombre, string pApellido, string pTel)
        {
            this.iDni = pDni;
            this.iLegajo = pLegajo;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
        }

        //----------------------------------Propiedades------------------------------------
        public int ClienteId { get { return this.iDni; } private set { this.iDni = value; } }
        public int Legajo { get { return this.iLegajo; } private set { this.iLegajo = value; } }
        public string Nombre { get { return this.iNombre; } private set { this.iNombre = value; } }
        public string Apellido { get { return this.iApellido; } private set { this.iApellido = value; } }
        public string Telefono { get { return this.iTelefono; } private set { this.iTelefono = value; } }
        public string Correo { get { return this.iCorreo; } private set { this.iCorreo = value; } }
        public bool EnAlta { get { return this.iEnAlta; } private set { this.iEnAlta = value; } }

        public Domicilio Domicilio { get { return this.iDomicilio; } private set { this.iDomicilio = value; } }
        public TarifaCliente TarifaCliente { get { return this.iTarifa; } private set { this.iTarifa = value; } }
        public List<Alojamiento> Alojamientos { get { return this.iAlojamientos; } private set { this.iAlojamientos = value; } }

        //-------------------------------------Metodos---------------------------------------
        /// <summary>
        /// Usado para saber si un Cliente existe es una Lista determinada, o bien si un Cliente es iguala otro.
        /// </summary>
        /// <param name="other">Cliente externo a comparar</param>
        bool IEquatable<Cliente>.Equals(Cliente other)
        {
            return (this.ClienteId.GetHashCode() == other.ClienteId.GetHashCode());
        }

        /// <summary>
        /// Obtiene el precio de su Tarifa segun la Exclusividad
        /// </summary>
        /// <param name="pExclusividad">Exclusividad de la Habitacion</param>
        /// <returns></returns>
        public double ObtenerSuPrecioTarifa(bool pExclusividad)
        {
            return this.iTarifa.GetTarifa(pExclusividad);
        }

    }
}
