using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioTarifa : Repositorio<TarifaCliente, HotelContext>, IRepositorioTarifa
    {
        public RepositorioTarifa(HotelContext pContext) : base(pContext)
        {

        }

        public TarifaCliente GetTarifaString(string pTipoCliente)
        {
            return this.iDbContext.Tarifas.SingleOrDefault(t => t.TarifaClienteId.ToString() == pTipoCliente);
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
