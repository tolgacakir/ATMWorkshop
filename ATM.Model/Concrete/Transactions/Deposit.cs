using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model.Concrete.Transactions
{
    public class Deposit : AbstractTransaction
    {
        public Deposit(decimal amount, string description, Account source)
        {
            Id = 0;
            Amount = amount;
            Date = DateTime.Today;
            Description = description;
            Type = TransactionType.DEPOSIT;
            Source = source;
            Target = null;
        }

        public Deposit(int id, decimal amount, DateTime date, string description, Account source)
        {
            Id = id;
            Amount = amount;
            Date = date;
            Description = description;
            Type = TransactionType.DEPOSIT;
            Source = source;
            Target = null;
        }
    }
}
