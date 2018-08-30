using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework.Mappings
{
	class AlojHabsMap:EntityTypeConfiguration<AlojHab>
	{
		public AlojHabsMap()
		{
			this.Property(a => a.AlojHabId)
				.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
				.IsRequired();

			this.Property(a => a.Exclusividad)
				.IsRequired();

			this.HasRequired(h => h.Alojamiento)
			   .WithMany(a => a.AlojHabes);

			this.HasRequired(h => h.Habitacion)
			   .WithMany(h => h.AlojHabs);

            this.HasMany(h => h.Clientes)
                .WithMany(c => c.AlojHabs)
                .Map(hc => hc.ToTable("AHC_Id"));

            this.HasMany(h => h.Tarifas)
                .WithMany(c => c.AlojHabs)
                .Map(hc => hc.ToTable("AHT_Id"));
        }
    }
}
