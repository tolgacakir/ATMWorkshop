using ATM.BusinessLogicLayer.Concrete;
using ATM.DataAccessLayer.Concrete.EntityFramework;
using ATM.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ATM.BusinessLogicLayer.Tests.ManagerTests
{
    public class CustomerManagerTest
    {
        [Fact]
        public void Change_password()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            Customer customer = customerManager.Login("sciftci", "123456789");
            customer.Password = "123456";
            bool result = customerManager.ChangePassword(customer);
            Assert.True(result);
        }
    }
}
