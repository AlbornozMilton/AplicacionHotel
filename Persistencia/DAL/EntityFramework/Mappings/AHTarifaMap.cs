using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework.Mappings
{
    class AHTarifaMap: EntityTypeConfiguration<AHTarifa>
    {
        public AHTarifaMap()
        {
            this.Property(c => c.AHTarifaId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);


            //this.Property(c => c.AlojHabId)
            //    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            //this.HasRequired(c => c.TarifaClienteId).

            //this.HasRequired(c => c.AlojHab).
            //    WithMany(c => c.Tarifas);
        }
    }
}
