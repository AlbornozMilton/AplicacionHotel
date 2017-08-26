using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Habitacion
    {
        private int iNumero;
        private int iCapacidad;
        private int iPlanta;
        private bool iExclusiva;
        private List<Cupo> iCupos; 

        //CONSTRUCTOR
        public Habitacion(int pNumero, int pPlanta, bool pExclusiva)
        {
            this.iNumero = pNumero;
            this.iPlanta = pPlanta;
            this.iExclusiva = pExclusiva;
            this.iCupos = new List<Cupo>()
            {
                new Cupo(1, TipoCupo.simple, true),
                new Cupo(2, TipoCupo.doble, true),
                new Cupo(3, TipoCupo.simple, false),
                new Cupo(4, TipoCupo.doble, true)
            };

            this.CalcularCapcidad() ;

        }

        //PROPIEDADES
        public int Nro
        {
            get { return this.iNumero; }
        }
        public int Capacidad
        {
            get { return this.iCapacidad; }
        }
        public int Planta
        {
            get { return this.iPlanta; }
        }
        public bool Exclusiva
        {
            get { return this.iExclusiva; }
            set { this.iExclusiva = value; }
        }
        public List<Cupo> Cupos
        {
            get { return this.iCupos; }
        //    set { this.iCupos = value; }
        }

        //METODOS   
        public bool OcuparCupos(int pCantS, int pCantD)
        {
            bool resultado = true;
            foreach (var cupo in this.iCupos)
            {
                //cupos.Disponible indica si un cupo esta libre
                if (cupo.Disponible) 
                {
                    //detectar que las cantidades resutlantes no sean menor que cero con TRY-CATCH ??
                    switch (cupo.TipoCupo)
                    {
                        case (TipoCupo.simple):
                            //pCantS > 0, faltan cupos por cambiar su disponibilidad
                            if (pCantS > 0)
                            {
                                cupo.Disponible = false;
                                pCantS--; 
                            }
                            break;

                        case (TipoCupo.doble):
                            //pCantD > 0, faltan cupos por cambiar su disponibilidad
                            if (pCantD > 0)
                            {
                                cupo.Disponible = false;
                                pCantD--; 
                            }
                            break;
                    }
                }
            }
            if (pCantD != 0 || pCantS != 0)
            {
                resultado = false;
            }
            return resultado;
        }

        public void OcuparCupos2(int pCantS, int pCantD)
        {
            foreach (var cupo in this.iCupos)
            {
                //cupos.Disponible indica si un cupo esta libre
                if (cupo.Disponible)
                {
                    if (pCantS > 0 && cupo.TipoCupo == TipoCupo.simple)
                    {
                        cupo.Disponible = false;
                        pCantS--;
                    }
                    else if (pCantD > 0 && cupo.TipoCupo == TipoCupo.doble)
                    {
                        cupo.Disponible = false;
                        pCantD--;
                    }
                }
            }
            if (pCantD != 0 || pCantS != 0)
            {
                throw new Exception("Error en cantidades ingresadas");
            }
        }

        private void CalcularCapcidad()
        {
            this.iCapacidad = 0;

            foreach (var cupo in this.iCupos)
            {
                if (cupo.TipoCupo==TipoCupo.simple)
                {
                    this.iCapacidad++;
                }
                else
                {
                    this.iCapacidad += 2;
                }
            }
        }
    }
}