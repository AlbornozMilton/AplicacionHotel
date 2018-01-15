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
        IEnumerable<Cliente> ObtenerClientesPorNomyAp(string pNombre);
       
        void ModificarAlta(bool pValor, int pIdCliente);
        Cliente GetPorLegajo(int pLegajo);
        bool ExisteClienteDNI(int pDNI);
        bool ExisteClienteLegajo(int pLegajo);
    }

}
