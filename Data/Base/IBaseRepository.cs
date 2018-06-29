using Data.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Data
{
    public interface IBaseRepository<T>
        where T : class, new()
    {
         IContext Context { get; }
        IContext LoadContext();

        T Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void RemoveById(int id);
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T Update(T entity);

    }
}
