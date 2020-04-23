using ATM.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.BusinessLogicLayer.Abstract
{
    public interface IAccountService
    {
        List<Account> GetAccountsByCustomer(Customer customer);
        
        Account Update(Account account);
        bool Delete(Account account);
    }
}
