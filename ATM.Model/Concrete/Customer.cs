using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model.Concrete
{
    public class Customer :IEntity
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
        public bool Locked { get; set; }
        public int InvalidLoginCount { get; set; }


        public Customer(string username, string firstName, string lastName, string password)
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
        }

        public Customer(string username, string firstName, string lastName, string password, bool loggedIn, bool locked, int invalidLoginCount)
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            LoggedIn = loggedIn;
            Locked = locked;
            InvalidLoginCount = invalidLoginCount;
        }

    }
}
