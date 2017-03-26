using System.Web.Mvc;
using System.Web.Security;
using BLL;
using BOL;
using System;

namespace MovieMonster.Areas.Security.Controllers
{
    [AllowAnonymous]
    public class LogInController : Controller
    {
        private BaseBs db;

        public LogInController()
        {
            db = new BaseBs();
        }

        // GET: Security/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            try
            {
                if (Membership.ValidateUser(user.UserName, user.Password))
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return RedirectToAction("Index", "Home", new {area = "Common"});
                }
                else
                {
                    TempData["Msg"] = "Log In failed: ";
                    return RedirectToAction("Index");
                }
            }
            catch(Exception e)
            {
                TempData["Msg"] = "Login failed in catch: " + e.Message;
                return RedirectToAction("Index");
            }
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home", new { area = "Common" });
        }
    }
}