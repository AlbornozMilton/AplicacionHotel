using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework.Mappings
{
    class ClienteMap:EntityTypeConfiguration<Cliente>
    {
        /// <summary>
        /// Configuraciones de los atributos de Cliente
        /// y de sus relaciones con las clases correspondientes.
        /// </summary>
        public ClienteMap()
        {
            this.Property(c => c.ClienteId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            this.Property(c => c.Legajo)
                .IsOptional();

            this.Property(c => c.Nombre)
                .IsOptional();

            this.Property(c => c.Apellido)
                .IsOptional();

            this.Property(c => c.Telefono)
                .IsOptional();

            this.Property(c => c.Correo)
                .IsOptional();

            this.HasRequired(c => c.TarifaCliente)
                .WithMany(tc => tc.Clientes);

            this.HasOptional(c => c.Domicilio).WithMany(c => c.Clientes);

		}
    }
}
