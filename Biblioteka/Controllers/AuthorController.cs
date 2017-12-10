using Biblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Biblioteka.Controllers
{
    public class AuthorController : Controller
    {
        public static Library lib = new Library();
        // GET: Author
        public ActionResult Index()
        {
            return View(lib.Authors);
            /*if (author > lib.Authors.Count || author < 0) author = 0;
            ViewBag.Author = lib.Authors[author];
            return View(lib.Authors[author]);
            */
        }

        

        public ActionResult All() {
            return View(lib.Authors);
        }

        // GET: Author/Details/5
        public ActionResult Details(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Author author = lib.Authors.Single(b => b.Id == id);
            if (author == null) {
                return HttpNotFound();
            }
            return View(author);
        }

        // GET: Author/Create
        public ActionResult Create() {
            return View();
        }

        // POST: Author/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Surname")] Author author) {
            if (ModelState.IsValid) {
                author.Id = AuthorController.lib.Authors.Max(b => b.Id) + 1;
                AuthorController.lib.Authors.Add(author);
                return RedirectToAction("Index");
            }
            return View(author);
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Book book = db.Books.Find(id);
            Author author = AuthorController.lib.Authors.Single(b => b.Id == id);
            if (author == null) {
                return HttpNotFound();
            }
            return View(author);
        }

        // POST: Author/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Surname")] Author author) {
            if (ModelState.IsValid) {
                Author _author = AuthorController.lib.Authors.Single(b => b.Id == author.Id);
                _author.Name = author.Name;
                _author.Surname = author.Surname;
                return RedirectToAction("Index");
            }
            return View(author);
        }

        [HttpDelete]
        public ActionResult Delete(int author) {
            Author a = lib.Authors[author];
            lib.Authors.Remove(a);
            return View("All", lib.Authors);
        }

        // GET: Author/Delete/5
        public ActionResult Delete(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Book book = db.Books.Find(id);
            Author author = AuthorController.lib.Authors.Single(b => b.Id == id);
            if (author == null) {
                return HttpNotFound();
            }
            return View(author);
        }

        // POST: Author/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            Author author = AuthorController.lib.Authors.Single(b => b.Id == id);
            AuthorController.lib.Authors.Remove(author);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}