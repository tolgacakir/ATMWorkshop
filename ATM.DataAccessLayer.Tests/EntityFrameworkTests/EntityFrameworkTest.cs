using ATM.DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
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
        public void Get_returns_customer()
        {
            EfCustomerDal customerDal = new EfCustomerDal();

            var result = customerDal.Get(c => c.Username == "tcakir");
            Assert.Equal("tcakir", result.Username);
        }
    }
}
