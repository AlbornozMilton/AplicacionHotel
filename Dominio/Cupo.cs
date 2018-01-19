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
        private bool iAlta;

        //--------------------------CONSTRUCTOR
        public Cupo()
        {
        }

        public Cupo(byte pCodCupo,TipoCupo pTipoCupo, bool pDisponible, bool pAlta)
        {
            this.iCodCupo = pCodCupo;
            this.iTipoCupo = pTipoCupo;
            this.iDisponible = pDisponible;
            this.iAlta = pAlta;
        }

        //----------------------------PROPIEDADES
        public byte CupoId
        {
            get { return this.iCodCupo; }
            private set { this.iCodCupo = value; }
        }
        public TipoCupo Tipo
        {
            get { return this.iTipoCupo; }
            private set { this.iTipoCupo = value; }
        }
        public bool Disponible
        {
            get { return this.iDisponible; }
            private set { this.iDisponible = value; }
        }
        public bool Alta
        {
            get { return this.iAlta; }
            set { this.iAlta = value; }
        }

        //------------------------------METODOS
        /// <summary>
        /// Modifica su estado Disponible a "false"
        /// </summary>
        public void Ocupar()
        {
            this.iDisponible = false;
        }

        /// <summary>
        /// Modifica su estado Disponible a "true"
        /// </summary>
        public void Desocupar()
        {
            this.iDisponible = true;
        }

        public void ModificarAlta(bool pAlta)
        {
            this.iAlta = pAlta;
        }
    }
}
