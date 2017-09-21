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
        private byte iCapacidad;
        private byte iPlanta;
        private bool iExclusiva;
        private List<Cupo> iCupos; 

        //CONSTRUCTOR
        public Habitacion(byte pNumero, byte pPlanta, bool pExclusiva)
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
        public byte Numero
        {
            get { return this.iNumero; }
        }
        public byte Capacidad
        {
            get { return this.iCapacidad; }
        }
        public byte Planta
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
        public bool OcuparCupos(byte pCantS, byte pCantD)
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

        public void OcuparCupos2(byte pCantS, byte pCantD)
        {
            foreach (Cupo cupo in this.iCupos)
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

        public void DesocuparCupos(int pCantS, int pCantD)
        {
            foreach (var cupo in this.iCupos)
            {
                //cupos.Disponible indica si un cupo esta libre
                if (!(cupo.Disponible))
                {
                    if (pCantS > 0 && cupo.TipoCupo == TipoCupo.simple)
                    {
                        cupo.Disponible = true;
                        pCantS--;
                    }
                    else if (pCantD > 0 && cupo.TipoCupo == TipoCupo.doble)
                    {
                        cupo.Disponible = true;
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

        public byte CuposSimpleDisponibles()
        {
            byte resultado = 0;
            foreach (Cupo cupo in this.iCupos)
            {
                if (cupo.Disponible && (cupo.TipoCupo == TipoCupo.simple))
                {
                    resultado++;
                }
            }
            return resultado;
        }

        public byte CuposDoblesDisponibles()
        {
            byte resultado = 0;
            foreach (Cupo cupo in this.iCupos)
            {
                if (cupo.Disponible && (cupo.TipoCupo == TipoCupo.doble))
                {
                    resultado =+ 2;
                }
            }
            return resultado;
        }

        public byte CapacidadTotal()
        {
            byte resultado = 0;
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