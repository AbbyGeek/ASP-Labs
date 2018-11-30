using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPlab.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Color { get; set; }

        public User() { }

        public User(string firstName, string lastName, string email, string username, string password, string gender, string birthday, string color)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Username = username;
            Password = password;
            Gender = gender;
            Birthday = birthday;
            Color = color;
        }
    }
}