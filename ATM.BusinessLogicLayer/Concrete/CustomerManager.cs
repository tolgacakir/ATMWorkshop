using ATM.BusinessLogicLayer.Abstract;
using ATM.Model.Abstract;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BusinessLogicLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        //TODO: customerDal

        public Customer CurrentCustomer { get; private set; }

        public CustomerManager()
        {

        }



        public void ChangePassword(string newPassword)
        {
            throw new NotImplementedException();
        }

        public Customer Login(string username, string password)
        {
            throw new NotImplementedException();

            
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

    }
}
