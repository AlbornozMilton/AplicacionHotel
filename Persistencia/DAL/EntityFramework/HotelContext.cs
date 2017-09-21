using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entuty;

namespace Persistencia.DAL.EntityFramework
{
    internal class HotelContext:DbContext;
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Alojamiento> Clientes { get; set; }

        public HotelContext() : base("HotelDB");
        {
            Database.SetInitializer<AccountManagerDbContext>(new CreateDatabaseIfNotExists<AccountManagerDbContext>());
            //Database.SetInitializer<AccountManagerDbContext>(new DropCreateDatabaseIfModelChanges<AccountManagerDbContext>());
            //Database.SetInitializer<AccountManagerDbContext>(new DropCreateDatabaseAlways<AccountManagerDbContext>());

            // Se establece la estrategia personalizada de inicialización de la BBDD.
            // DatabaseInitializationStrategy: carga de datos predefinida en dicha clase
         //   Database.SetInitializer<AccountManagerDbContext>(new DatabaseInitializationStrategy());
        }
    }
}
