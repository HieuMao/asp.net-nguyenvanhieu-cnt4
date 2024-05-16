using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_Onl_cvb.Controllers
{
    /// <summary>
    /// Author: Cao Văn Bình
    /// Class: K22CNT4
    /// </summary>
    public class cvbstudentController : Controller
    {
        // GET: cvbstudent
        public ActionResult Index()
        {
            // truyền dữ liệu từ control --> view
            ViewBag.fullName = "Cao Văn Bình";
            ViewData["Birthday"] = "24/06/2004";
            TempData["Phone"] = "0987654321";
            return View();
        }
        public ActionResult Details()
        {
            string cvbStr = "";
            cvbStr += "<h3> Họ và tên: Cao Văn Bình </h3>";
            cvbStr += "<p> Mã số: 2210900095 ";
            cvbStr += "<p> Địa chỉ mail: cvb2101@gmail.com";

            ViewBag.Details = cvbStr;

            return View("chiTiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "Trần Văn A", "Nguyễn Thị B", "Lê Đại C", "Trịnh Lê D" };
            ViewBag.names = names;
            return View();
        }

        // HTMLHelper
        // GET: CVBstudent/AddNewStudent
            public ActionResult AddNewStudent()
            {
            return View();       
            }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            // lấy dữ liệu trên form
            string fullname = form["fullName"];
            string masv = form["maSV"];
            string TaiKhoan = form["TaiKhoan"];
            string MatKhau = form["MatKhau"];

            string cvbStr = "<h3>" + fullname + "</h3>";
            cvbStr += "<p>" + masv;
            cvbStr += "<p>" + TaiKhoan;
            cvbStr += "<p>" + MatKhau;

            ViewBag.info = cvbStr;

            return View("Ketqua");
            
        }
    }
}
