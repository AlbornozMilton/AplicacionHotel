using Persistencia.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Persistencia.DAL.EntityFramework.Mappings
{
	class MetadataHotelMap:EntityTypeConfiguration<MetadataHotel>
	{
		public MetadataHotelMap()
		{
			this.Property(m => m.MetadataHotelId)
			   .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
			   .IsRequired();

			this.Property(m => m.Nombre)
				.IsRequired();

			this.Property(m => m.Valor)
				.IsRequired();
		}
	}
}
