using ATM.BusinessLogicLayer.Abstract;
using ATM.DataAccessLayer.Concrete;
using ATM.Model.Abstract;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BusinessLogicLayer.Concrete
{
    public class CustomerManager :BaseEntityService<CustomerRepository>, ICustomerService
    {
        //TODO: customerDal

        public Customer CurrentCustomer { get; private set; }

        public CustomerManager()
        {
            DataAccessObject = new CustomerRepository();
        }



        public void ChangePassword(string newPassword)
        {
            throw new NotImplementedException();
        }

        public Customer Login(string username, string password)
        {
            Customer customer = DataAccessObject.GetByPrimaryKey(username);
            if(customer.Password == password)
            {
                return customer;
            }
            else
            {
                return null;
            }
            
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

    }
}
