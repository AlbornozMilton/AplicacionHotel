﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia.Domain
{
    public class Cliente
    {
        public int ClienteId { get; set; } //DNI
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }


        //public int AlojamientoId { get; set; }
       // public int TarifaClienteId { get; set; }
      //  public int Domicilio { get; set; }
        public Domicilio Domicilio { get; set; }
        // public TarifaCliente TarifaCliente { get; set; }
        // public Alojamiento Alojamiento { get; set; }


        //SqlException: The INSERT statement conflicted with the FOREIGN KEY constraint "FK_dbo.Cliente_dbo.Domicilio_DomicilioId". 
        //    The conflict occurred in database "HotelBD", table "dbo.Domicilio", column 'DomicilioId'.
    }
}
