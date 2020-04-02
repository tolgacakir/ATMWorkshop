using ATM.BusinessLogicLayer.Abstract;
using ATM.BusinessLogicLayer.Concrete;
using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.UIWinform.Forms
{
    public partial class MainForm : Form
    {
        IEntityLister<Customer, Account> _accountLister;
        Customer _customer;
        public MainForm()
        {
            InitializeComponent();
            _customer = new Customer("tcakir", "", "", "");
            _accountLister = new AccountManager();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgAccounts.DataSource = _accountLister.GetList(_customer);
        }
    }
}
