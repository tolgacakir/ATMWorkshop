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

namespace ATM.UIWinform.Pages
{
    public partial class AccountsPage : UserControl, IPage
    {
        private static AccountsPage Instance = new AccountsPage(MainForm.GetSingletonInstance());

        public IMainForm OwnerForm { get; private set; }

        public string Title { get; private set; }

        private AccountsPage(IMainForm mainForm)
        {
            InitializeComponent();
            OwnerForm = mainForm;
            Title = "Accounts Page";
        }

        public static AccountsPage GetSingleton()
        {
            return Instance;
        }

    }
}
