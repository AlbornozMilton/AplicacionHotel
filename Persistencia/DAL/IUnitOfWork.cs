using System;

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
        IRepositorioHabitacion RepositorioHabitacion { get; }
        IRepositorioServicio RepositorioServicio { get; }
		IRepositorioMetadaHotel RepositorioMetadaHotel { get; }
    }
}
