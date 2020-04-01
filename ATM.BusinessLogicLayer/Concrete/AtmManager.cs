using ATM.BusinessLogicLayer.Abstract;
using ATM.Model.Abstract;
using ATM.Model.Concrete;
using ATM.Model.Concrete.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.BusinessLogicLayer.Concrete
{
    public class AtmManager : IAtmManager
    {
        //TODO: currenAccount setlenmeli
        public Account CurrentAccount { get; set; }


        private IAccountService AccountManager { get; set; }
        private ITransactionService TransactionManager { get; set; }
        private IReceiptService ReceiptManager { get; set; }
        private IBillService BillManager { get; set; }


        public AtmManager(IAccountService accountManager, ITransactionService transactionManager, IReceiptService receiptManager, IBillService billManager)
        {
            AccountManager = accountManager;
            TransactionManager = transactionManager;
            ReceiptManager = receiptManager;
            BillManager = billManager;
        }

        public void Deposit(decimal amount, string description)
        {
            CurrentAccount.Balance += amount;
            AccountManager.Update(CurrentAccount);
            var deposit = new Deposit(amount, description, CurrentAccount);
            TransactionManager.Insert(deposit);

            //TODO:receipt eksik
            var receipt = new Receipt();
            ReceiptManager.Insert(receipt);
        }

        public void Eft(decimal amount, string description, Account targetAccount)
        {
            CurrentAccount.Balance -= amount;
            AccountManager.Update(CurrentAccount);
            targetAccount.Balance += amount;
            AccountManager.Update(targetAccount);

            var eft = new Eft(amount, description, CurrentAccount, targetAccount);
            TransactionManager.Insert(eft);

            //TODO:receipt eksik
            var receipt = new Receipt();
            ReceiptManager.Insert(receipt);
        }

        public void Payment(decimal amount, string description)
        {
            CurrentAccount.Balance += amount;
            AccountManager.Update(CurrentAccount);
            var payment = new Payment(amount, description, CurrentAccount);
            TransactionManager.Insert(payment);

            //TODO:receipt eksik
            var receipt = new Receipt();
            ReceiptManager.Insert(receipt);

            //TODO:bill eksik
            var bill = new Bill();
            BillManager.Insert(bill);
        }

        public void Transfer(decimal amount, string description, Account targetAccount)
        {
            CurrentAccount.Balance -= amount;
            AccountManager.Update(CurrentAccount);
            targetAccount.Balance += amount;
            AccountManager.Update(targetAccount);
            var transfer = new Transfer(amount, description, CurrentAccount, targetAccount);
            TransactionManager.Insert(transfer);

            //TODO:receipt eksik
            var receipt = new Receipt();
            ReceiptManager.Insert(receipt);
        }

        public void Withdraw(decimal amount, string description)
        {
            CurrentAccount.Balance -= amount;
            AccountManager.Update(CurrentAccount);
            var withdraw = new Withdraw(amount, description, CurrentAccount);
            TransactionManager.Insert(withdraw);

            //TODO:receipt eksik
            var receipt = new Receipt();
            ReceiptManager.Insert(receipt);
        }
    }
}
