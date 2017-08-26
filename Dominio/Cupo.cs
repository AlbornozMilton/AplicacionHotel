using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cupo
    {
        private byte iCodCupo;
        private TipoCupo iTipoCupo;
        private bool iDisponible;

        //--------------------------CONSTRUCTOR
        public Cupo(byte pCodCupo,TipoCupo pTipoCupo, bool pDisponible)
        {
            this.iCodCupo = pCodCupo;
            this.iTipoCupo = pTipoCupo;
            this.iDisponible = pDisponible;
        }

        public byte CodCupo
        {
            get { return this.iCodCupo; }
            set { this.iCodCupo = value; }
        }

        public bool Disponible  
        {
            get { return this.iDisponible; }
            set { this.iDisponible = value; }
        }

        public TipoCupo TipoCupo
        {
            get { return this.iTipoCupo; }
            set { this.iTipoCupo = value; }
        }
    }
}
