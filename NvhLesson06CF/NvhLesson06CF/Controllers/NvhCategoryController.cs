using NvhLesson06CF.Models;
using System.Linq;
using System.Web.Mvc;

namespace NvhLesson06CF.Controllers
{
    public class NvhCategoryController : Controller
    {
        private static NvhBookStore nvhDb;
        public NvhCategoryController()
        {
            nvhDb = new NvhBookStore();

        }
        // GET: NvhCategory
        public ActionResult NvhIndex()
        {
            /*
             *  khởi tạo tệp net framework
             *  tạo csdl
             * */


            var NvhCategory = nvhDb.NvhCategory.ToList();
            return View(NvhCategory);
        }
        public ActionResult NvhCreate ()
        {
            var nvhCategory = new NvhCategory();
            return View(nvhCategory);
        }
        [HttpPost]
        public ActionResult NvhCreate(NvhCategory nvhCategory)
        {
            nvhDb.NvhCategory.Add(nvhCategory);
            nvhDb.SaveChanges();

                return RedirectToAction("NvhIndex");
                
        }


    }
}