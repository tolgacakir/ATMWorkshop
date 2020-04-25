using ATM.BusinessLogicLayer.Concrete;
using ATM.DataAccessLayer.Concrete.EntityFramework;
using ATM.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.ChangePassword(new Customer());
        }

    }
}
