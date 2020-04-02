using ATM.BusinessLogicLayer.Abstract;
using ATM.DataAccessLayer.Concrete;
using ATM.DataAccessLayer.Concrete.GenericRepository;
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
    public class AccountManager : BaseEntityService<AccountRepository>, IAccountService, IEntityLister<Customer, Account>
    {
        public AccountManager()
        {
            DataAccessObject = new AccountRepository();
        }
        public void Update(Account account)
        {
            DataAccessObject.Update(account);
        }

        public IList<Account> GetList(Customer input)
        {
            IList<Account> accounts = DataAccessObject.GetList()
                .Where(a => a.Owner == input.Username)
                .ToList();
            return accounts;
        }

        public void Delete(Account account)
        {
            DataAccessObject.Delete(account);
        }
    }
}
