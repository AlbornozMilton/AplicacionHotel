﻿using System;
using System.Collections.Generic;

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
		//private AlojHab iAlojHab;

		//-------------------------------Constructores
		public Cliente() { } 

        public Cliente(int pDni, int pLegajo, string pNombre, string pApellido, string pTel, string pCorreo, Domicilio pDomicilio, TarifaCliente pTarifa)
        {
            this.iDni = pDni;
            this.iLegajo = pLegajo;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
			this.iCorreo = pCorreo;
            this.iDomicilio = pDomicilio;
            this.iTarifa = pTarifa;
            this.iEnAlta = true;
        }

        //Sin legajo para Acomp o Acomp No Directo
        public Cliente(int pDni, string pNombre, string pApellido, string pTel, string pCorreo, Domicilio pDomicilio, TarifaCliente pTarifa)
        {
            this.iDni = pDni;
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
            this.iCorreo = pCorreo;
            this.iDomicilio = pDomicilio;
            this.iTarifa = pTarifa;
            this.iEnAlta = true;
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

        //-------------------------------------Metodos---------------------------------------
        /// <summary>
        /// Usado para saber si un Cliente existe es una Lista determinada, o bien si un Cliente es iguala otro.
        /// </summary>
        /// <param name="other">Cliente externo a comparar</param>
        bool IEquatable<Cliente>.Equals(Cliente other)
        {
            return (this.ClienteId == other.ClienteId);
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

        public string NombreCompleto()
        {
            return this.iApellido + " " + this.iNombre;
        }
    }
}
