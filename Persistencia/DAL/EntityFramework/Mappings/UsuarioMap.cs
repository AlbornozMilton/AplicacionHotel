using Persistencia.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Persistencia.DAL.EntityFramework.Mappings
{
    class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        /// <summary>
        /// Configuraciones de los atributos de Usuario
        /// </summary>
        public UsuarioMap()
        {
            this.Property(c => c.UsuarioId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
                .IsRequired();

            this.Property(c => c.Password)
                .IsRequired();
        }
    }
}
