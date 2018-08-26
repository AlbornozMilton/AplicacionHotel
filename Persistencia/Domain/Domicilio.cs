using System.Collections.Generic;

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
        public int? CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }

       // public int  ClienteId { get; set; }
        public List<Cliente> Clientes { get; set; }

        public bool Equals(Domicilio other)
        {
            return
                 (
                     this.Calle == other.Calle &&
                     this.Numero == other.Numero &&
                     this.NroDepto == other.NroDepto &&
                     this.Piso == other.Piso
                     //this.Ciudad.CiudadId == other.Ciudad.CiudadId
                );
        }
    }
}
