using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework.Mappings
{
    class PagoMap:EntityTypeConfiguration<Pago>
    {
        /// <summary>
        /// Configuraciones de los atributos de Pago
        /// y de sus relaciones con las clases correspondientes.
        /// </summary>
        public PagoMap()
        {
            this.Property(p => p.PagoId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(p => p.Tipo)
                .IsRequired();

            this.Property(p => p.Monto)
                .IsRequired();

            this.Property(p => p.FechaPago).HasColumnType("datetime2")
                .IsRequired();

            this.Property(p => p.Detalle)
                .IsOptional();

            this.HasRequired(p => p.Alojamiento)
                .WithMany(a => a.Pagos);
        }
    }
}
