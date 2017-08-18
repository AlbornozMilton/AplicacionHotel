using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cupo
    {
        private TipoCupo iTipoCupo;
        private bool iDisponible;

        //CONTRUCTOR
        public Cupo(TipoCupo pTipoCupo, bool pDisponible)
        {
            this.iTipoCupo = pTipoCupo;
            this.iDisponible = pDisponible;
        }
    }
}
