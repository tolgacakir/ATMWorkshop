using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccessLayer.Abstract
{
    public interface ICustomerDal :IGenericDal<Customer>
    {
        Customer Login(string username, string password);
    }
}
