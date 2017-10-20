using System.Collections.Generic;

namespace Persistencia.Domain
{
    public class Ciudad
    {
        public int CiudadId { get; set; } //CP de la Ciudad

        public string Nombre { get; set; }

        public List<Domicilio> Domicilios { get; set; }

    }
}
