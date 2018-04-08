using Persistencia.Domain;

namespace Persistencia.DAL
{
    public interface IRepositorioTarifa : IRepositorio<TarifaCliente>
    {
        void ActualizarMontos(TarifaCliente pTarifa);
    }
}
