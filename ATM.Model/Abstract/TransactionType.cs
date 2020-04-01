using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model.Abstract
{
    public enum TransactionType
    {
        NONE,
        DEPOSIT,
        EFT,
        PAYMENT,
        TRANSFER,
        WITHDRAW,
    }
}
