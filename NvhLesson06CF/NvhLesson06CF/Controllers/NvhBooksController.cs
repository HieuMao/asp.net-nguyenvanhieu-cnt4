using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NvhLesson06CF.Models;

namespace NvhLesson06CF.Controllers
{
    public class NvhBooksController : Controller
    {
        private NvhBookStore db = new NvhBookStore();

        // GET: NvhBooks
        public ActionResult Index()
        {
            return View(db.NvhBooks.ToList());
        }

        // GET: NvhBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvhBook nvhBook = db.NvhBooks.Find(id);
            if (nvhBook == null)
            {
                return HttpNotFound();
            }
            return View(nvhBook);
        }

        // GET: NvhBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NvhBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NvhID,NvhBookId,NvhTitle,NvhAuthor,NvhYear,NvhPulisher,NvhPicture,NvhCategoryId")] NvhBook nvhBook)
        {
            if (ModelState.IsValid)
            {
                db.NvhBooks.Add(nvhBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nvhBook);
        }

        // GET: NvhBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvhBook nvhBook = db.NvhBooks.Find(id);
            if (nvhBook == null)
            {
                return HttpNotFound();
            }
            return View(nvhBook);
        }

        // POST: NvhBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NvhID,NvhBookId,NvhTitle,NvhAuthor,NvhYear,NvhPulisher,NvhPicture,NvhCategoryId")] NvhBook nvhBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvhBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nvhBook);
        }

        // GET: NvhBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvhBook nvhBook = db.NvhBooks.Find(id);
            if (nvhBook == null)
            {
                return HttpNotFound();
            }
            return View(nvhBook);
        }

        // POST: NvhBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NvhBook nvhBook = db.NvhBooks.Find(id);
            db.NvhBooks.Remove(nvhBook);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
