using ATM.DataAccessLayer2.Abstract.GenericRepositories;
using ATM.Model.Concrete;
using System;

namespace ATM.DataAccessLayer2.AdoNetRepositories
{
    public class AdoNetAccountRepository : BaseAdoNetRepository<Account>, IAccountRepository
    {
        public Account GetByIban(string iban)
        {
            throw new NotImplementedException();

        }

        public override void Delete(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
