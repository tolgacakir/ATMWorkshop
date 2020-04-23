using ATM.DataAccessLayer.Abstract;
using ATM.Entites.Complex;
using ATM.Entites.Concrete;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using TFramework.Core.DataAccess.EntityFramework;

namespace ATM.DataAccessLayer.Concrete.EntityFramework
{
    public class EfAccountDal : EfBaseEntityRepository<Account, AtmContext>, IAccountDal
    {
        public List<AccountDetail> GetAccountDetails()
        {
            using (var context = new AtmContext())
            {
                var result = from a in context.Accounts
                             join c in context.Customers on a.Owner equals c.Username
                             select new AccountDetail
                             {
                                 FirstName = c.FirstName,
                                 LastName = c.LastName,
                                 Iban = a.Iban,
                             };
                return result.ToList();
            }
        }
    }
}
