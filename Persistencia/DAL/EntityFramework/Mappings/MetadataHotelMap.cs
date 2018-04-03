using Persistencia.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Persistencia.DAL.EntityFramework.Mappings
{
	class MetadataHotelMap:EntityTypeConfiguration<MetadataHotel>
	{
		public MetadataHotelMap()
		{
			this.Property(m => m.MetadaId)
			   .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
			   .IsRequired();

			this.Property(m => m.Nombre)
				.IsRequired();

			this.Property(m => m.Valor)
				.IsRequired();
		}
	}
}
