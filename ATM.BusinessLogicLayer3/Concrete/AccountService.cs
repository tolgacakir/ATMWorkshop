using ATM.BusinessLogicLayer3.Abstract;
using ATM.DataAccessLayer3.Abstract;
using ATM.DataAccessLayer3.Concrete;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ATM.BusinessLogicLayer3.Concrete
{
    public class AccountService : IAccountService
    {
        public AccountService()
        {
            
        }

        public bool Delete(Account account)
        {
            int result = 0;
            using (IUnitOfWork uow = new EfUnitOfWork(new AtmDbContent()))
            {
                uow.Accounts.ChangeEntityState(account, EntityState.Deleted);
                result = uow.SaveChanges();
            }
            return result > 0;
        }

        public ICollection<Account> GetAccountsByCustomer(Customer customer)
        {
            ICollection<Account> accounts = null;
            using (IUnitOfWork uow = new EfUnitOfWork(new AtmDbContent()))
            {
                accounts = uow.Accounts
                    .Where(a => a.Owner == customer.Username).ToList();
            }
            return accounts;
        }

        public bool Update(Account account)
        {
            int result = 0;
            using (IUnitOfWork uow = new EfUnitOfWork(new AtmDbContent()))
            {
                uow.Accounts.ChangeEntityState(account, EntityState.Modified);
                result = uow.SaveChanges();
            }
            return result > 0;
        }
    }
}
