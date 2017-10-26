using System;
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
        public int Telefono { get; set; }
        public string Correo { get; set; }


        public int AlojamientoId { get; set; }
        public int TarifaClienteId { get; set; }
        public int DomicilioId { get; set; }
        public Domicilio Domicilio { get; set; }
        public TarifaCliente TarifaCliente { get; set; }
        public Alojamiento Alojamiento { get; set; }
    }
}
