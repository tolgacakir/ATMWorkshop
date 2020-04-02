using ATM.Model.Concrete.Exceptions;
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

            if(password.Length>0 && password.Length<5)
            {
                return true;
            }
            else
            {
                //throw new Exception("deneme");
                throw new PasswordValidationException();
            }
            
        }
    }
}
