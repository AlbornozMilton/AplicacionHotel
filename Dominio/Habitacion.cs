﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Habitacion
    {
        //ATRIBUTOS
        private int iNumero;
        private int iCapacidad;
        private int iPlanta;
        private bool iExclusiva; 
        private List<Cupo> iCupos = new List<Cupo>();

        //CONSTRUCTOR
        public Habitacion(int pNumero, int pCapacidad, int pPlanta, bool pExclusiva)
        {
            this.iNumero = pNumero;
            this.iCapacidad = pCapacidad;
            this.iPlanta = pPlanta;
            this.iExclusiva = pExclusiva;
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
            set { this.iCupos = value; }
        }

        //METODOS
    }
}