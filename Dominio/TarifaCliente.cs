using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TarifaCliente
    {
        private double iTitular;
        private double iTitularExcl;
        private double iAcompDirecto;
        private double iAcompDirectoExcl;
        private double iAcompNoDirecto;
        private double iAcompNoDirectoExcl;
        private double iExcepduado;
        private double iConvenio;
        private double iConvenioExcl;

        public TarifaCliente()
        {

        }

        //metodo para cargar desde base de datos ??????? 
        public TarifaCliente(double pTitular, double pTitularExcl, double pAcompDirecto, double pAcompDirectoExcl,
                            double pAcompNoDirectoExcl, double pAcompNoDirecto, double pExceptuado, double pConvenio, 
                            double pConvenioExcl)
        {
            this.iTitular = pTitular;
            this.iTitular = pTitularExcl;
            this.iTitular = pAcompDirecto;
            this.iTitular = pAcompDirectoExcl;
            this.iTitular = pAcompNoDirecto;
            this.iTitular = pAcompNoDirectoExcl;
            this.iTitular = pConvenio;
            this.iTitular = pConvenioExcl;
                
        }

        public double DeterminarTarifa(TipoCliente pTipoCliente, bool pExclusividad)
        {
            double tarifa = 0;

            if (pExclusividad == false)
            {
                switch (pTipoCliente)
                {
                    case TipoCliente.Titular: tarifa = 100; break; // aca seria this.iTitular
                    case TipoCliente.AcompanianteDirecto: tarifa = 150; break;
                    case TipoCliente.AcompanianteNoDirecto: tarifa = 200; break;
                    case TipoCliente.TitularExceptuado: tarifa = 50; break;
                    case TipoCliente.Convenio: tarifa = 300; break;
                }
            }
            else
            {
                switch (pTipoCliente)
                {
                    case TipoCliente.Titular: tarifa = 100*0.5; break; //aca seria this.iTitularExcl;
                    case TipoCliente.AcompanianteDirecto: tarifa = 150 * 0.5; break;
                    case TipoCliente.AcompanianteNoDirecto: tarifa = 200 * 0.5; break;
                    case TipoCliente.TitularExceptuado: tarifa = 0; break;
                    case TipoCliente.Convenio: tarifa = 300 * 0.5; break;
                }
            }
            return tarifa;
        }

    }
}
