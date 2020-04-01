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
    public class ReceiptManager : IReceiptService, IEntityLister<Account, Receipt>
    {
        public void Delete(Receipt receipt)
        {
            throw new NotImplementedException();
        }

        public void Insert(Receipt receipt)
        {
            throw new NotImplementedException();
        }

        public IList<Receipt> GetList(Account input)
        {
            throw new NotImplementedException();
        }
    }
}
