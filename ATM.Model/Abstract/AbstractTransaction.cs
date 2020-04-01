using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model.Abstract
{
    public abstract class AbstractTransaction : IEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public TransactionType Type { get; protected set; }
        public Account Source { get; set; }
        public Account Target { get; set; }
    }
}
