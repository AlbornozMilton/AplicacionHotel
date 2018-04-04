using Persistencia.Domain;

namespace Persistencia.DAL
{
	public interface IRepositorioMetadaHotel:IRepositorio<MetadataHotel>
	{
		int ObtenerValorMetada(byte pNroMetadata);
	}
}
