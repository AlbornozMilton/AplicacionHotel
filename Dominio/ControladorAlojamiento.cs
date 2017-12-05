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
    public class ControladorAlojamiento
    {
        UnitOfWork iUoW = new UnitOfWork(new HotelContext());
        public List<Alojamiento> ObtenerAlojamientosActivos() //Devuelve la lista de alojamientos activos mappeandolos de Pers a Dominio
        {
            IEnumerable<pers.Alojamiento> listaEnum = iUoW.RepositorioAlojamiento.GetAllAlojamientosActivos();
            List<Alojamiento> listaAlojamientos = new List<Alojamiento>();
            foreach (var aloj in (listaEnum.ToList<pers.Alojamiento>()))
            {
                listaAlojamientos.Add(Mapper.Map<pers.Alojamiento, Alojamiento>(aloj));
            }
            return (listaAlojamientos);
        }
        
        public void RegistrarReservaAloj(Alojamiento pAlojamiento)
        {
            var e = Mapper.Map<Alojamiento, pers.Alojamiento>(pAlojamiento);
                iUoW.RepositorioAlojamiento.Add(e);
            iUoW.Complete();
            iUoW.Dispose();
        }
    }
}
