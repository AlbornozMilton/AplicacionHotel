using System.Data.Entity;
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
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(c => c.Nombre)
                .IsRequired();

            this.Property(c => c.Apellido)
                .IsRequired();

            this.Property(c => c.Telefono)
                .IsRequired();

            this.Property(c => c.Correo)
                .IsOptional();

            this.Property(c => c.TarifaClienteId).IsOptional();
            this.Property(c => c.DomicilioId).IsOptional();
            this.Property(c => c.AlojamientoId).IsOptional();
            // y para indicar que tiene una direccion ???
            this.HasOptional(c => c.TarifaCliente)
                .WithMany(tc => tc.Clientes);

            this.HasOptional(c => c.Domicilio);


            this.HasOptional(c => c.Alojamiento);
                
            // this.HasOptional(c => c.Domicilio);

        }
    }
}
