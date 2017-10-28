using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public virtual DbSet<Alojamiento> Alojamiento { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Cupo> Cupo { get; set; }
        public virtual DbSet<Domicilio> Domicilio { get; set; }
        public virtual DbSet<Habitacion> Habitacion { get; set; }
        public virtual DbSet<LineaServicio> LineaServicio { get; set; }
        public virtual DbSet<Pago> Pago { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder mBuilder)
        {
            mBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Elimina las "s" y "es" del nombre de las clases.
            //Mappigs de las configuraciones de las Clases
            mBuilder.Configurations.Add(new AlojamientoMap());
            mBuilder.Configurations.Add(new CiudadMap());
            mBuilder.Configurations.Add(new ClienteMap());
            mBuilder.Configurations.Add(new CupoMap());
            mBuilder.Configurations.Add(new DomicilioMap());
            mBuilder.Configurations.Add(new HabitacionMap());
            mBuilder.Configurations.Add(new LineaServicioMap());
            mBuilder.Configurations.Add(new PagoMap());
            mBuilder.Configurations.Add(new TarifaClienteMap());
            mBuilder.Configurations.Add(new UsuarioMap());

            base.OnModelCreating(mBuilder);
        }


    }
}
