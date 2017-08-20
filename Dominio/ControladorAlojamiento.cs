using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ControladorAlojamiento
    {
        
        public double ObteberTarifa(Cliente pCliente, TarifaCliente pTarifa, bool pExclusividad)
        {
            
            return  pTarifa.DeterminarTarifa(pCliente.TipoCLiente, pExclusividad);
          
        }

    }
}
