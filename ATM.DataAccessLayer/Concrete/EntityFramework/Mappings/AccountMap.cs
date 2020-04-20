using ATM.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace ATM.DataAccessLayer.Concrete.EntityFramework.Mappings
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            ToTable(@"Accounts", @"dbo");
            HasKey(a => a.Iban);

            Property(a => a.Iban).HasColumnName("Iban");
            Property(a => a.Balance).HasColumnName("Balance");
            Property(a => a.IsDefault).HasColumnName("Default");
            Property(a => a.Credit).HasColumnName("Credit");
            Property(a => a.Type).HasColumnName("Type");
            Property(a => a.Owner).HasColumnName("Owner");
        }
    }
}
