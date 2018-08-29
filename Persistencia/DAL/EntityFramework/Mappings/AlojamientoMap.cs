using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;


namespace Persistencia.DAL.EntityFramework.Mappings
{
    public class AlojamientoMap:EntityTypeConfiguration<Alojamiento>
    {
        /// <summary>
        /// Configuraciones de los atributos de Alojamiento
        /// y de sus relaciones con las clases correspondientes.
        /// </summary>
        public AlojamientoMap()
        {
            this.Property(a => a.AlojamientoId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(a => a.DniResponsable)
                .IsRequired();

            this.Property(a => a.FechaAloj).HasColumnType("datetime2")
               .IsRequired();

            this.Property(a => a.FechaReserva).HasColumnType("datetime2")
                .IsOptional();

            this.Property(a => a.FechaEstimadaIngreso).HasColumnType("datetime2")
                .IsOptional();

            this.Property(a => a.FechaEstimadaEgreso).HasColumnType("datetime2")
                .IsOptional();

            this.Property(a => a.FechaIngreso).HasColumnType("datetime2")
                .IsOptional();

            this.Property(a => a.FechaEgreso).HasColumnType("datetime2")
                .IsOptional();

			this.Property(a => a.FechaCancelacion).HasColumnType("datetime2")
				.IsOptional();

            this.Property(e => e.EstadoAlojamiento).IsRequired();
        }
    }
}
