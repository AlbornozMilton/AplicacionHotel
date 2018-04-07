using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework.Mappings
{
    class HabitacionMap:EntityTypeConfiguration<Habitacion>
    {
        public HabitacionMap()
        {
            this.Property(h => h.HabitacionId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

			this.Property(h => h.Capacidad)
				.IsRequired();

			this.Property(h => h.Planta)
                .IsRequired();

			this.Property(o => o.Ocupada)
				.IsRequired();

			this.Property(a => a.Alta)
				.IsRequired();
		}
    }
}
