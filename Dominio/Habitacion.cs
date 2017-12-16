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
      //  private int iCapacidad;
        private byte iPlanta;
        private bool iExclusiva;
        private List<Cupo> iCupos;
        //private List<Alojamiento> iAlojamientos;  ------>>>>>> AREGLAR HACE REFERENCIA CIRCULAR --> STACKOVERFLOW

        //CONSTRUCTORES
        public Habitacion()
        {
        }

        public Habitacion(byte pNumero, byte pPlanta, bool pExclusiva, int pCapacidad, List<Cupo> pCupos)
        {
            this.iNumero = pNumero;
          //  this.iCapacidad = pCapacidad;
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
        //public int Capacidad
        //{
        //    get { return this.iCapacidad; }
        //    private set { this.iCapacidad = value; }
        //}
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
        //public List<Alojamiento> Alojamientos
        //{
        //    get { return this.iAlojamientos; }
        //    private set { this.iAlojamientos = value; }
        //}

        //public void OcuparCupos(byte pCantS, byte pCantD)
        //{
        //    IEnumerator<Cupo> cupos = this.iCupos.GetEnumerator(); //"ENUMENATOR" ES COMO UN PUNTERO PARA RECORRER UN ENUMERABLE

        //    while ((pCantS > 0) || (pCantD > 0))
        //    {
        //        if (cupos.Current != null) // PUNTERO AL ELEMENTO ACTUAL
        //        {
        //            if (pCantS > 0 && cupos.Current.Tipo == TipoCupo.simple)
        //            {
        //                cupos.Current.Ocupar(); // TRATAR ELEMENTO ACTUAL
        //                pCantS--;
        //                cupos.MoveNext(); // MOVER PUNTERO A PROXIMO ELEMENTO
        //            }
        //            else if (pCantD > 0 && cupos.Current.Tipo == TipoCupo.doble)
        //            {
        //                cupos.Current.Ocupar();
        //                pCantD--;
        //                cupos.MoveNext();
        //            }
        //        }
        //        else
        //        {
        //            throw new Exception("CantS y CantD no coincide con los cupos a Ocupar");
        //        }
        //    }
        //}

        public void OcuparCupos(byte pCantS, byte pCantD)
        {
            foreach (var cupo in this.iCupos)
            {
                if ((pCantS > 0) || (pCantD > 0))
                {
                    if (pCantS > 0 && cupo.Tipo == TipoCupo.simple && cupo.Disponible )
                    {
                        cupo.Ocupar(); // TRATAR ELEMENTO ACTUAL
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

        public void DescuparCupos(byte pCantS, byte pCantD)
        {
            IEnumerator<Cupo> cupos = this.iCupos.GetEnumerator(); //"ENUMENATOR" ES COMO UN PUNTERO PARA RECORRER UN ENUMERABLE

            while ((pCantS > 0) || (pCantD > 0))
            {
                if (cupos.Current != null) // PUNTERO AL ELEMENTO ACTUAL
                {
                    if (pCantS > 0 && cupos.Current.Tipo == TipoCupo.simple)
                    {
                        cupos.Current.Desocupar(); // TRATAR ELEMENTO ACTUAL
                        pCantS--;
                        cupos.MoveNext(); // MOVER PUNTERO A PROXIMO ELEMENTO
                    }
                    else if (pCantD > 0 && cupos.Current.Tipo == TipoCupo.doble)
                    {
                        cupos.Current.Desocupar();
                        pCantD--;
                        cupos.MoveNext();
                    }
                }
                else
                {
                    throw new Exception("CantS y CantD no coincide con los cupos a Desocupar");
                }
            }
        }

        public byte Capcidad()
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