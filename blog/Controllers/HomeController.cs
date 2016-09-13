using blog.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blog.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext db = new BlogContext();

        // GET: Home
        public ActionResult Index()
        {
            return View("~/Views/Post/Index.cshtml", db.Posts.ToList());
            //return View();
        }
    }
}