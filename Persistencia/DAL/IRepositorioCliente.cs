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
        /// <summary>
        /// Obtiene todos los clientes que solamente esten en Alta (true)
        /// </summary>
        /// <returns></returns>
        IEnumerable<Cliente> ObtenerClientesEnAlta();
    }

}
