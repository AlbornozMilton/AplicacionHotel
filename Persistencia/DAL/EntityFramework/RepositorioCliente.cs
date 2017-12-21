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

        public IEnumerable<Cliente> ObtenerClientesPorNomyAp(string pNombre)
        {
            var clientes = from cli in this.iDbContext.Clientes
                           where ((cli.Nombre+cli.Apellido).Contains(pNombre))&&(cli.EnAlta == true)
                           select cli;

            return clientes.ToList<Cliente>();
        }

        public override Cliente Get(int pId)
        {
            try
            {
                return iDbContext.Clientes.Include("TarifaCliente").Include("Domicilio").Where(c => c.ClienteId == pId && c.EnAlta == true).Single();
            }
            catch
            {
                throw new Exception("Cliente No Existe");
            }
        }

        /// <summary>
        /// Retorna una lista de Clientes que solo estan en Alta
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Cliente> ObtenerClientesEnAlta()
        {
            var clientes = from cli in this.iDbContext.Clientes
                           where (cli.EnAlta == true)
                           select cli;

            return clientes.ToList<Cliente>();
        }
    }
}
