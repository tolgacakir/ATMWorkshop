using ATM.Model.Abstract;
using System.Collections.Generic;

namespace ATM.DataAccessLayer2.Abstract.GenericRepositories
{
    public interface IGenericRepository<T>
        where T : IEntity
    {
        IList<T> GetList();
        void Delete(T entity);
        void Update(T entity);
        void Insert(T entity);
    }
}
