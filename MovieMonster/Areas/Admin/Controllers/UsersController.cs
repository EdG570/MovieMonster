using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace MovieMonster.Areas.Admin.Controllers
{
    [Authorize(Roles="A")]
    public class UsersController : Controller
    {
        private BaseBs db;

        public UsersController()
        {
            db = new BaseBs();
        }

        // GET: Admin/Users
        public ActionResult Index()
        {
            var users = db.UsersBs.GetAll();
            return View(users);
        }
    }
}