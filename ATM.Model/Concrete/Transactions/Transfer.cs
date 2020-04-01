using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model.Concrete.Transactions
{
    public class Transfer : AbstractTransaction
    {
        public Transfer(decimal amount, string description, Account source, Account target)
        {
            Id = 0;
            Amount = amount;
            Date = DateTime.Today;
            Description = description;
            Type = TransactionType.TRANSFER;
            Source = source;
            Target = target;
        }

        public Transfer(int id, decimal amount, DateTime date, string description, Account source, Account target)
        {
            Id = id;
            Amount = amount;
            Date = date;
            Description = description;
            Type = TransactionType.TRANSFER;
            Source = source;
            Target = target;
        }
    }
}
