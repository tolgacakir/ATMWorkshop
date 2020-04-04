using ATM.Model.Concrete;

namespace ATM.DataAccessLayer2.Abstract.GenericRepositories
{
    public interface ICustomerRepository :IGenericRepository<Customer>
    {
        Customer Login(string username, string password);
    }
}
