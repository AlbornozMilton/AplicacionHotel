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
