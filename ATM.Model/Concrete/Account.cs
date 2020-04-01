using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model.Concrete
{
    public class Account : IEntity
    {
        public string Iban { get; set; }
        public decimal Balance { get; set; }
        public bool IsDefault { get; set; }
        public decimal Credit { get; set; }
        public AccountType Type { get; set; }
        public string Owner { get; set; }

        public Account(string iban)
        {
            Iban = iban;
        }

        public Account(string iban, decimal balance, bool isDefault, decimal credit, AccountType type, string owner)
        {
            Iban = iban;
            Balance = balance;
            IsDefault = isDefault;
            Credit = credit;
            Type = type;
            Owner = owner;
        }
    }
}
