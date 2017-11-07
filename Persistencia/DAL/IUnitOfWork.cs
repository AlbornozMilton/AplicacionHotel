using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL
{
    interface IUnitOfWork: IDisposable
    {
        void Complete();

        IRepositorioAlojamiento RepositorioAlojamiento { get; }

        IRepositorioCiudad RepositorioCiudad { get; }

        IRepositorioCliente RepositorioCliente { get; }

        IRepositorioDomicilio RepositorioDomicilio { get; }
        
        IRepositorioTarifa RepositorioTarifa { get; }

        IRepositorioUsuario RepositorioUsuario { get; }

    }
}
