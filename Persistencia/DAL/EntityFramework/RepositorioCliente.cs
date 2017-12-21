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
           return (base.iDbContext.Clientes.Find(pCliente.ClienteId) != null);
        }

        public IEnumerable<Cliente> ObtenerClientesPorNomyAp(string pNombre)
        {
            var clientes = from cli in this.iDbContext.Clientes
                           where ((cli.Nombre+cli.Apellido).Contains(pNombre))
                           select cli;

            return clientes.ToList<Cliente>();
        }

        public override Cliente Get(int pId)
        {
            var unCliente = iDbContext.Clientes.Include("TarifaCliente").Include("Domicilio").Where(c => c.ClienteId == pId).Single();
            if (unCliente == null)
            {
                throw new Exception("Cliente No Existe");
            }
            else
            {
                return (unCliente);
            }
        }
    }
}
