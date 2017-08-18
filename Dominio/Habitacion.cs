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
        private int iNro;
        private int iCapacidad;
        private int iPlanta;
        private bool iExclusiva; //bool o boolean usar?
        private List<Cupo> iListaCupo; //IList<Cupo>

        //CONSTRUCTOR
        public Habitacion(int pNro, int pCapacidad, int pPlanta, bool pExclusiva)
        {
            this.iNro = pNro;
            this.iCapacidad = pCapacidad;
            this.iPlanta = pPlanta;
            this.iExclusiva = pExclusiva;
        }

        //PROPIEDADES
        public int Nro
        {
            get { return this.iNro; }
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