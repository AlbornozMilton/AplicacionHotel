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
            return this.iDbContext.Tarifas.Single(t => t.TarifaClienteId.ToString() == pTipoCliente);
        }

        public void ActualizarMontos(TarifaCliente pTarifa)
        {
            TarifaCliente localTarifa = iDbContext.Tarifas.Find(pTarifa.NombreTarifa);
            localTarifa.Tarifa = pTarifa.Tarifa;
            localTarifa.TarifaExclusiva = pTarifa.TarifaExclusiva;
            iDbContext.SaveChanges();
        }

        //public TarifaCliente GetString(TipoCliente pTipoCliente)
        //{
        //    //var tarifa = from tar in this.iDbContext.Tarifas
        //    //               where (tar.NombreTipo == pTipoCliente)
        //    //               select tar;

        //    //return tarifa;
        //    TipoCliente.AcompanianteDirecto.ToString("23asd");
        //    //return this.iDbContext.Tarifas. Tipo;
        //}
    }
}
