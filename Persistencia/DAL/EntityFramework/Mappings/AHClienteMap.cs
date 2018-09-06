using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework.Mappings
{
    class AHClienteMap : EntityTypeConfiguration<AHCliente>
    {
        public AHClienteMap()
        {
            this.Property(c => c.AHClienteId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            //this.HasRequired(c => c.Cliente).
            //   WithMany(c => c.AlojHabs);

            //this.HasRequired(c => c.AlojHab).
            //    WithMany(c => c.Clientes);
        }
    }
}
