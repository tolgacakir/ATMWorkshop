using ATM.BusinessLogicLayer.Abstract;
using ATM.BusinessLogicLayer.Concrete;
using ATM.Model.Concrete;
using ATM.UIWinform.Pages;
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
    public partial class MainForm : Form, IMainForm
    {
        private static MainForm Instance = new MainForm();


        IEntityLister<Customer, Account> AccountLister;
        LoginForm LoginForm;

        public Customer CurrentCustomer { get; set; }

        private MainForm()
        {
            InitializeComponent();
            AccountLister = new AccountManager();

        }

        public static MainForm GetSingletonInstance()
        {
            return Instance;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        public void Start(Customer customer,LoginForm loginForm)
        {
            CurrentCustomer = customer;
            LoginForm = loginForm;
            lblCustomerName.Text = customer.FirstName + " " + customer.LastName;
            
            NavigatePage(MainPage.GetSingleton());
            

            //dgAccounts.DataSource = _accountLister.GetList(customer);
            this.ShowDialog();
        }

        public void NavigatePage(IPage page)
        {
            foreach (UserControl p in pnlFrame.Controls)
            {
                p.Visible = false;
            }

            lblPageName.Text = page.Title;
            pnlFrame.Controls.Add((UserControl)page);
            ((UserControl)page).Dock = DockStyle.Fill;
            ((UserControl)page).Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.Visible=true;
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            NavigatePage(MainPage.GetSingleton());
        }
    }
}
