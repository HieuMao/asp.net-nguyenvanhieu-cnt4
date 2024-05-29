using Nguyenvanhieu_BaiThiGiuaKy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Nguyenvanhieu_BaiThiGiuaKy.Controllers
{
    public class NvhCustomerController : Controller

    {
        private static List<NvhCustomer> customers = new List<NvhCustomer>()
    {
        new NvhCustomer { Msv_CustId = "2210900102", Nvh_FullName = "Nguyễn Văn Hiếu", Nvh_Address = "K22cnt4", Nvh_Email = "Hieu28826@example.com", Nvh_Phone = "123456789", Nvh_Balance = 100 },
        new NvhCustomer { Msv_CustId = "2", Nvh_FullName = "Jane Smith", Nvh_Address = "456 Avenue, Town", Nvh_Email = "jane@example.com", Nvh_Phone = "987654321", Nvh_Balance = 150 },
    };

        // GET: NvhCustomer
        /// <summary>
        /// Hiển thị danh sách khách hàng 
        /// Nguyễn Văn Hiếu
        /// </summary>
        /// <returns></returns>
        public ActionResult NvhIndex()
        {
            return View(customers);
        }

        ///get: NvhCreate
        /// <summary>
        /// Thêm mới khách hàng
        /// Nguyễn Văn Hiếu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult NvhCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NvhCreate(NvhCustomer customer)
        {
            // Thêm mới khách hàng vào danh sách
            customers.Add(customer);
            return RedirectToAction("NvhIndex");
        }

        ///get: Detail
        /// <summary>
        /// Thông tin khách hàng
        /// Nguyễn Văn Hiếu
        /// </summary>
        /// <returns></returns>
        public ActionResult NvhDetail(string id)
        {
            var customer = customers.FirstOrDefault(c => c.Msv_CustId == id);
            return View(customer);
        }
        /// <summary>
        /// Chỉnh sửa thông tin
        /// Nguyễn Văn Hiếu
        /// </summary>
        /// <returns></returns>
        public ActionResult NvhEdit(string id)
        {
            var customer = customers.FirstOrDefault(c => c.Msv_CustId == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // Action NvhEdit (POST)
        [HttpPost]
        public ActionResult NvhEdit(NvhCustomer customer)
        {
            if (ModelState.IsValid)
            {
                var existingCustomer = customers.FirstOrDefault(c => c.Msv_CustId == customer.Msv_CustId);
                if (existingCustomer != null)
                {
                    existingCustomer.Nvh_FullName = customer.Nvh_FullName;
                    existingCustomer.Nvh_Address = customer.Nvh_Address;
                    existingCustomer.Nvh_Email = customer.Nvh_Email;
                    existingCustomer.Nvh_Phone = customer.Nvh_Phone;
                    existingCustomer.Nvh_Balance = customer.Nvh_Balance;
                }
                return RedirectToAction("NvhIndex");
            }
            return View(customer);
        }
    }
}
