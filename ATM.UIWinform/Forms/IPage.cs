using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.UIWinform.Forms
{
    public interface IPage
    {
        IMainForm OwnerForm { get; }
        string Title { get; }
    }
}
