using ATM.DataAccessLayer.Abstract;
using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccessLayer.Concrete.GenericRepository
{
    public class GenericRepository : IGenericRepository<IEntity>
    {
        public bool Delete(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEntity GetByPrimaryKey(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IList<IEntity> GetList()
        {
            throw new NotImplementedException();
        }

        public bool Insert(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
