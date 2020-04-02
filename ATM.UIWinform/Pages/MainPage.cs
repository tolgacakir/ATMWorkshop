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
    public partial class MainPage : UserControl, IPage
    {
        private static MainPage Instance = new MainPage(MainForm.GetSingletonInstance());
        public IMainForm OwnerForm {get; private set;}
        public string Title { get; private set; }

        private MainPage(IMainForm owner)
        {
            InitializeComponent();
            OwnerForm = owner;
            Title = "Main Page";
        }

        public static MainPage GetSingleton()
        {
            return Instance;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OwnerForm.NavigatePage(ProfilePage.GetSingleton());
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            OwnerForm.NavigatePage(AccountsPage.GetSingleton());
        }
    }
}
