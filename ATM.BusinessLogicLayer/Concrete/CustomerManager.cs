using ATM.BusinessLogicLayer.Abstract;
using ATM.DataAccessLayer.Abstract;
using ATM.DataAccessLayer.Concrete;
using ATM.DataAccessLayer.Concrete.AdoNetDal;
using ATM.DataAccessLayer.Concrete.TestDal;
using ATM.Model.Abstract;
using ATM.Model.Concrete;
using ATM.Model.Concrete.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BusinessLogicLayer.Concrete
{
    public class CustomerManager :BaseEntityService<ICustomerDal>, ICustomerService
    {
        public Customer CurrentCustomer { get; private set; }

        public CustomerManager()
        {
            DalObject = new AdoNetCustomerDal();
        }



        public void ChangePassword(string newPassword)
        {
            throw new NotImplementedException();
        }

        public Customer Login(string username, string password)
        {
            Customer customer = DalObject.Login(username,password);
            if(customer == null)
            {
                throw new CustomerCouldNotFindException();
            }
            else if (customer.Password != password)
            {
                throw new WrongPasswordException();
            }
            else
            {
                return customer;
            }
            
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

    }
}
