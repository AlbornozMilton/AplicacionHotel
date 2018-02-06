using System.Collections.Generic;

namespace Persistencia.Domain
{
    public class Ciudad
    {
        public int CiudadId { get; set; }
		public int CodPostal { get; set; }
        public string Nombre { get; set; }

        public List<Domicilio> Domicilios { get; set; }

    }
}
