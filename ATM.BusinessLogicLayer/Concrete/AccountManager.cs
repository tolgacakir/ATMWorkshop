using ATM.BusinessLogicLayer.Abstract;
using ATM.DataAccessLayer.Abstract;
using ATM.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.BusinessLogicLayer.Concrete
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;

        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public List<Account> GetAccountsByCustomer(Customer customer)
        {
            return _accountDal.GetList(a => a.Owner == customer.Username);
        }

        public Account Update(Account account)
        {
            return _accountDal.Update(account);
        }

        public bool Delete(Account account)
        {
            return _accountDal.Delete(account);
        }
    }
}
