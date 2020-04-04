using ATM.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.UIWinform.Forms
{
    public interface IMainForm
    {
        Customer CurrentCustomer { get; }
        void NavigatePage(IPage page);
        void Start(Customer customer, LoginForm loginForm);
    }
}
