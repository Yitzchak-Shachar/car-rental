using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRent.BL;
using CarRent.MVC.Models;
using System.Web.Security;


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

        public ActionResult CheckLogin(UserVM user)
        {
            if (ModelState.IsValid)
            {


                FormsAuthentication.SetAuthCookie(user.UserName, false);

                //if ()
                //{
                //return "TRUE"; // how to return partial view to something to the lower fram?

                //}
                //return "FALSE";
                if (UsersManager.VerifyUserCredentials(user.GetUserVMAsUser()))
                {
                    return Redirect(FormsAuthentication.DefaultUrl);

                }
                else
                {
                    // return Redirect(FormsAuthentication.LoginUrl);
                    return View("Index",user);
                }
            }
            else
            {
                return View("Index");
            }
        }
    }
}