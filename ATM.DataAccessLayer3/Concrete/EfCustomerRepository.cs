using ATM.DataAccessLayer3.Abstract;
using ATM.DataAccessLayer3.Base;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.DataAccessLayer3.Concrete
{
    public class EfCustomerRepository : BaseEfRepository<Customer>, ICustomerRepository
    {

    }
}
 