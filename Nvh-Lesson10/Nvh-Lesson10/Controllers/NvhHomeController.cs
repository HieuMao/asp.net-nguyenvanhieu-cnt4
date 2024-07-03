using Nvh_Lesson10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nvh_Lesson10.Controllers
{
    public class NvhHomeController : Controller
    {
        public ActionResult NvhIndex()
        {
            // kiểm tra dữ liệu trong session
            if (Session["NvhAccount"] != null)
            {
                var nvhAccount = Session["NvhAccount"] as NvhAccount;
                ViewBag.FullName = nvhAccount.NvhFullName;
            }
            return View();
        }

        public ActionResult NvhAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NvhContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}