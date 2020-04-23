using ATM.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.BusinessLogicLayer.Abstract
{
    public interface ICustomerService
    {
        Customer Login(string username, string password);
        bool Logout(Customer customer);
        bool ChangePassword(Customer customer);
    }
}
