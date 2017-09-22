using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework.Mappings
{
    class LineaServicioMap:EntityTypeConfiguration<LineaServicio>
    {
        /// <summary>
        /// Configuraciones de los atributos de LineaServicio
        /// y de sus relaciones con las clases correspondientes.
        /// </summary>
        public LineaServicioMap()
        {
            this.Property(l => l.LineaServicioId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(l => l.Cantidad)
                .IsRequired();

            this.Property(l => l.CostoServicio)
                .IsRequired();

            //falta Relacion con servicio
        }
    }
}
