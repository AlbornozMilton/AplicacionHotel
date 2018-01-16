using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL
{
    public interface IRepositorioCliente : IRepositorio<Cliente>
    {
        Cliente GetPorDNI(int pDNI, bool pValor);
        IEnumerable<Cliente> ObtenerClientesPorNomyAp(string pNombre, bool pValor);
        void ModificarAlta(bool pValor, int pIdCliente);
        Cliente GetPorLegajo(int pLegajo, bool pValor);
        bool ExisteClienteDNI(int pDNI);
        bool ExisteClienteLegajo(int pLegajo);
    }

}
