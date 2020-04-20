using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ATM.DataAccessLayer3.Abstract
{
    public interface IRepository<T>
        where T: class, IEntity, new()
    {
        IUnitOfWork UnitOfWork { get; }

        T First(Expression<Func<T, bool>> filter);
        
        T Find(Expression<Func<T, bool>> filter);
        
        IQueryable<T> Where(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);

        bool Any(Expression<Func<T, bool>> filter = null);
        
        int Count(Expression<Func<T, bool>> filter = null);

        IQueryable<TResult> Select<TResult>(Expression<Func<T, TResult>> selector);

        IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);

        IEnumerable<T> GetAll();

        void ChangeEntityState(T entity, EntityState state);

        Type GetEntityType();
    }
}
