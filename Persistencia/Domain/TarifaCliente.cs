using System.Collections.Generic;

namespace Persistencia.Domain
{
    public class TarifaCliente
    {
        public TipoCliente TarifaClienteId { get; set; }
        public string NombreTarifa { get; set; }
        public double Tarifa { get; set; }
        public double TarifaExclusiva { get; set; }

        public List<Cliente> Clientes { get; set; }
        public List<AlojHab> AlojHabs { get; set; }
    }

    public enum TipoCliente
    {
        Titular,
        AcompanianteDirecto,
        AcompanianteNoDirecto,
        TitularExceptuado,
        Convenio
    }
}
