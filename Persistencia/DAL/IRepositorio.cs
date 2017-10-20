using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        //metodos que todos lo repositorios deben implementar
        void Add(TEntity pEntity);
        void Remove(TEntity pEntity);
        ////metodos getters
        TEntity Get(int pId);
        IEnumerable<TEntity> GetAll();

        //otros metodos comunes
    }
}
