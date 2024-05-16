using Nvh_Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nvh_Lesson04.Controllers
{
    public class NvhCustomerController : Controller
    {
        // GET: NvhCustomer
        public ActionResult Index()
        {
            return View();
        }

        // Action: NvhCustomerDetail
        public ActionResult NvhCustomerDetail()
        {
            // Tạo đối tượng dữ liệu
            var customer = new NvhCustomer()
            {
                CustomerId = 1,
                FirstName = "Nguyễn Văn",
                LastName = "Hiếu",
                Address = "K22CNT4",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }
        // customerlist
        public ActionResult NvhListCustomer()
        {
            var list = new List<NvhCustomer>()
            {
                new NvhCustomer()
                {
                CustomerId = 1,
                FirstName = "Nguyễn Văn",
                LastName = "Hiếu",
                Address = "K22CNT4",
                YearOfBirth = 2004
                },
                new NvhCustomer()
                {
                CustomerId = 2,
                FirstName = "Nguyễn Văn",
                LastName = "Hiếu 2",
                Address = "K22CNT4",
                YearOfBirth = 2004
                },
                new NvhCustomer()
                {
                CustomerId=3,
                FirstName="Đàm Vĩnh",
                LastName="Trinh 1 ",
                Address = "K22CNT4",
                YearOfBirth=2022
                },
                new NvhCustomer()
                {
                CustomerId=4,
                FirstName="Đàm Vĩnh",
                LastName="Trinh 2 ",
                Address = "K22CNT4",
                YearOfBirth=2022
                }
                };

            ViewBag.list = list; // đưa dữ liệu ra view bằng viewbag
            return View(list);
        }
    }
}