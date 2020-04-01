using ATM.BusinessLogicLayer.Abstract;
using ATM.Model.Abstract;
using ATM.Model.Concrete;
using ATM.Model.Concrete.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BusinessLogicLayer.Concrete
{
    public class AccountManager : IAccountService, IEntityLister<Customer, Account>
    {
        public void Update(Account account)
        {
            throw new NotImplementedException();
        }

        public IList<Account> GetList(Customer input)
        {
            throw new NotImplementedException();
        }
    }
}
