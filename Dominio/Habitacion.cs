using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Habitacion
    {
        private byte iNumero;
        private byte iPlanta;
        private bool iExclusiva;
        private List<Cupo> iCupos;

        //CONSTRUCTORES
        public Habitacion()
        {
        }

        public Habitacion(byte pNumero, byte pPlanta, bool pExclusiva, int pCapacidad, List<Cupo> pCupos)
        {
            this.iNumero = pNumero;
            this.iPlanta = pPlanta;
            this.iExclusiva = pExclusiva;
            this.iCupos = pCupos;
        }
        //public Habitacion(int pNumero, int pPlanta, bool pExclusiva, int pCapacidad)
        //{
        //    this.iNumero = pNumero;
        //    this.iCapacidad = pCapacidad;
        //    this.iPlanta = pPlanta;
        //    this.iExclusiva = pExclusiva;
        //    this.iCupos = new List<Cupo>()
        //    {
        //       new Cupo(1, TipoCupo.simple, true),
        //       new Cupo(2, TipoCupo.doble, true),
        //       new Cupo(3, TipoCupo.simple, false),
        //       new Cupo(4, TipoCupo.doble, true)
        //    };
        //    this.CalcularCapcidad();
        //}

        //PROPIEDADES
        public byte HabitacionId
        {
            get { return this.iNumero; }
            private set { this.iNumero = value; }
        }
        
        public byte Planta
        {
            get { return this.iPlanta; }
            private set { this.iPlanta = value; }
        }
        public bool Exclusiva
        {
            get { return this.iExclusiva; }
            private set { this.iExclusiva = value; }
        }
        public List<Cupo> Cupos
        {
            get { return this.iCupos; }
            private set { this.iCupos = value; }
        }

       
        public void OcuparCupos(byte pCantS, byte pCantD)
        {
            foreach (var cupo in this.iCupos)
            {
                if ((pCantS > 0) || (pCantD > 0))
                {
                    if (pCantS > 0 && cupo.Tipo == TipoCupo.simple && cupo.Disponible )
                    {
                        cupo.Ocupar(); 
                        pCantS--;                            
                    }
                    else if (pCantD > 0 && cupo.Tipo == TipoCupo.doble && cupo.Disponible)
                    {
                        cupo.Ocupar();
                        pCantD--;
                    }
                }
            }
        }

        public void DesocuparCupos(byte pCantS, byte pCantD)
        {
            foreach (var cupo in this.iCupos)
            {
                if ((pCantS > 0) || (pCantD > 0))
                {
                    if (pCantS > 0 && cupo.Tipo == TipoCupo.simple && !cupo.Disponible)
                    {
                        cupo.Desocupar(); 
                        pCantS--;
                    }
                    else if (pCantD > 0 && cupo.Tipo == TipoCupo.doble && !cupo.Disponible)
                    {
                        cupo.Desocupar();
                        pCantD--;
                    }
                }
            }
        }

        public byte Capacidad()
        {
            byte lCapacidad = 0;
            foreach (var cupo in this.iCupos)
            {
                if (cupo.Disponible)
                {
                    if (cupo.Tipo == TipoCupo.simple)
                    {
                        lCapacidad ++;
                    }
                    else if (cupo.Tipo == TipoCupo.doble)
                    {
                        lCapacidad += 2;
                    } 
                }
            }
            return lCapacidad;
        }

        public byte CuposSimpleDisponibles()
        {
            byte resultado = 0;
            foreach (var cupo in this.iCupos)
            {
                if (cupo.Disponible && (cupo.Tipo == TipoCupo.simple))
                {
                    resultado++;
                }
            }
            return resultado;
        }

        public byte CuposDoblesDisponibles()
        {
            byte resultado = 0;
            foreach (var cupo in this.iCupos)
            {
                if (cupo.Disponible && (cupo.Tipo == TipoCupo.doble))
                {
                    resultado ++ ;
                }
            }
            return resultado;
        }
    }
}