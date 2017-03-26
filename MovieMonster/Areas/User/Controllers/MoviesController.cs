using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace MovieMonster.Areas.Users.Controllers
{
    [Authorize(Roles="A,U")]
    public class MoviesController : Controller
    {
        private BaseBs db;

        public MoviesController()
        {
            db = new BaseBs();
        }

        // GET: User/Movies
        public ActionResult Index()
        {
            var movies = db.MoviesBs.GetAll();
            return View(movies);
        }
    }
}