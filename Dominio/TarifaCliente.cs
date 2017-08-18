using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TarifaCliente
    {
        private TipoCliente iTipoCliente;
        private double iTarifa;

        public TarifaCliente(TipoCliente pTipoCliente, double pTarifa)
        {
            this.iTipoCliente = pTipoCliente;
            this.iTarifa = pTarifa; // ¿Como determinar tarifa?
        }

        public TipoCliente TipoCliente { get; }
        public double Trifa { get { return this.iTarifa; } }
    }
}
