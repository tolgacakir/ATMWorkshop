using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.BusinessLogicLayer3.Abstract
{
    public interface IAccountService
    {
        ICollection<Account> GetAccountsByCustomer(Customer customer);
        bool Update(Account account);
        bool Delete(Account account);
    }

}
