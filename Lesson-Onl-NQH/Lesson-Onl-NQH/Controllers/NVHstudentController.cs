using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_Onl_nqh.Controllers
{
    /// <summary>
    /// Author: Cao Văn Bình
    /// Class: K22CNT4
    /// </summary>
    public class nqhstudentController : Controller
    {
        // GET: nqhstudent
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
            string nqhStr = "";
            nqhStr += "<h3> Họ và tên: Nguyễn Quang Huy </h3>";
            nqhStr += "<p> Mã số: 2210900102 ";
            nqhStr += "<p> Địa chỉ mail: nqh2805@gmail.com";

            ViewBag.Details = nqhStr;

            return View("chiTiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "Trần Văn A", "Nguyễn Thị B", "Lê Đại C", "Trịnh Lê D" };
            ViewBag.names = names;
            return View();
        }

        // HTMLHelper
        // GET: nqhstudent/AddNewStudent
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

            string nqhStr = "<h3>" + fullname + "</h3>";
            nqhStr += "<p>" + masv;
            nqhStr += "<p>" + TaiKhoan;
            nqhStr += "<p>" + MatKhau;

            ViewBag.info = nqhStr;

            return View("Ketqua");
            
        }
    }
}
