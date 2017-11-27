using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework.Mappings
{
    class LineaServicioMap:EntityTypeConfiguration<LineaServicio>
    {
        public LineaServicioMap()
        {
            this.Property(l => l.LineaServicioId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(l => l.Cantidad)
                .IsRequired();

            this.Property(l => l.CostoServicio)
                .IsRequired();

            this.Property(f => f.FechaServicio).HasColumnType("Date").IsRequired();

            this.HasRequired(p => p.Alojamiento)
                .WithMany(a => a.Servicios);
            
        }
    }
}
