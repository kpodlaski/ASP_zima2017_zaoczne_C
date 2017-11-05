using Biblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteka.Controllers
{
    public class AuthorController : Controller
    {
        private static Library lib = new Library();
        // GET: Author
        public ActionResult Index(int author = 0)
        {
            if (author > lib.Authors.Count || author < 0) author = 0;
            ViewBag.Author = lib.Authors[author];
            return View();
        }

        public ActionResult All() {
            return View(lib.Authors);
        }
    }
}