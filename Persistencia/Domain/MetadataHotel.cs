namespace Persistencia.Domain
{
	public class MetadataHotel
	{
		public TipoMetadaHotel MetadataHotelId { get; set; }

		public int Valor { get; set; }
	}
	
	public enum TipoMetadaHotel
	{
		PorcentajeExclusividad,
		PorcentajeTour
	}
}
