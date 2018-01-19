﻿using System;
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
                if (cupo.Alta && (pCantS > 0 || pCantD > 0))
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
                if (cupo.Alta && (pCantS > 0 || pCantD > 0))
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
                if (cupo.Alta && cupo.Tipo == TipoCupo.simple)
                {
                    lCapacidad ++;
                }
                else if (cupo.Alta && cupo.Tipo == TipoCupo.doble)
                {
                    lCapacidad += 2;
                } 
            }
            return lCapacidad;
        }

        public byte CuposSimpleDisponibles()
        {
            byte resultado = 0;
            foreach (var cupo in this.iCupos)
            {
                if (cupo.Alta && cupo.Disponible && cupo.Tipo == TipoCupo.simple)
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
                if (cupo.Alta && cupo.Disponible && cupo.Tipo == TipoCupo.doble )
                {
                    resultado ++ ;
                }
            }
            return resultado;
        }

        public void SetExclusividad(bool pExclusividad)
        {
            this.iExclusiva = pExclusividad;
        }

        public void ModificarAltaCupo(int pIndex)
        {
            if (this.iCupos[pIndex].Alta)
                this.iCupos[pIndex].ModificarAlta(false);
            else
                this.iCupos[pIndex].ModificarAlta(true);
        }
    }
}