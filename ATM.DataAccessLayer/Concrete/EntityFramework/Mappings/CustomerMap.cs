using ATM.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace ATM.DataAccessLayer.Concrete.EntityFramework.Mappings
{
    public class CustomerMap :EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable(@"Customers", @"dbo");
            HasKey(c => c.Username);

            Property(c => c.Username).HasColumnName("Username");
            Property(c => c.FirstName).HasColumnName("FirstName");
            Property(c => c.LastName).HasColumnName("LastName");
            Property(c => c.Locked).HasColumnName("Locked");
            Property(c => c.LoggedIn).HasColumnName("LoggedIn");
            Property(c => c.Password).HasColumnName("Password");
            Property(c => c.InvalidLoginCount).HasColumnName("InvalidLoginCount");
        }
    }
}
