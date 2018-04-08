using System.Data.Entity;
using Persistencia.Domain;
using Persistencia.DAL.EntityFramework.Mappings;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Persistencia.DAL.EntityFramework
{
    public class HotelContext: DbContext
    {
        public HotelContext():base ("HotelBD")
        {
            Database.SetInitializer<HotelContext>(new DatabaseInitializationStrategy());
        }

        //ATRIBUTOS       
        public virtual DbSet<Alojamiento> Alojamientos { get; set; }
        public virtual DbSet<Ciudad> Ciudades { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Domicilio> Domicilios { get; set; }
        public virtual DbSet<Habitacion> Habitaciones { get; set; }
        public virtual DbSet<LineaServicio> LineaServicios { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<TarifaCliente> Tarifas { get; set; }
		public virtual DbSet<MetadataHotel> Metadatas { get; set; }
		public virtual DbSet<AlojHab> AlojHabs { get; set; }

        protected override void OnModelCreating(DbModelBuilder mBuilder)
        {
            mBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Elimina las "s" y "es" del nombre de las clases.
            //Mappigs de las configuraciones de las Clases
            mBuilder.Configurations.Add(new AlojamientoMap());
            mBuilder.Configurations.Add(new CiudadMap());
            mBuilder.Configurations.Add(new ClienteMap());
            mBuilder.Configurations.Add(new DomicilioMap());
            mBuilder.Configurations.Add(new HabitacionMap());
            mBuilder.Configurations.Add(new LineaServicioMap());
            mBuilder.Configurations.Add(new PagoMap());
            mBuilder.Configurations.Add(new TarifaClienteMap());
            mBuilder.Configurations.Add(new UsuarioMap());
			mBuilder.Configurations.Add(new MetadataHotelMap());
			mBuilder.Configurations.Add(new AlojHabsMap());
            base.OnModelCreating(mBuilder);
        }
    }
}
