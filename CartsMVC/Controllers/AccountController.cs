using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CartsMVC.Models;
using CartsMVC.Models.Login;

namespace CartsMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            using (var db = new CartsDataContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);

                if (user == null)
                    return View(user);

                Session.RemoveAll();
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                    1,
                    user.UserName,
                    DateTime.Now, 
                    DateTime.Now.AddMinutes(30),
                    false,
                    user.Roles,
                    FormsAuthentication.FormsCookiePath);

                string encTicket = FormsAuthentication.Encrypt(ticket);

                Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));

                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logout()
        {
            Session.RemoveAll();
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new CartsDataContext())
                {
                    if (!db.Users.Any(u => u.Email == model.Email))
                    {
                        db.Users.Add(new User()
                        {
                            Id = DateTime.Now.ToString("yyyyMMddHHmmss"),
                            Email = model.Email,
                            UserName = model.UserName,
                            Password = model.Password,
                            Roles = ""
                        });
                        db.SaveChanges();

                        return Login(new LoginViewModel() {Email = model.Email, Password = model.Password});
                    }

                }
            }

            return View(model);
        }
    }
}