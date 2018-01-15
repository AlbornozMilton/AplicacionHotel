using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.DAL.EntityFramework;
using pers = Persistencia.Domain;
using AutoMapper;

namespace Dominio
{
    public class ControladorExtra
    {
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());

        public List<Servicio> ObtenerServicios()
        {
            IEnumerable<pers.Servicio> listaEnum = iUoW.RepositorioServicio.GetAll();
            List<Servicio> lista = new List<Servicio>();

            foreach (var serv in listaEnum)
            {
                lista.Add(Mapper.Map<pers.Servicio, Servicio>(serv));
            }
            return (lista);
        }
    }
}
