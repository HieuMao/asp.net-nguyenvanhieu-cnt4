using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_Onl_NVH.Controllers
{
    /// <summary>
    /// Author: Nguyễn Văn Hiếu
    /// Class: K22CNT4
    /// </summary>
    public class NVHstudentController : Controller
    {
        // GET: NVHstudent
        public ActionResult Index()
        {
            // truyền dữ liệu từ control --> view
            ViewBag.fullName = "Nguyễn Văn Hiếu";
            ViewData["Birthday"] = "24/06/2004";
            TempData["Phone"] = "0987654321";
            return View();
        }
        public ActionResult Details()
        {
            string nvhStr = "";
            nvhStr += "<h3> Họ và tên: Nguyễn Văn Hiếu </h3>";
            nvhStr += "<p> Mã số: 2210900102 ";
            nvhStr += "<p> Địa chỉ mail: hieu28826@gmail.com";

            ViewBag.Details = nvhStr;

            return View("chiTiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "Trần Văn A", "Nguyễn Thị B", "Lê Đại C", "Trịnh Lê D" };
            ViewBag.names = names;
            return View();
        }

        // HTMLHelper
        // GET: TvcStudent/AddNewStudent
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

            string nvhStr = "<h3>" + fullname + "</h3>";
            nvhStr += "<p>" + masv;
            nvhStr += "<p>" + TaiKhoan;
            nvhStr += "<p>" + MatKhau;

            ViewBag.info = nvhStr;

            return View("Ketqua");
            
        }
    }
}
