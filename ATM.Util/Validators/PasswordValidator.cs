using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Util.Validators
{
    public class PasswordValidator : IValidator
    {
        public bool Validate(object obj)
        {
            string password = (string)obj;
            return password.Length < 10;
        }
    }
}
