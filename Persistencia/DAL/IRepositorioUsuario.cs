﻿using Persistencia.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL
{
    public interface IRepositorioUsuario:IRepositorio<Usuario>
    {
        bool Existe(string pUs, string pPass);
    }
}
