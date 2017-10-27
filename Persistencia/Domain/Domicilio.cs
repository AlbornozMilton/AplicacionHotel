﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    public class Domicilio
    {
        public int DomicilioId { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string NroDepto { get; set; }

       // public List<Cliente> Clientes { get; set; }
        public int CiudadId { get; set; }

        public Ciudad Ciudad { get; set; }
    }
}
