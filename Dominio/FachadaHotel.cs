using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;
using Persistencia;


namespace Dominio
{
    static class FachadaHotel
    {
       // static private UnitOfWork iUnitOfWork;

        static FachadaHotel()
        {
            
        }

        static Alojamiento ObtenerAlojamiento(int pId)
        {
            using (UnitOfWork uow = new UnitOfWork(new HotelContext()))
            {
                var perAloj = uow.RepositorioAlojamiento.Get(pId);
                return new Alojamiento(perAloj.FechaEstimadaIngreso, perAloj.FechaEstimadaEgreso);
                uow.Complete();
              //  GC.Collect();
            }
        }

        //static IList<Alojamiento> ObtenerListaAlojamiento()
        //{
        //    using (UnitOfWork uow = new UnitOfWork(new HotelContext()))
        //    {
        //        IList<Alojamiento> iListAloj = new List<Alojamiento>();
        //        var perAloj = uow.RepositorioAlojamiento.GetAll();

        //        foreach (var item in perAloj)
        //        {
        //            iListAloj.Add(item); //crear un metodo que instancie cada alojamieto y lo agregue a la lista
        //        }

        //        return new Alojamiento(perAloj.FechaEstimadaIngreso, perAloj.FechaEstimadaEgreso);
        //        uow.Complete();

        //       // List<Alojamiento> iList = uow.RepositorioAlojamiento.GetAll().ToList(); // no funciona
        //       //  GC.Collect();
        //    }
        //}
    }
}
