﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Domain;

namespace Persistencia.DAL.EntityFramework
{
    public class RepositorioCliente : Repositorio<Cliente, HotelContext>, IRepositorioCliente
    {
        public RepositorioCliente(HotelContext pContext) : base(pContext)
        {

        }
        public bool Existe(Cliente pCliente)
        {
            if ((base.iDbContext.Set<Cliente>().Find(pCliente.ClienteId)!=null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
