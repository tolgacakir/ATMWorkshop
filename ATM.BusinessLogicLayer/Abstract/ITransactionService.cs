using ATM.Model.Abstract;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BusinessLogicLayer.Abstract
{
    public interface ITransactionService
    {
        void Insert(AbstractTransaction transaction);
        void Delete(AbstractTransaction transaction);
    }
}
