﻿using Persistencia.Domain;
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

        //public override IEnumerable<Ciudad> GetAll()
        //{
        //    return iDbContext.Ciudades.Include("Domicilios");
        //}

        public override Ciudad Get(int pId)
        {
            return iDbContext.Ciudades.Include("Domicilios").Single(c => c.CiudadId == pId);
        }
    }
}
