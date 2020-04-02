using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model.Concrete.Exceptions
{
    public interface IExceptionWithMessage
    {
        string Message_ { get; }
    }
}
