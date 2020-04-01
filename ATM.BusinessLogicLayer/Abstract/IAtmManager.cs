using ATM.Model.Abstract;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BusinessLogicLayer.Abstract
{
    public interface IAtmManager
    {
        Account CurrentAccount { get; set; }

        //TODO: tüm işlemlerin receipt'i olacak. ayrıca paymentin bill'i olacak
        void Deposit(decimal amount, string description);
        void Eft(decimal amount, string description, Account targetAccount);
        void Payment(decimal amount, string description);
        void Transfer(decimal amount, string description, Account targetAccount);
        void Withdraw(decimal amount, string description);
    }
}
