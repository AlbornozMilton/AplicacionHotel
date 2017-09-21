using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Persistencia.DAL.EntityFramework
{
    abstract class Repositorio<TEntity, TDbContext> : IRepositorio<TEntity> where TEntity : class where TDbContext : DbContext
    {
        protected readonly TDbContext iDbContext;

        //Constructor
        /// <summary>
        /// Asigna un contexto a su atributo privado
        /// </summary>
        /// <param name="pContext" type=DbContext></param>
        public Repositorio(TDbContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }

            this.iDbContext = pContext;
        }

        //implemetacion IRepositorio
        public void Add(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Add(pEntity);
        }

        /// <summary>
        /// Obtiene una entidad por clave primaria
        /// </summary>
        /// <param name="pId" type=int></param>
        /// <returns><TEntity></returns>
        public TEntity Get(int pId)
        {
            return this.iDbContext.Set<TEntity>().Find(pId);
        }

        /// <summary>
        /// Retorna una lista de TEntity
        /// </summary>
        /// <returns>List<TEntity></returns>
        public IEnumerable<TEntity> GetAll()
        {
            return this.iDbContext.Set<TEntity>().ToList();
        }

        public void Remove(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Remove(pEntity);
        }
    }
}
