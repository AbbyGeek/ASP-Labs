using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPlab.Models;
using System.Text.RegularExpressions;

namespace ASPlab.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Register()
        {
            return View();
        }

        public ActionResult LandingPage(User newUser)
        {

            //use newUser info and send it to LandingPage View with a ViewBag 
            ViewBag.user = newUser;
            return View();
        }

    }
    
}