﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        private int iDni;
        private string iNombe;
        private string iApellido;
        private string iTelefono;
        private string iCorreo;
        private Domicilio iDomicilio;
        private TipoCliente iTipoCliente;
        
        //-------------------------------Constructores
        public Cliente(int pDni, string pNombre, string pApellido, string pTel, string pCorreo, Domicilio pDom, TipoCliente pTipoCliente)
        {
            this.iDni = pDni;
            this.iNombe = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
            this.iCorreo = pCorreo;
            this.iDomicilio = pDom;
            this.iTipoCliente = pTipoCliente;
          //  this.iTarifaCliente = pTarifa;
        }

        //usado para pruebas
        public Cliente(int pDni, string pNombre, string pApellido, string pTel, TipoCliente pTipoCliente)
        {
            this.iDni = pDni;
            this.iNombe = pNombre;
            this.iApellido = pApellido;
            this.iTelefono = pTel;
           // this.iCorreo = pCorreo; no es necesario el correo
           // this.iDomicilio = pDom; provicionalemnte, luego agregar
            this.iTipoCliente = pTipoCliente;
            // this.iTarifaCliente = pTarifa;
        }

        //----------------------------------Peopiedades

        public TipoCliente TipoCLiente { get; }

        //-------------------------------------Metodos




    }
}
