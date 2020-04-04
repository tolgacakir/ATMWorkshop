using ATM.DataAccessLayer.Abstract;
using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BusinessLogicLayer.Abstract
{
    public class BaseEntityService<T>
        //where T: IGenericRepository<IEntity>
    {
        protected T DalObject;
        //protected string ConnectionString;
    }
}
