using Persistencia.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
