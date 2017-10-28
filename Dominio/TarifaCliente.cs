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
        private double iMontaTarifaExcl;

        //-------------Contructor
        public TarifaCliente(int pCod, TipoCliente pTipoCli, double pTarifa, double pTarifaExcl)
        {
            this.iCodTarifa = pCod;
            this.iTipoCliente = pTipoCli;
            this.iMontoTarifa = pTarifa;
            this.iMontaTarifaExcl = pTarifaExcl;
        }

        //---------------------Propiedades
        public int TarifaClienteId { get { return this.iCodTarifa; } }
        public TipoCliente TipoCliente { get { return this.iTipoCliente; } }
        public double Tarifa { get { return this.iMontoTarifa; } }
        public double TarifaExclusiva { get { return this.iMontaTarifaExcl; } }
        
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
