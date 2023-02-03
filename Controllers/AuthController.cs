using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VietLish.Models.EF;
using VietLish.Models.ViewModel;

namespace VietLish.Controllers
{
    public class AuthController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AuthViewModel m)
        {
            using (VietLishDbContext db = new VietLishDbContext())
            {
                var data = db.Accounts.Where(s => s.username.Equals(m.Account.username) && s.password.Equals(m.Account.password)).FirstOrDefault();
                if (data != null)
                {
                    Session["account"] = data.account_id;
                    Session["fullname"] = data.full_name;
                    Session["role"] = data.role == true ? "Admin" : "Student";
                    Session.Timeout = 60;
                    if (data.role)
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = " Your username and password incorect!!";
                    return View("Login", data);

                }
            }
        }

        public ActionResult SignUp()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(AuthViewModel m)
        {
            using (VietLishDbContext db = new VietLishDbContext())
            {
                if (m.Account.password == m.Repassword)
                {
                    var check = db.Accounts.FirstOrDefault(s => s.username == m.Account.username);
                    if (check == null)
                    {
                        db.Configuration.ValidateOnSaveEnabled = true;
                        var totalStudent = (from row in db.Accounts select row).Count();
                        Account a = new Account
                        {
                            account_id = "ID" + (totalStudent + 1),
                            full_name =m.Account.full_name,
                            username = m.Account.username,
                            password = m.Account.password,
                            role = false,
                        };
                        db.Accounts.Add(a);
                        Score s = new Score
                        {
                            account_id = "ID" + (totalStudent + 1),
                            total_score = 0,
                        };
                        db.Accounts.Add(a);
                        db.Scores.Add(s);
                        db.SaveChanges();
                        ViewBag.Message = "Login Successfully!! ";
                        return View("Login");
                    }
                    else
                    {
                        ViewBag.ErrorMassage = "Username is exists!!";
                        return View("SignUp");
                    }
                }
                else
                {
                    ViewBag.ErrorMassage = " Re-password it not correct!";
                    return View("SignUp");
                }
            }
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Auth");
        }
    }
}