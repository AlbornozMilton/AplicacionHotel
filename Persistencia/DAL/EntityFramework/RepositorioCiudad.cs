using Persistencia.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioCiudad : Repositorio<Ciudad, HotelContext>, IRepositorioCiudad
    {
        public RepositorioCiudad(HotelContext pContext) : base(pContext)
        {

        }

        //public 
    }
}
