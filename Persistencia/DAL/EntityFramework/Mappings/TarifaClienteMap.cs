using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Persistencia.Domain;


namespace Persistencia.DAL.EntityFramework.Mappings
{
    class TarifaClienteMap:EntityTypeConfiguration<TarifaCliente>
    {
        /// <summary>
        /// Configuraciones de los atributos de TarifaCliente
        /// y de sus relaciones con las clases correspondientes.
        /// </summary>
        public TarifaClienteMap()
        {
            this.Property(tc => tc.TarifaClienteId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
                .IsRequired();

            this.Property(tc => tc.Tarifa)
                .IsRequired();

            this.Property(tc => tc.TarifaExclusiva)
                .IsRequired();

            //this.Property(tc => tc.Clientes)
        }
    }
}
