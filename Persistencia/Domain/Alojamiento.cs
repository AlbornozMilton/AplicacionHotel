﻿using System;
using System.Collections.Generic;

namespace Persistencia.Domain
{
    public class Alojamiento
    {
        public int AlojamientoId { get; set; }
        public int DniResponsable { get; set; }
        public bool EsTour { get; set; }
        public string Atendio { get; set; }
        public DateTime FechaAloj { get; set; }
		public DateTime? FechaReserva { get; set; }
        public DateTime? FechaEstimadaIngreso { get; set; }
        public DateTime? FechaEstimadaEgreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaEgreso { get; set; }
		public DateTime? FechaCancelacion { get; set; }
		public double MontoTotal { get; set; }
        public double MontoDeuda { get; set; }
        public EstadoAlojamiento EstadoAlojamiento { get; set; }

        public List<AlojHab> AlojHabes { get; set; }
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
