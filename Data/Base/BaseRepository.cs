using Data.Base;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Web.Script.Serialization;

namespace Data
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
        where T : class, new()
    {

        private IContext _context;

        public IContext Context
        {
            get {
                if(this._context == null)
                    this._context = this.LoadContext();
                return this._context;
            }
        }


        public BaseRepository()
        {
            
        }

        public IContext LoadContext()
        {
            var context = new Context();

            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("http://www.mocky.io/v2/580891a4100000e8242b75c5");

                context.PolicyResult = new JavaScriptSerializer().Deserialize<PolicyResultDto>(json);

                var clientJS = wc.DownloadString("http://www.mocky.io/v2/5808862710000087232b75ac");

                context.ClientResult = new JavaScriptSerializer().Deserialize<ClientResultDto>(clientJS);
            }
            return context;
        }


        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public virtual T Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual T Add(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
