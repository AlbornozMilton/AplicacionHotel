using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;
using System.Data.Entity;

namespace Persistencia.DAL.EntityFramework
{
    internal class HotelContext:DbContext
    {
        //atributos 
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Alojamiento> Alojamientos { get; set; }

        public HotelContext() : base("HotelDB")
        {
            //Se establece la estrategia personalizada de inicialización de la BBDD.

            Database.SetInitializer<HotelContext>(new CreateDatabaseIfNotExists<HotelContext>());
            //Database.SetInitializer<AccountManagerDbContext>(new DropCreateDatabaseIfModelChanges<AccountManagerDbContext>());
            //Database.SetInitializer<AccountManagerDbContext>(new DropCreateDatabaseAlways<AccountManagerDbContext>());

            //DatabaseInitializationStrategy es una clase nuestra que carga de datos predefinida de pruba desde dicha calse
            // y ademas utiliza un inicalizar por defecto mencionados anteriormente
            //Database.SetInitializer<HotelContext>(new DatabaseInitializationStrategy());
        }

        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            //cargar mapeo
            //pModelBuilder.Configurations.Add(new ClientMap());
            base.OnModelCreating(pModelBuilder);
        }
    }
}
