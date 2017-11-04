using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioCliente : Repositorio<Cliente, HotelContext>, IRepositorioCliente
    {
        public RepositorioCliente(HotelContext pContext) : base(pContext)
        {

        }
        public bool Existe(Cliente pCliente)
        {
           // return (base.iDbContext.Set<Cliente>().Find(pCliente.ClienteId) != null);
           return (base.iDbContext.Cliente.Find(pCliente.ClienteId) != null);
        }

        public IEnumerable<Cliente> ObtenerClientesPorNomyAp(string pNombre)
        {
            var clientes = from cli in this.iDbContext.Set<Cliente>()
                           where ((cli.Nombre+cli.Apellido).Contains(pNombre))
                           select cli;

            return clientes.ToList<Cliente>();
        }
    }
}
