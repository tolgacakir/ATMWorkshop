using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model.Concrete.Exceptions
{
    public class UsernameValidationException :Exception, IExceptionWithMessage
    {
        public string Message_ { get; private set; }

        public UsernameValidationException()
        {

        }
        public UsernameValidationException(string message)
        {
            Message_ = message;
        }

        
    }
}
