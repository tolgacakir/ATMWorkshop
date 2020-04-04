using ATM.DataAccessLayer.Abstract;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccessLayer.Concrete.TestDal
{
    public class TestCustomerDal : ICustomerDal
    {
        public bool Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer GetByPrimaryKey(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> GetList()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Login(string username, string password)
        {
            return new Customer
            {
                FirstName = "Tolga",
                LastName = "Cakirx",
                Password = password,
                Username = username
            };
        }

        public bool Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
