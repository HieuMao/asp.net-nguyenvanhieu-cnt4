using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NvhK22CNT4Lesson11_2210900102.Controllers
{
    public class NvhHomeController : Controller
    {
        public ActionResult NvhIndex()
        {
            return View();
        }

        public ActionResult NvhAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NvhContact()
        {
            ViewBag.msv = "2210900102";
            ViewBag.fullname = "Nguyễn Văn Hiếu";

            return View();
        }
    }
}