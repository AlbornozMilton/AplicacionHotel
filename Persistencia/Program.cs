using Persistencia.DAL.EntityFramework;
using Persistencia.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comenzar?");
            Console.ReadKey();

            //--------------------------------------------------------------//

            UnitOfWork iUoW = new UnitOfWork(new HotelContext());
            HotelContext db = new HotelContext();

            Ciudad unaCity = new Ciudad
            {
                Nombre = "ConcepcionDelUruguay",
            };
            //db.Ciudad.Add(unaCity);
            //db.SaveChanges();

            iUoW.RepositorioCiudad.Add(unaCity);
            iUoW.Complete();

            //---------------------------------------------------------------//

            //db.Ciudad.Add(unaCity);

            //var unaIm = db.Imagen.Include("Campania").Where(a => a.Id==1).FirstOrDefault<Imagen>();
            //Console.WriteLine("{0} {1} {2}", unaIm.Nombre, unaIm.Id, unaIm.Campania.Nombre);

            //Campania unaCamp = db.Campania.Find(1);
            //List<Imagen> lista = unaCamp.Imagenes.ToList();

            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item.Nombre);
            //}

            //db.Campania.Remove(db.Campania.Find(1));
            //db.SaveChanges();
            Console.WriteLine("EXITO");
            Console.ReadKey();
        }
    }
}
