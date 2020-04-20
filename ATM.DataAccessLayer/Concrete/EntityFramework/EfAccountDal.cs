using ATM.DataAccessLayer.Abstract;
using ATM.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using TFramework.Core.DataAccess.EntityFramework;

namespace ATM.DataAccessLayer.Concrete.EntityFramework
{
    public class EfAccountDal : EfBaseEntityRepository<Account, AtmContext>, IAccountDal
    {
    }
}
