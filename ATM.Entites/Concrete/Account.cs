using System;
using System.Collections.Generic;
using System.Text;
using TFramework.Core.Entities;

namespace ATM.Entites.Concrete
{
    public class Account : IEntity
    {
        public string Iban { get; set; }
        public decimal Balance { get; set; }
        public bool IsDefault { get; set; }
        public decimal Credit { get; set; }
        public string Type { get; set; }
        public string Owner { get; set; }
    }
}
