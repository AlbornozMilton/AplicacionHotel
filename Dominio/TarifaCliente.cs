using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TarifaCliente
    {
        private int iCodTarifa;
        private TipoCliente iTipoCliente;
        private double iMontoTarifa;
        private double iMontoTarifaExcl;

        //-------------Contructor
        public TarifaCliente(int pCod, TipoCliente pTipoCli, double pTarifa, double pTarifaExcl)
        {
            this.iCodTarifa = pCod;
            this.iTipoCliente = pTipoCli;
            this.iMontoTarifa = pTarifa;
            this.iMontoTarifaExcl = pTarifaExcl;
        }

        //---------------------Propiedades
        public int TarifaClienteId { get { return this.iCodTarifa; } private set { this.iCodTarifa = value; } }
        public TipoCliente TipoCliente { get { return this.iTipoCliente; } private set { this.iTipoCliente = value; } }
        public double Tarifa { get { return this.iMontoTarifa; } private set { this.iMontoTarifa = value; } }
        public double TarifaExclusiva { get { return this.iMontoTarifaExcl; } private set { this.iMontoTarifaExcl = value; } }
        
        //--------------------Metodos
        /// <summary>
        /// Retorna el monto de Tarifa según la exclusividad de una Habitación
        /// </summary>
        /// <param name="pExclusiva"> Valor que indica si la Habitación a sido solicitada como exclusiva</param>
        public double DeterminarTarifa(bool pExclusiva)
        {
            if (pExclusiva) return this.TarifaExclusiva;
            else return this.Tarifa;
        }
    }
}
