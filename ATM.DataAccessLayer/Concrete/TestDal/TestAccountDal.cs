using ATM.DataAccessLayer.Abstract;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccessLayer.Concrete.TestDal
{
    public class TestAccountDal : IAccountDal
    {
        public bool Delete(Account entity)
        {
            throw new NotImplementedException();
        }

        public Account GetByPrimaryKey(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IList<Account> GetList()
        {
            IList<Account> accounts = new List<Account>();
            accounts.Add(new Account
            {
                Balance = 1,
                Credit = 0,
                Iban = "99999999",
                IsDefault = false,
                Type = Model.Abstract.AccountType.Basic,
                Owner = "tcakir",
            });

            return accounts;
        }

        public bool Insert(Account entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
