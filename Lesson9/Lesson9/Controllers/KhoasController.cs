using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lesson9.Models;

namespace Lesson9.Controllers
{
    public class KhoasController : Controller
    {
        private qlsinhvienEntities db = new qlsinhvienEntities();

        // GET: Khoas
        public ActionResult NvhIndex()
        {
            return View(db.Khoas.ToList());
        }

        // GET: Khoas/Details/5
        public ActionResult NvhDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khoa khoa = db.Khoas.Find(id);
            if (khoa == null)
            {
                return HttpNotFound();
            }
            return View(khoa);
        }

        // GET: Khoas/Create
        public ActionResult NvhCreate()
        {
            return View();
        }

        // POST: Khoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvhCreate([Bind(Include = "MaKH,TenKH")] Khoa khoa)
        {
            if (ModelState.IsValid)
            {
                db.Khoas.Add(khoa);
                db.SaveChanges();
                return RedirectToAction("NvhIndex");
            }

            return View(khoa);
        }

        // GET: Khoas/Edit/5
        public ActionResult NvhEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khoa khoa = db.Khoas.Find(id);
            if (khoa == null)
            {
                return HttpNotFound();
            }
            return View(khoa);
        }

        // POST: Khoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvhEdit([Bind(Include = "MaKH,TenKH")] Khoa khoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NvhIndex");
            }
            return View(khoa);
        }

        // GET: Khoas/Delete/5
        public ActionResult NvhDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khoa khoa = db.Khoas.Find(id);
            if (khoa == null)
            {
                return HttpNotFound();
            }
            return View(khoa);
        }

        // POST: Khoas/Delete/5
        [HttpPost, ActionName("NvhDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Khoa khoa = db.Khoas.Find(id);
            db.Khoas.Remove(khoa);
            db.SaveChanges();
            return RedirectToAction("NvhIndex");
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
