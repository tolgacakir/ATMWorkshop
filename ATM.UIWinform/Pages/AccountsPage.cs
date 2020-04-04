using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.UIWinform.Forms;
using ATM.BusinessLogicLayer.Abstract;
using ATM.BusinessLogicLayer.Concrete;
using ATM.Model.Concrete;
using ATM.Model.Abstract;

namespace ATM.UIWinform.Pages
{
    public partial class AccountsPage : UserControl, IPage
    {
        private static AccountsPage Instance = new AccountsPage(MainForm.GetSingletonInstance());

        public IMainForm OwnerForm { get; private set; }

        public string Title { get; private set; }

        private IEntityLister<Customer,Account> AccountManager { get; set; }

        private AccountsPage(IMainForm mainForm)
        {
            InitializeComponent();
            OwnerForm = mainForm;
            Title = "Accounts Page";
            AccountManager = new AccountManager();

            dgAccounts.DataSource = AccountManager.GetList(OwnerForm.CurrentCustomer);

            //Array types;
            //types = Enum.GetValues(TransactionType.DEPOSIT.GetType());



            //types.AddRange(types);
        }

        public static AccountsPage GetSingleton()
        {
            
            return Instance;
        }

        private void ShowAccounts()
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
