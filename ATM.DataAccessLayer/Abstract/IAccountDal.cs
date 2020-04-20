using ATM.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using TFramework.Core.DataAccess;

namespace ATM.DataAccessLayer.Abstract
{
    public interface IAccountDal : IEntityRepository<Account>
    {
    }
}
