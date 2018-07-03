using Data.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Data
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
        where T : class, new()
    {

        protected IContext Context { get; set; }


        public BaseRepository(IContext context)
        {
            this.Context = context;
        }


        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException(); // TODO: completar comportamiento cuando se implemente el ORM
        }

        public virtual IEnumerable<T> GetAll()
        {
            throw new NotImplementedException(); // TODO: completar comportamiento cuando se implemente el ORM
        }

        public virtual void Remove(T entity)
        {
            throw new NotImplementedException(); // TODO: completar comportamiento cuando se implemente el ORM
        }

        public virtual void RemoveById(int id)
        {
            throw new NotImplementedException(); // TODO: completar comportamiento cuando se implemente el ORM
        }

        public virtual T Update(T entity)
        {
            throw new NotImplementedException(); // TODO: completar comportamiento cuando se implemente el ORM
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException(); // TODO: completar comportamiento cuando se implemente el ORM
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException(); // TODO: completar comportamiento cuando se implemente el ORM
        }

        public virtual T Get(int id)
        {
            throw new NotImplementedException(); // TODO: completar comportamiento cuando se implemente el ORM
        }

        public virtual T Add(T entity)
        {
            throw new NotImplementedException(); // TODO: completar comportamiento cuando se implemente el ORM
        }
    }
}
