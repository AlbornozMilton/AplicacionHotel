﻿using System.Collections.Generic;

namespace Dominio
{
    public class TarifaCliente
    {
        private TipoCliente iTipoCliente; // CLAVE
        private string iNombreTarifa;
        private double iMontoTarifa;
        private double iMontoTarifaExcl;
        private List<Cliente> iClientes;

        //-------------Contructor
        public TarifaCliente()
        {

        }

        public TarifaCliente(TipoCliente pTipoCli, double pTarifa, double pTarifaExcl)
        {
            this.iTipoCliente = pTipoCli;
            this.iMontoTarifa = pTarifa;
            this.iMontoTarifaExcl = pTarifaExcl;
        }

        //---------------------Propiedades
        public TipoCliente TarifaClienteId { get { return this.iTipoCliente; } private set { this.iTipoCliente = value; } }
        public string NombreTarifa { get { return this.iNombreTarifa; } private set { this.iNombreTarifa = value; } }
        public double Tarifa { get { return this.iMontoTarifa; } private set { this.iMontoTarifa = value; } }
        public double TarifaExclusiva { get { return this.iMontoTarifaExcl; } private set { this.iMontoTarifaExcl = value; } }
        public List<Cliente> Clientes { get { return this.iClientes; } private set { this.iClientes = value; } }
        
        //--------------------Metodos
        /// <summary>
        /// Retorna el monto de Tarifa según la exclusividad de una Habitación
        /// </summary>
        /// <param name="pExclusiva"> Valor que indica si la Habitación a sido solicitada como exclusiva</param>
        public double GetTarifa(bool pExclusiva)
        {
            if (pExclusiva) return this.TarifaExclusiva;
            else return this.Tarifa;
        }

        public void ActualizarMontos(double pNoExclusiva, double pExclusiva)
        {
            this.iMontoTarifa = pNoExclusiva;
            this.iMontoTarifaExcl = pExclusiva;
        }
    }
}
