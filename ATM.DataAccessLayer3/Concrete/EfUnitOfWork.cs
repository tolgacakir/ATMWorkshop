using ATM.DataAccessLayer3.Abstract;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ATM.DataAccessLayer3.Concrete
{
    public class EfUnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; set; }
        public IAccountRepository Accounts { get; private set; }
        public ICustomerRepository Customers { get; private set; }



        public EfUnitOfWork(DbContext context)
        {
            Context = context;

            Accounts = new EfAccountRepository()
            { UnitOfWork = this};
            
            Customers = new EfCustomerRepository()
            { UnitOfWork = this };
        }
        
        public DbSet<T> CreateDbSetInstance<T>()
            where T: class
        {
            return Context.Set<T>();
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            if (Context!=null)
            {
                Context.Dispose();
                Context = null;
            }
            GC.SuppressFinalize(this);
        }

    }
}
