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
    }
}
