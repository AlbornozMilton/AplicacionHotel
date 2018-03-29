using Persistencia.Domain;

namespace Persistencia.DAL
{
    public interface IRepositorioTarifa : IRepositorio<TarifaCliente>
    {
        TarifaCliente GetTarifaString(string pTipoCliente);
        void ActualizarMontos(TarifaCliente pTarifa);
    }
}
