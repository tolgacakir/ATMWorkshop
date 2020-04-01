using ATM.Model.Abstract;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BusinessLogicLayer.Abstract
{
    public interface IReceiptService
    {
        void Insert(Receipt receipt);
        void Delete(Receipt receipt);

    }
}
