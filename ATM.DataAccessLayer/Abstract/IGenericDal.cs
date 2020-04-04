using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
        where T:IEntity
    {
        IList<T> GetList();
        T GetByPrimaryKey(object primaryKey);
        bool Update(T entity);
        bool Delete(T entity);
        bool Insert(T entity);
    }
}
