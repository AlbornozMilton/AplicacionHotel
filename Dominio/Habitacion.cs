﻿using System;
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

        //CONSTRUCTORES
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
        public int HabitacionId
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
        }
        public List<Cupo> Cupos
        {
            get { return this.iCupos; }
        }

        //METODOS   
        public bool OcuparCupos(int pCantS, int pCantD)
        {
            bool resultado = true;
            foreach (Cupo cupo in this.iCupos)
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
                                cupo.Ocupar();
                                pCantS--; 
                            }
                            break;

                        case (TipoCupo.doble):
                            //pCantD > 0, faltan cupos por cambiar su disponibilidad
                            if (pCantD > 0)
                            {
                                cupo.Ocupar();
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
            foreach (Cupo cupo in this.iCupos)
            {
                //cupos.Disponible indica si un cupo esta libre
                if (cupo.Disponible)
                {
                    if (pCantS > 0 && cupo.TipoCupo == TipoCupo.simple)
                    {
                        cupo.Ocupar();
                        pCantS--;
                    }
                    else if (pCantD > 0 && cupo.TipoCupo == TipoCupo.doble)
                    {
                        cupo.Ocupar();
                        pCantD--;
                    }
                }
            }
            if (pCantD != 0 || pCantS != 0)
            {
                throw new Exception("Error en cantidades ingresadas");
            }
        }

        public void DesocuparCupos(int pCantS, int pCantD)
        {
            foreach (var cupo in this.iCupos)
            {
                //cupos.Disponible indica si un cupo esta libre
                if (!(cupo.Disponible))
                {
                    if (pCantS > 0 && cupo.TipoCupo == TipoCupo.simple)
                    {
                        cupo.Ocupar();
                        pCantS--;
                    }
                    else if (pCantD > 0 && cupo.TipoCupo == TipoCupo.doble)
                    {
                        cupo.Desocupar();
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

            foreach (Cupo cupo in this.iCupos)
            {
                if (cupo.Disponible)
                {
                    if (cupo.TipoCupo == TipoCupo.simple)
                    {
                        this.iCapacidad++;
                    }
                    else if (cupo.TipoCupo == TipoCupo.doble)
                    {
                        this.iCapacidad += 2;
                    } 
                }
            }
        }

        public int CuposSimpleDisponibles()
        {
            int resultado = 0;
            foreach (Cupo cupo in this.iCupos)
            {
                if (cupo.Disponible && (cupo.TipoCupo == TipoCupo.simple))
                {
                    resultado++;
                }
            }
            return resultado;
        }

        public int CuposDoblesDisponibles()
        {
            int resultado = 0;
            foreach (Cupo cupo in this.iCupos)
            {
                if (cupo.Disponible && (cupo.TipoCupo == TipoCupo.doble))
                {
                    resultado =+ 2;
                }
            }
            return resultado;
        }

        public int CapacidadTotal()
        {
            int resultado = 0;
            foreach (Cupo cupo in this.iCupos)
            {
                if (cupo.TipoCupo == TipoCupo.simple)
                {
                    resultado++;
                }else if (cupo.TipoCupo == TipoCupo.doble)
	            {
                    resultado += 2;
                }
            }
            return resultado;
        }
    }
}