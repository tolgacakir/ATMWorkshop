using ATM.DataAccessLayer2.Abstract.GenericRepositories;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;

namespace ATM.DataAccessLayer2.AdoNetRepositories
{
    public class AdoNetCustomerRepository : BaseAdoNetRepository<Customer>, ICustomerRepository
    {
        public Customer Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
