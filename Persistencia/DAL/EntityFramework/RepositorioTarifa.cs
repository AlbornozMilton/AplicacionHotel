using System.Linq;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioTarifa : Repositorio<TarifaCliente, HotelContext>, IRepositorioTarifa
    {
        public RepositorioTarifa(HotelContext pContext) : base(pContext)
        {

        }

        public void ActualizarMontos(TarifaCliente pTarifa)
        {
            TarifaCliente localTarifa = iDbContext.Tarifas.Where(t => t.NombreTarifa == pTarifa.NombreTarifa).SingleOrDefault();
            localTarifa.Tarifa = pTarifa.Tarifa;
            localTarifa.TarifaExclusiva = pTarifa.TarifaExclusiva;
            iDbContext.SaveChanges();
        }
    }
}
