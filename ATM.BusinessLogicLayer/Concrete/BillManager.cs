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
    public class BillManager : IBillService, IEntityLister<Account, Bill>
    {
        public void Delete(Bill bill)
        {
            throw new NotImplementedException();
        }

        public void Insert(Bill bill)
        {
            throw new NotImplementedException();
        }

        public IList<Bill> GetList(Account input)
        {
            throw new NotImplementedException();
        }
    }
}
