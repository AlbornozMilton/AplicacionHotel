﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cupo
    {
        private int iCodCupo;
        private TipoCupo iTipoCupo;
        private bool iDisponible;

        //--------------------------CONSTRUCTOR
        public Cupo(int pCodCupo,TipoCupo pTipoCupo, bool pDisponible)
        {
            this.iCodCupo = pCodCupo;
            this.iTipoCupo = pTipoCupo;
            this.iDisponible = pDisponible;
        }

        //----------------------------PROPIEDADES
        public int CupoId
        {
            get { return this.iCodCupo; }
            private set { this.iCodCupo = value; }
        }


        public bool Disponible
        {
            get { return this.iDisponible; }
            private set { this.iDisponible = value; }
        }

        public TipoCupo TipoCupo
        {
            get { return this.iTipoCupo; }
            private set { this.iTipoCupo = value; }
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
    }
}
