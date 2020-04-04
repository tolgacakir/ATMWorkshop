using ATM.BusinessLogicLayer.Abstract;
using ATM.DataAccessLayer.Abstract;
using ATM.DataAccessLayer.Concrete;
using ATM.DataAccessLayer.Concrete.AdoNetDal;
using ATM.DataAccessLayer.Concrete.ORM;
using ATM.DataAccessLayer.Concrete.TestDal;
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
    public class AccountManager : BaseEntityService<IAccountDal>, IAccountService, IEntityLister<Customer, Account>
    {
        IAccountRepository AccountRepository;
        public AccountManager()
        {
            DalObject = new AdoNetAccountDal();
            AccountRepository = new AccountRepository();
        }
        public void Update(Account account)
        {
            DalObject.Update(account);
        }

        public IList<Account> GetList(Customer input)
        {
            IList<Account> accounts = DalObject.GetList()
                .Where(a => a.Owner == input.Username)
                .ToList();
            return accounts;
        }

        public void Delete(Account account)
        {
            DalObject.Delete(account);
        }
    }
}
