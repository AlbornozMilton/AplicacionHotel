using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.EntityFramework
{
    class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork()
        {
        }

        public IRepositorioCliente RepositorioCliente
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepositorioAlojamiento RepositorioAlojamiento
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
