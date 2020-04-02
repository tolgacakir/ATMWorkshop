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
    public partial class ProfilePage : UserControl, IPage
    {
        private static ProfilePage Instance = new ProfilePage(MainForm.GetSingletonInstance());
        public IMainForm OwnerForm { get; private set; }
        public string Title { get; private set; }

        private ProfilePage(IMainForm owner)
        {
            InitializeComponent();
            OwnerForm = owner;
            Title = "Profile Page";
        }

        public static ProfilePage GetSingleton()
        {
            return Instance;
        }
    }
}
