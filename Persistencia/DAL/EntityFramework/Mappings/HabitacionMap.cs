using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework.Mappings
{
    class HabitacionMap:EntityTypeConfiguration<Habitacion>
    {
        /// <summary>
        /// Configuraciones de los atributos de Habitacion
        /// y de sus relaciones con las clases correspondientes.
        /// </summary>
        public HabitacionMap()
        {
            this.Property(h => h.HabitacionId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(h => h.Capacidad)
                .IsRequired();

            this.Property(h => h.Planta)
                .IsRequired();

            this.Property(h => h.Exclusiva)
                .IsRequired();
        }
    }
}
