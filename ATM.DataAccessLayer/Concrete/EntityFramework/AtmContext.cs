using ATM.DataAccessLayer.Concrete.EntityFramework.Mappings;
using ATM.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ATM.DataAccessLayer.Concrete.EntityFramework
{
    public class AtmContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public AtmContext() :base(@"Data Source=ENDOS\SQLEXPRESS;Initial Catalog=ATM_DB;Integrated Security=True;Pooling=False")
        {
            Database.SetInitializer<AtmContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new AccountMap());
        }
    }
}
