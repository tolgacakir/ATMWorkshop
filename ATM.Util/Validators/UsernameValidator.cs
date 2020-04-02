using ATM.Model.Concrete.Exceptions;
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

            if(CheckLength(username) && CheckChars(username))
            {
                return true;
            }
            else
            {
                throw new UsernameValidationException();
            }
        }

        private bool CheckLength(string username)
        {
            if(username.Length >0 && username.Length<10)
            {
                return true;
            }
            else
            {
                throw new UsernameValidationException("Invalid username! Please enter between 0 - 10 character.");
            }
        }

        private bool CheckChars(string username)
        {
            if (username.Contains("@"))
            {
                throw new UsernameValidationException("Invalid username! Username cannot contain '@' character.");
            }
            else
            {
                return true;
            }
        }
    }
}
