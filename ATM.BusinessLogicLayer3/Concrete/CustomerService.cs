using ATM.BusinessLogicLayer3.Abstract;
using ATM.DataAccessLayer3.Concrete;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.BusinessLogicLayer3.Concrete
{
    public class CustomerService : ICustomerService
    {
        public bool ChangePassword(Customer customer, string newPassword)
        {
            int result = 0;
            customer.Password = newPassword;
            using (var uow = new EfUnitOfWork(new AtmDbContent()))
            {
                uow.Customers.ChangeEntityState(customer, System.Data.Entity.EntityState.Modified);
                result = uow.SaveChanges();
            }
            return result > 0;
        }

        public Customer Login(string username, string password)
        {
            Customer customer = new Customer();
            int result = 0;
            using (var uow = new EfUnitOfWork(new AtmDbContent()))
            {
                customer = uow.Customers.Find(c => c.Username == username && c.Password == password);
                customer.LoggedIn = true;
                uow.Customers.ChangeEntityState(customer, System.Data.Entity.EntityState.Modified);
                result = uow.SaveChanges();
            }
            return customer;
        }

        public bool Logout(Customer customer)
        {
            int result = 0;
            using (var uow = new EfUnitOfWork(new AtmDbContent()))
            {
                customer.LoggedIn = false;
                uow.Customers.ChangeEntityState(customer, System.Data.Entity.EntityState.Modified);
                result = uow.SaveChanges();
            }
            return result > 0;
        }
    }
}
