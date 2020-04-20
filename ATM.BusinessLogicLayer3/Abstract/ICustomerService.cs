using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.BusinessLogicLayer3.Abstract
{
    public interface ICustomerService
    {
        Customer Login(string username, string password);
        bool Logout(Customer customer);
        bool ChangePassword(Customer customer, string newPassword);
    }
}
