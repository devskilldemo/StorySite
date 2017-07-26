using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace StorySite.Data
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null);
        IEnumerable<TEntity> Get(out int total, out int totalDisplay, Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null, int pageIndex = 1, int pageSize = 10);
        TEntity GetByID(object id);
        int GetCount(Expression<Func<TEntity, bool>> filter = null);
        void Insert(TEntity entity);
        void Update(TEntity entityToUpdate);
    }
}