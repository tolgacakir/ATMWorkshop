using System;
using System.Collections.Generic;
using System.Text;
using TFramework.Core.Entities;

namespace ATM.Entites.Concrete
{
    public class Customer :IEntity
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool Locked { get; set; }
        public bool LoggedIn { get; set; }
        public short InvalidLoginCount { get; set; }

    }
}
