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
        IEnumerable<Cliente> ObtenerClientesPorNomyAp(string pNombre, bool pAlta);
        Cliente GetPorDNI(int pDNI, bool pAlta);
        void ModificarAlta(bool pValor, int pIdCliente);
        Cliente GetPorLegajo(int pLegajo, bool pAlta);
        bool ExisteClienteDNI(int pDNI);
        bool ExisteClienteLegajo(int pLegajo);
        void ActualizarCliente(Cliente pCliente, int pIdDomicilio);
        void ModificarDNICliente(Cliente pCliente, int pLegajo);
    }

}
