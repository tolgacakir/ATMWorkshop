using ATM.BusinessLogicLayer.Abstract;
using ATM.BusinessLogicLayer.Concrete;
using ATM.Model.Concrete;
using ATM.Model.Concrete.Exceptions;
using ATM.Util.Validators;
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
        private static LoginForm Instance = new LoginForm();
        ICustomerService _customerManager; 
        private LoginForm()
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
        }

        public static LoginForm GetSingletonInstance()
        {
            return Instance;
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
            IValidator usernameValidator = new UsernameValidator();
            IValidator passwordValidator = new PasswordValidator();
            try
            {
                if (usernameValidator.Validate(txtUsername.Text) && passwordValidator.Validate(txtPassword.Text))
                {
                    Customer customer = _customerManager.Login(txtUsername.Text, txtPassword.Text);
                    IMainForm mainForm = MainForm.GetSingletonInstance();
                    this.Hide();
                    mainForm.Start(customer,this);
                }
            }
            catch (CustomerCouldNotFindException)
            {
                MessageBox.Show("Customer could not find!");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            catch (UsernameValidationException ex)
            {
                MessageBox.Show(ex.Message_);
            }
            catch(PasswordValidationException)
            {
                MessageBox.Show("Invalid password!");
            }
            catch(WrongPasswordException)
            {
                MessageBox.Show("Wrong password! Please enter correct password.");
                txtPassword.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
