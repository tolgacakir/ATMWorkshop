using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DataAccessLayer.Concrete.ORM
{
    public class AccountRepository : BaseAdoNetRepository<Account>, IAccountRepository
    {
        public void Login(string username)
        {
            throw new NotImplementedException();
        }

        public AccountRepository()
        {
            
        }
    }
}
