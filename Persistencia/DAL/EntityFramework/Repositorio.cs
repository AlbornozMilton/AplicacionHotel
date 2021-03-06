﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Persistencia.DAL.EntityFramework
{
    public abstract class Repositorio <TEntity, TDbContext> : IRepositorio<TEntity> 
        where TEntity: class
        where TDbContext:DbContext
    {
        public Repositorio(TDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new ArgumentNullException(nameof(pDbContext));
            }
            this.iDbContext = pDbContext;
        }

        protected readonly TDbContext iDbContext;

        //IMPLEMENTACION IREPOSITORIO
        public virtual void Add(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }
            this.iDbContext.Set<TEntity>().Add(pEntity);
        }

        public void Remove(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Remove(pEntity);
        }

        public virtual TEntity Get(int pId)
        {
            return this.iDbContext.Set<TEntity>().Find(pId);
        }

        /// <summary>
        /// Este método para los Clientes, retorna Clientes en Alta y en Baja
        /// </summary>
        public virtual IEnumerable<TEntity> GetAll()
        {
            return this.iDbContext.Set<TEntity>().ToList();
        }
    }
}
