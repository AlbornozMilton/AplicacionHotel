using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework.Mappings
{
    class ServicioMap : EntityTypeConfiguration<Servicio>
    {
        public ServicioMap()
        {
            this.Property(l => l.ServicioId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(l => l.CostoBase)
                .IsRequired();

            this.Property(l => l.Nombre)
                .IsRequired();

            this.Property(f => f.Detalle).IsRequired();
        }
    }
}
