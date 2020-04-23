using ATM.DataAccessLayer.Concrete.EntityFramework;
using ATM.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ATM.DataAccessLayer.Tests.EntityFrameworkTests
{
    
    public class EntityFrameworkTest
    {
        [Fact]
        public void Get_all_returns_all_customers()
        {
            EfCustomerDal customerDal = new EfCustomerDal();

            var result = customerDal.GetList();
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void Get_all_with_parameter_returns_filtered_customers()
        {
            EfCustomerDal customerDal = new EfCustomerDal();

            var result = customerDal.GetList(c => c.FirstName.Length == 5);
            Assert.Equal(5, result.FirstOrDefault().FirstName.Length);
        }


        [Fact]
        public void Get_returns_customer()
        {
            EfCustomerDal customerDal = new EfCustomerDal();

            var result = customerDal.Get(c => c.Username == "tcakir");
            Assert.Equal("tcakir", result.Username);
        }

        [Fact]
        public void Add_returns_customer()
        {
            EfCustomerDal customerDal = new EfCustomerDal();

            Customer customer = new Customer
            {
                Username = "sciftci",
                FirstName = "Semih",
                LastName = "Çiftçi",
                Locked = false,
                InvalidLoginCount = 0,
                LoggedIn = false,
                Password = "3"
            };
            var result = customerDal.Add(customer);

            Assert.Equal("sciftci", result.Username);
        }

        [Fact]
        public void Update_returns_customer()
        {
            EfCustomerDal customerDal = new EfCustomerDal();

            Customer customer = new Customer
            {
                Username = "sciftci",
                FirstName = "Semih",
                LastName = "Çiftçi",
                Locked = false,
                InvalidLoginCount = 0,
                LoggedIn = false,
                Password = "4"
            };
            var result = customerDal.Update(customer);

            Assert.Equal("4", result.Password);
        }

    }
}
