using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL
{
    //una iterfaz que ademas implementa la interfaz IRepository
    //El generico se pasa una clase (Client) como indica la interfa IRepository
    public interface IRepositorioCliente : IRepositorio<Cliente>
    {
        //Esta interfaz se especifica que el resositorio va a ser sobre clientes "Client" al indicar IRepository<Client>
        bool Existe(Cliente pCliente);

        IEnumerable<Cliente> ObtenerClientesPorNomyAp(string pNombre);

    }

}
