using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
	public class RepositorioMetadaHotel: Repositorio<MetadataHotel, HotelContext>, IRepositorioMetadaHotel
	{
		public RepositorioMetadaHotel(HotelContext pContext) : base(pContext)
		{

		}

		public int ObtenerValorMetada(TipoMetadaHotel pTipo)
		{
			return iDbContext.Metadatas.Find(pTipo).Valor;
		}
	}
}
