using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ATM.DataAccessLayer3.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; set; }
        IAccountRepository Accounts { get; }
        ICustomerRepository Customers { get; }

        int SaveChanges();
        DbSet<T> CreateDbSetInstance<T>() where T : class;

    }
}
