using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
	public class RepositorioMetadaHotel: Repositorio<MetadataHotel, HotelContext>, IRepositorioMetadaHotel
	{
		public RepositorioMetadaHotel(HotelContext pContext) : base(pContext)
		{

		}

		public int ObtenerValorMetada(byte pNroMetadata)
		{
			return iDbContext.Metadatas.Find(pNroMetadata).Valor;
		}
	}
}
