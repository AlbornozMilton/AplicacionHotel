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
            //Console.WriteLine("Comenzar?");
            //Console.ReadKey();
            HotelContext hc = new HotelContext();
            hc.Set<Usuario>().Add(new Usuario { UsuarioId = "admin", Password = "frcu2017" });
            hc.SaveChanges();
            hc.Dispose(); 
            ////--------------------------------------------------------------//

            //UnitOfWork iUoW = new UnitOfWork(new HotelContext());

            //Ciudad unaCity = new Ciudad
            //{
            //    CiudadId = 3260,
            //    Nombre = "ConcepcionDelUruguay",
            //};

            //Domicilio dom = new Domicilio
            //{
            //    DomicilioId = 78,
            //    Calle = "Al",
            //    Numero = 2,
            //    Piso = 0,
            //    NroDepto = 8,
            //    Ciudad = new Ciudad
            //    { CiudadId = 3206, Nombre = "Federacion" }
            //};

            //iUoW.RepositorioDomicilio.Add(dom);
            //iUoW.Complete();
            //iUoW.Dispose();

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
            //Console.WriteLine("EXITO");
            //Console.ReadKey();
        }
    }
}
