using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NvhK22CNT4Lesson11_2210900102.Models;

namespace NvhK22CNT4Lesson11_2210900102.Controllers
{
    public class NvhProductsController : Controller
    {
        private NvhK22CNT4Lesson11DbEntities db = new NvhK22CNT4Lesson11DbEntities();

        // GET: NvhProducts
        public ActionResult NvhIndex()
        {
            var nvhProduct = db.NvhProduct.Include(n => n.NvhCategory);
            return View(nvhProduct.ToList());
        }

        // GET: NvhProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvhProduct nvhProduct = db.NvhProduct.Find(id);
            if (nvhProduct == null)
            {
                return HttpNotFound();
            }
            return View(nvhProduct);
        }

        // GET: NvhProducts/Create
        public ActionResult Create()
        {
            ViewBag.NvhCateId = new SelectList(db.NvhCategory, "NvhId", "NvhCateName");
            return View("NvhIndex");
        }

        // POST: NvhProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NvhId2210900102,NvhProName,NvhQty,NvhPrice,NvhCateId,NvhActive")] NvhProduct nvhProduct)
        {
            if (ModelState.IsValid)
            {
                db.NvhProduct.Add(nvhProduct);
                db.SaveChanges();
                return RedirectToAction("NvhIndex");
            }

            ViewBag.NvhCateId = new SelectList(db.NvhCategory, "NvhId", "NvhCateName", nvhProduct.NvhCateId);
            return View(nvhProduct);
        }

        // GET: NvhProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvhProduct nvhProduct = db.NvhProduct.Find(id);
            if (nvhProduct == null)
            {
                return HttpNotFound();
            }
            ViewBag.NvhCateId = new SelectList(db.NvhCategory, "NvhId", "NvhCateName", nvhProduct.NvhCateId);
            return View(nvhProduct);
        }

        // POST: NvhProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NvhId2210900102,NvhProName,NvhQty,NvhPrice,NvhCateId,NvhActive")] NvhProduct nvhProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvhProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NVhIndex");
            }
            ViewBag.NvhCateId = new SelectList(db.NvhCategory, "NvhId", "NvhCateName", nvhProduct.NvhCateId);
            return View(nvhProduct);
        }

        // GET: NvhProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvhProduct nvhProduct = db.NvhProduct.Find(id);
            if (nvhProduct == null)
            {
                return HttpNotFound();
            }
            return View(nvhProduct);
        }

        // POST: NvhProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NvhProduct nvhProduct = db.NvhProduct.Find(id);
            db.NvhProduct.Remove(nvhProduct);
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
