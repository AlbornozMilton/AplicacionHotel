﻿using System;

namespace Dominio
{
    public class Pago:IEquatable<Pago>
    {
        private int iCodPago;
        private TipoPago iTipoPago;
        private double iMonto;
        private DateTime iFechaPago;
        private string iDetalle;

        public Pago()
        {

        }

        public Pago(TipoPago pTipoPago, double pMonto, string pDetalle)
        {
            this.iTipoPago = pTipoPago;
            this.iMonto = pMonto;
            this.iDetalle = pDetalle;
            this.iFechaPago = DateTime.Now; 
        }

        public Pago(string pTipoPago, double pMonto, string pDetalle)
        {
            switch (pTipoPago)
            {
                case ("Alojado"):
                    {
                        this.iTipoPago = TipoPago.Alojado;
                    }
                    break;
                case ("Deposito"):
                    {
                        this.iTipoPago = TipoPago.Deposito;
                    }
                    break;
                case ("Servicios"):
                    {
                        this.iTipoPago = TipoPago.Servicios;
                    }
                    break;
                case ("Deuda"):
                    {
                        this.iTipoPago = TipoPago.Deuda;
                    }
                    break;
                default: throw new Exception("Error en asignación de tipo Pago durante la creación del Pago.");
            }
            this.iMonto = pMonto;
            this.iDetalle = pDetalle;
            this.iFechaPago = DateTime.Now;
        }
        //-----------------------Propiedades
        public int PagoId { get { return this.iCodPago; } private set { this.iCodPago = value; } }
        public TipoPago Tipo { get { return this.iTipoPago; } private set { this.iTipoPago = value; } }
        public double Monto { get { return this.iMonto; } private set { this.iMonto = value; } }
        public DateTime FechaPago { get { return this.iFechaPago; } private set { this.iFechaPago = value; } } //ver si es necesario la hora
        public string Detalle { get { return this.iDetalle; } private set { this.iDetalle = value; } }

        public bool Equals(Pago other)
        {
            return this.iTipoPago == other.Tipo && this.iMonto == other.Monto;
        }
    }
}
