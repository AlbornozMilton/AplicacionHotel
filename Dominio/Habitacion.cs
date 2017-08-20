using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Habitacion
    {
        //ATRIBUTOS
        private int iNumero;
        private int iCapacidad;
        private int iPlanta;
        private bool iExclusiva; 
        private List<Cupo> iListaCupo;

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
        }

        //METODOS
    }
}