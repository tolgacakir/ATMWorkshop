using ATM.BusinessLogicLayer.Concrete;
using ATM.DataAccessLayer.Abstract;
using ATM.DataAccessLayer.Concrete.EntityFramework;
using ATM.Entites.Concrete;
using FluentValidation;
using Moq;
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

        
        [Fact]
        public void Customer_validation_check()
        {
            Mock<ICustomerDal> mock = new Mock<ICustomerDal>();
            CustomerManager customerManager = new CustomerManager(mock.Object);

            

            Assert.Throws<ValidationException>(() => customerManager.ChangePassword(new Customer { Username = "000000000000000000000" }));
        }
    }
}
