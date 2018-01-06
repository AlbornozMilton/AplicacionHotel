﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    public class Alojamiento
    {
        public int AlojamientoId { get; set; }
        public int DniResponsable { get; set; }
        public DateTime? FechaReserva { get; set; }
        public DateTime? FechaEstimadaIngreso { get; set; }
        public DateTime? FechaEstimadaEgreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaEgreso { get; set; }
        public double MontoTotal { get; set; }
        public double MontoDeuda { get; set; }
        public byte CantCuposSimples { get; set; }
        public byte CantCuposDobles { get; set; }
        public bool Exclusividad { get; set; }
        public EstadoAlojamiento EstadoAlojamiento { get; set; }
        public string ContadoresTarifas { get; set; }

        //-------------------- Relaciones ---------------------------------//
    //    public int ClienteId { get; set; }
        public byte HabitacionId { get; set; }
        public Habitacion Habitacion { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Pago> Pagos { get; set; }
        public List<LineaServicio> Servicios { get; set; }
    }

    public enum EstadoAlojamiento
    {
        Reservado,
        Alojado,
        Cerrado,
        Cancelado
    }
}
