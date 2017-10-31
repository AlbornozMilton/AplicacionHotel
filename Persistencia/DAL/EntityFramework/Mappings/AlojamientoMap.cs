using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;


namespace Persistencia.DAL.EntityFramework.Mappings
{
    class AlojamientoMap:EntityTypeConfiguration<Alojamiento>
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

            this.Property(a => a.FechaReserva)
                .IsOptional();

            this.Property(a => a.FechaEstimadaIngreso)
                .IsOptional();

            this.Property(a => a.FechaEstimadaEgreso)
                .IsRequired();

            this.Property(a => a.FechaIngreso)
                .IsOptional();

            this.Property(a => a.FechaEgreso)
                .IsOptional();

            this.HasRequired(a => a.Habitacion)
                .WithMany(h => h.Alojamientos);

            this.HasMany<Cliente>(a => a.Clientes)
                .WithMany(c => c.Alojamientos)
                .Map(tabla =>
               {
                   tabla.ToTable("Alojamiento_Cliente");
               });
            
            //Estado ALojamiento como??
        }
    }
}
