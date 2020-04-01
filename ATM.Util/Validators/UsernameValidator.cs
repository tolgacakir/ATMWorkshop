using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Util.Validators
{
    public class UsernameValidator : IValidator
    {
        public bool Validate(object obj)
        {
            string username = (string)obj;
            return username.Length < 10;

        }
    }
}
