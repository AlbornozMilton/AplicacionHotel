using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    class RepositorioCliente : IRepositorioCliente
    {
        public void Add(Cliente pEntity)
        {
            throw new NotImplementedException();
        }

        public Cliente Get(int pId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Cliente pEntity)
        {
            throw new NotImplementedException();
        }
    }
}
