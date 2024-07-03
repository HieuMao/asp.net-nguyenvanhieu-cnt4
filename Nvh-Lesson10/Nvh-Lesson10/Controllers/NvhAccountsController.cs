using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nvh_Lesson10.Models;

namespace Nvh_Lesson10.Controllers
{
    public class NvhAccountsController : Controller
    {
        private Entities db = new Entities();

        // GET: NvhAccounts
        public ActionResult Index()
        {
            
            return View(db.NvhAccount.ToList());
        }

        // GET: NvhAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvhAccount nvhAccount = db.NvhAccount.Find(id);
            if (nvhAccount == null)
            {
                return HttpNotFound();
            }
            return View(nvhAccount);
        }

        // GET: NvhAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NvhAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NvhID,NvhUserName,NvhPassword,NvhFullName,NvhEmail,NvhPhone,NvhActive")] NvhAccount nvhAccount)
        {
            if (ModelState.IsValid)
            {
                db.NvhAccount.Add(nvhAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nvhAccount);
        }

        // GET: NvhAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvhAccount nvhAccount = db.NvhAccount.Find(id);
            if (nvhAccount == null)
            {
                return HttpNotFound();
            }
            return View(nvhAccount);
        }

        // POST: NvhAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NvhID,NvhUserName,NvhPassword,NvhFullName,NvhEmail,NvhPhone,NvhActive")] NvhAccount nvhAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvhAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nvhAccount);
        }

        // GET: NvhAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvhAccount nvhAccount = db.NvhAccount.Find(id);
            if (nvhAccount == null)
            {
                return HttpNotFound();
            }
            return View(nvhAccount);
        }

        // POST: NvhAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NvhAccount nvhAccount = db.NvhAccount.Find(id);
            db.NvhAccount.Remove(nvhAccount);
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
        // Login
        public ActionResult NvhLogin()
        {
            var nvhModel = new NvhAccount();
            return View(nvhModel);
        }

        [HttpPost]
         public ActionResult NvhLogin(NvhAccount nvhAccount)
        {
            var nvhCheck = db.NvhAccount.Where(x => x.NvhUserName.Equals(nvhAccount.NvhUserName) && x.NvhPassword.Equals(nvhAccount.NvhPassword)).FirstOrDefault();
            if (nvhCheck != null)
            {
                //Lưu session 
                Session["NvhAccount"] = nvhCheck;
                return Redirect("/");
                
            
            }
            return View(nvhAccount);
        }
    }
}
