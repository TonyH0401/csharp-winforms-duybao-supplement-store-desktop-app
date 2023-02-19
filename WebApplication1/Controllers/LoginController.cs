using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//add extra library
using System.Web.Security;
using WebApplication1.Models;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        private DevConn db = new DevConn();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }    
        [HttpPost]
        public ActionResult Login(LoginViewModel credentials)
        {
            bool userExist = db.Accounts.Any(x => x.accountID == credentials.accountID && x.accountPassword == credentials.accountPassword);
            Account user = db.Accounts.FirstOrDefault(x => x.accountID == credentials.accountID && x.accountPassword == credentials.accountPassword);
            if (userExist)
            {
                FormsAuthentication.SetAuthCookie(user.accountID, false);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Username or Password is wrong");
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
            //return View();
        }
    }
}