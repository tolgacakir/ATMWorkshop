using ATM.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model.Concrete
{
    public class Customer :IEntity
    {
        public PropertyInfo[] PropertiesForDal { get; private set; }

        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }
        public bool Locked { get; set; }
        public int InvalidLoginCount { get; set; }

        public Customer()
        {
            SetPropertiesForDal();
        }
        public Customer(string username, string firstName, string lastName, string password)
        {
            SetPropertiesForDal();
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
        }

        public Customer(string username, string firstName, string lastName, string password, bool loggedIn, bool locked, int invalidLoginCount)
        {
            SetPropertiesForDal();
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            LoggedIn = loggedIn;
            Locked = locked;
            InvalidLoginCount = invalidLoginCount;
        }

        private void SetPropertiesForDal()
        {
            PropertiesForDal = new PropertyInfo[4];
            PropertiesForDal.ToList().Add(this.GetType().GetProperty(nameof(Username)));
            PropertiesForDal.ToList().Add(this.GetType().GetProperty(nameof(FirstName)));
            PropertiesForDal.ToList().Add(this.GetType().GetProperty(nameof(LastName)));
            PropertiesForDal.ToList().Add(this.GetType().GetProperty(nameof(Password)));
        }

    }
}
