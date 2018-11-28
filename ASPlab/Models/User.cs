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
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string pronouns { get; set; }
        public string birthday { get; set; }
        public string color { get; set; }

        public User() { }

        public User(string firstName, string lastName, string Email, string Username, string Password, string Pronouns, string Birthday, string Color)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Username = username;
            Password = password;
            Pronouns = pronouns;
            Birthday = birthday;
            Color = color;
        }
    }
}