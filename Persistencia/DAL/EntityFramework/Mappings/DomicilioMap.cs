using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework.Mappings
{
    class DomicilioMap:EntityTypeConfiguration<Domicilio>
    {
        /// <summary>
        /// Configuraciones de los atributos de Domicilio
        /// y de sus relaciones con las clases correspondientes.
        /// </summary>
        public DomicilioMap()
        {
            this.Property(d => d.DomicilioId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            this.Property(d => d.Calle)
                .IsRequired();

            this.Property(d => d.Numero)
                .IsRequired();

            this.Property(d => d.Piso)
                .IsOptional();

            this.Property(d => d.NroDepto)
                .IsOptional();

            this.HasRequired(d => d.Ciudad)
                .WithMany(c => c.Domicilios);

        }
    }
}
