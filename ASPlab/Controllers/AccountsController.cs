using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPlab.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Accounts()
        //{
        //    ViewBag.Message = "Register page.";
        //    return View();
        //}

        public ActionResult Register()
        {
            return View();
        }
    }

    public class AddUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string pronouns { get; set; }
        public string birthday { get; set; }
        public string color { get; set; }

        public AddUser(string FirstName, string LastName, string Email, string Username, string Password, string Pronouns, string Birthday, string Color)
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