using Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business
{
    public abstract class BaseLogic<T, R> : IBaseLogic<T>
        where T : class, new()
        where R : IBaseRepository<T>
    {
        public virtual void Add(T entity)
        {
            throw new NotImplementedException(); // TODO: completar comportamiento cuando se implemente el ORM
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException(); // TODO: completar comportamiento cuando se implemente el ORM
        }

        public virtual IEnumerable<T> GetAll()
        {
            throw new NotImplementedException(); // TODO: completar comportamiento cuando se implemente el ORM
        }

        public virtual T GetById(int id)
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
    }
}
