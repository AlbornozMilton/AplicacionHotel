using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework.Mappings
{
    class CupoMap:EntityTypeConfiguration<Cupo>
    {
        /// <summary>
        /// Configuraciones de los atributos de LineaServicio
        /// y de sus relaciones con las clases correspondientes.
        /// </summary>
        public CupoMap()
        {
            this.Property(c => c.CupoId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.Tipo)
                .IsRequired();

            this.Property(c => c.Disponible)
                .IsRequired();

            //TIPO CUPO como?
        }
    }
}
