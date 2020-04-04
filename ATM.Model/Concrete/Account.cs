using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model.Concrete
{
    public class Account : IEntity
    {
        public PropertyInfo[] PropertiesForDal { get; private set; }

        public string Iban { get; set; }
        public decimal Balance { get; set; }
        public bool IsDefault { get; set; }
        public decimal Credit { get; set; }
        public AccountType Type { get; set; }
        public string Owner { get; set; }

        
        public Account()
        {
            SetPropertiesForDal();
        }

        public Account(string iban)
        {
            SetPropertiesForDal();
            Iban = iban;
        }

        public Account(string iban, decimal balance, bool isDefault, decimal credit, AccountType type, string owner)
        {
            SetPropertiesForDal();
            Iban = iban;
            Balance = balance;
            IsDefault = isDefault;
            Credit = credit;
            Type = type;
            Owner = owner;
        }

        private void SetPropertiesForDal()
        {
            PropertiesForDal.ToList().Add(this.GetType().GetProperty(nameof(Iban)));
            PropertiesForDal.ToList().Add(this.GetType().GetProperty(nameof(Balance)));
            PropertiesForDal.ToList().Add(this.GetType().GetProperty(nameof(IsDefault)));
            PropertiesForDal.ToList().Add(this.GetType().GetProperty(nameof(Credit)));
            PropertiesForDal.ToList().Add(this.GetType().GetProperty(nameof(Type)));
            PropertiesForDal.ToList().Add(this.GetType().GetProperty(nameof(Owner)));
        }
    }
}
