using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRent.BL;

namespace CarRent.MVC.Controllers
{
    public class LoginController : Controller
    {
        UsersManager UsersManager;
        public LoginController()
        {
            UsersManager = new UsersManager();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public string CheckLogin(string user, string password)
        {
            if (UsersManager.VerifyUserCredentials(user,password))
            {
            return "TRUE"; // how to return partial view to something to the lower fram?

            }
            return "FALSE";
        }
    }
}