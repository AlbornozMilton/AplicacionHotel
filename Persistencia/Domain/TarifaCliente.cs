using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Domain
{
    public class TarifaCliente
    {
        public int TarifaClienteId { get; set; }

        public TipoCliente TipoCliente { get; set; }

        public double Tarifa { get; set; }

        public double TarifaExclusiva { get; set; }

        //???????????????
        public List<Cliente> Clientes { get; set; }
    }

    public enum TipoCliente
    {
        Titular,
        TitularExceptuado,
        AcompanianteDirecto,
        AcompanianteNoDirecto,
        Convenio
    }
}
