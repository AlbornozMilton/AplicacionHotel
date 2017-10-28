﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL
{
    interface IUnitOfWork: IDisposable
    {
        // IDisposable: interfaz para liberar recursos
        // las clases que usen IUnitOfWork tambien deblen implementar la interfaz IDisponsable

        //  metodo que se debe implementar para realizar commits (confirmaciones - save changes)
        void Complete();

        // getters que se deben implemetar al usar la interfaz IUnitOfWork
        IRepositorioCliente RepositorioCliente { get; }

        IRepositorioAlojamiento RepositorioAlojamiento { get; }

        IRepositorioCiudad RepositorioCiudad { get; }

        IRepositorioUsuario RepositorioUsuario { get; }

        IRepositorioDomicilio RepositorioDomicilio { get; }
    }
}
