using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccessLayer.Concrete.ORM
{
    public interface IAccountRepository : IRepository<Account>
    {
    }
}
