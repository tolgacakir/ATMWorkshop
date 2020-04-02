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
    public partial class LoginForm : Form
    {
        ICustomerService _customerManager; 
        public LoginForm()
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Customer customer = _customerManager.Login(txtUsername.Text, txtPassword.Text);
            if(customer != null)
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                
            }
        }
    }
}
