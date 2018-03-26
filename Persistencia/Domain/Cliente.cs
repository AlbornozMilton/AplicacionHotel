using System.Collections.Generic;

namespace Persistencia.Domain
{
    public class Cliente
    {
        public int ClienteId { get; set; } //DNI
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public bool EnAlta { get; set; }


        public TipoCliente TarifaClienteId { get; set; }
        public TarifaCliente TarifaCliente { get; set; }

        public int DomicilioId { get; set; }
        public Domicilio Domicilio { get; set; }
       
        public List<Alojamiento> Alojamientos { get; set; }
     
    }
}
