using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model.Concrete
{
    public class AtmDbContent :DbContext
    {
        public AtmDbContent() : base(@"Data Source=ENDOS\SQLEXPRESS;Initial Catalog=ATM_DB;Integrated Security=True;Pooling=False")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
