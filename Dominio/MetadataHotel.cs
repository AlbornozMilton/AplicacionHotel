﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MetadataHotel
    {
        //private TipoMetadaHotel iMetadataHotelId;
        //private string iNombre;
        //private int iValor;

        public TipoMetadaHotel MetadataHotelId { get; private set; }
        public string Nombre { get; private set; }
        public int Valor { get; private set; }
    }

    public enum TipoMetadaHotel
    {
        PorcentajeExclusividad,
        PorcentajeTour,
        PorcentajeDeposito
    }
}
