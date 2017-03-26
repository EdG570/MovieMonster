using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using BLL;
using BOL;

namespace MovieMonster.Areas.Security.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private BaseBs db;

        public RegisterController()
        {
            db = new BaseBs();
        }
        // GET: Security/Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    user.Password = Crypto.HashPassword(user.Password);
                    db.UsersBs.Insert(user);
                    return RedirectToAction("Index", "LogIn");
                }
                catch(Exception e)
                {
                    TempData["Msg"] = e.Message; 
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}