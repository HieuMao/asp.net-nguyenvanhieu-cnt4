using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NvhBaiKiemTraGK.Model;

namespace NvhBaiKiemTraGK.Controllers
{
    public class NvhKhoasController : Controller
    {
        private NvhK22CNT4Lesson07dbEntities4 db = new NvhK22CNT4Lesson07dbEntities4();

        // GET: NvhKhoas
        public ActionResult NvhIndex()
        {
            return View(db.nvhKhoa.ToList());
        }

        // GET: NvhKhoas/Details/5
        public ActionResult NvhDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvhKhoa nvhKhoa = db.nvhKhoa.Find(id);
            if (nvhKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvhKhoa);
        }

        // GET: NvhKhoas/Create
        public ActionResult NvhCreate()
        {
            return View();
        }

        // POST: NvhKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvhCreate([Bind(Include = "NvhMaKH,NvhTenKH,NvhTrangThai")] nvhKhoa nvhKhoa)
        {
            if (ModelState.IsValid)
            {
                db.nvhKhoa.Add(nvhKhoa);
                db.SaveChanges();
                return RedirectToAction("NvhIndex");
            }

            return View(nvhKhoa);
        }

        // GET: NvhKhoas/Edit/5
        public ActionResult NvhEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvhKhoa nvhKhoa = db.nvhKhoa.Find(id);
            if (nvhKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvhKhoa);
        }

        // POST: NvhKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvhEdit([Bind(Include = "NvhMaKH,NvhTenKH,NvhTrangThai")] nvhKhoa nvhKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvhKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NvhIndex");
            }
            return View(nvhKhoa);
        }

        // GET: NvhKhoas/Delete/5
        public ActionResult NvhDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvhKhoa nvhKhoa = db.nvhKhoa.Find(id);
            if (nvhKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvhKhoa);
        }

        // POST: NvhKhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            nvhKhoa nvhKhoa = db.nvhKhoa.Find(id);
            db.nvhKhoa.Remove(nvhKhoa);
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
