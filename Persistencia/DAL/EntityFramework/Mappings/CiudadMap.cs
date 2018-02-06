using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework.Mappings
{
    class CiudadMap:EntityTypeConfiguration<Ciudad>
    {
        /// <summary>
        /// Configuraciones de los atributos de Ciudad
        /// y de sus relaciones con las clases correspondientes.
        /// </summary>
        public CiudadMap()
        {
			this.Property(c => c.CiudadId)
				.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

			this.Property(c => c.CodPostal)
				.IsRequired();

			this.Property(c => c.Nombre)
                .IsRequired();
        }
    }
}
