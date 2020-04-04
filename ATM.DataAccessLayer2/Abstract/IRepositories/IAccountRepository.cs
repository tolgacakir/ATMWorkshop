using ATM.Model.Concrete;

namespace ATM.DataAccessLayer2.Abstract.GenericRepositories
{
    public interface IAccountRepository :IGenericRepository<Account>
    {
        Account GetByIban(string iban);
    }
}
