using ATM.DataAccessLayer3.Abstract;
using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ATM.DataAccessLayer3.Base
{
    public abstract class BaseEfRepository<T> : IRepository<T>
        where T : class, IEntity, new()
    {

        public IUnitOfWork UnitOfWork { get; set; }
        private DbSet<T> _table;
        internal DbSet<T> Table
        {
            get { return _table ?? (_table = UnitOfWork.CreateDbSetInstance<T>()); }
        }

        public IEnumerable<T> GetAll()
        {

            return Table.ToList();
        }

        public T Find(Expression<Func<T, bool>> filter)
        {
            return Table.Find(filter);
        }

        public T First(Expression<Func<T, bool>> filter)
        {
            return Table.First(filter);
        }

        public bool Any(Expression<Func<T, bool>> filter = null)
        {
            return Table.Any(filter);
        }


        public void ChangeEntityState(T entity, EntityState state)
        {
            UnitOfWork.Context.Entry(entity).State = state;
            
        }

        public int Count(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? Table.Count() : Table.Count(filter);
        }

        

        

        public IQueryable<TResult> Select<TResult>(Expression<Func<T, TResult>> selector)
        {
            return Table.Select(selector);
        }

        public IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return Table.Where(filter).Select(selector);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            return orderBy == null ? Table.Where(filter) : orderBy(Table.Where(filter));
        }

        public Type GetEntityType()
        {
            return typeof(T);
        }
    }
}
