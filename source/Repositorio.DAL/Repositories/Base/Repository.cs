using Repositorio.DAL.Context;
using Repository.DAL.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.DAL.Repositories.Base
{
    public abstract class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        DatabaseContext ctx = new DatabaseContext();

        public void AddUser(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
        }

        public void ChangeUserProfile(TEntity obj)
        {
            ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
        }

        public void DeleteUser(Func<TEntity, bool> predicate)
        {
            ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => ctx.Set<TEntity>().Remove(del));
        }

        public void Dispose()
        {
            ctx.Dispose();
        }

        public IQueryable<TEntity> DoLogin(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public TEntity Find(params object[] key)
        {
            return ctx.Set<TEntity>().Find(key);
        }

        public IQueryable<TEntity> GetAll()
        {
            return ctx.Set<TEntity>();
        }
    }
}
