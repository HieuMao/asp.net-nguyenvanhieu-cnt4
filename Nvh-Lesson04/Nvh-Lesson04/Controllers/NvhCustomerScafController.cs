
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nvh_Lesson04.Models;

namespace Nvh_Lesson04.Controllers
{
    public class NvhCustomerScafController : Controller
    {
        //mockdata 
        private static List<NvhCustomer> listCustomer = new List<NvhCustomer>()
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
                CustomerId = 3,
                FirstName = "Đàm Vĩnh",
                LastName = "Trinh 1 ",
                Address = "K22CNT4",
                YearOfBirth = 2022
            },
            new NvhCustomer()
            {
                CustomerId = 4,
                FirstName = "Đàm Vĩnh",
                LastName = "Trinh 2 ",
                Address = "K22CNT4",
                YearOfBirth = 2022
            }
         };

    // GET: NvhCustomerScaf
    //list customer

    public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult NvhCreate()
        {
            var model = new NvhCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult NvhCreate(NvhCustomer model )
        {
            // thêm mới đối tượng khách hàng
            listCustomer.Add(model);

            //return View(model);
            // chuyển về trang danh sách 
            return RedirectToAction("Index");
        }
        public ActionResult NvhEdit(int id )
        {
            var customer =listCustomer.FirstOrDefault(x=>x.CustomerId==id);
            return View(customer);
        }
    }
}