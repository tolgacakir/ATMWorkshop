using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccessLayer.Concrete.ORM
{
    public interface IRepository<T>
        where T:IEntity
    {
        IList<T> GetList();
        void Delete(T entity);
        void Update(T entity);
        void Insert(T entity);
    }
}
