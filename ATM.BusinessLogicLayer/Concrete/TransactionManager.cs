using ATM.BusinessLogicLayer.Abstract;
using ATM.Model.Abstract;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BusinessLogicLayer.Concrete
{
    public class TransactionManager : ITransactionService , IEntityLister<Account, AbstractTransaction>
    {
        public void Delete(AbstractTransaction transaction)
        {
            throw new NotImplementedException();

        }

        public void Insert(AbstractTransaction transaction)
        {
            throw new NotImplementedException();
        }

        public IList<AbstractTransaction> GetList(Account input)
        {
            throw new NotImplementedException();
        }
    }
}
