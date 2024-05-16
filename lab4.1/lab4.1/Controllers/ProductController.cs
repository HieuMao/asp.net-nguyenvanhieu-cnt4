using lab4._1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using System.Web.Hosting;
using Microsoft;


public class Logger
{
    public static void LogError(Exception ex, string message)
    {
        Console.WriteLine($"Error: {message}. Exception: {ex.Message}");
    }
}
namespace lab4._1.Controllers
{
    public class ProductController : Controller
    {
        private string xmlFilePath = HostingEnvironment.MapPath("~/App_Data/Products.xml");
        // Action để hiển thị danh sách sản phẩm
        public ActionResult Index()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Products));
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            {
                Products productList = (Products)serializer.Deserialize(fileStream);
                return View(productList.ProductList);
            }
        }
        public ActionResult Add()
        {
            var model = new ProductViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Add(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var products = ReadProductsFromXml();
                    products.Add(new ProductViewModel
                    {
                        ProductId = model.ProductId,
                        ProductName = model.ProductName,
                        Unit = model.Unit,
                        Price = model.Price
                    });
                    WriteProductsToXml(products);
                    return RedirectToAction("Index", "Product");
                }
                catch (Exception ex )

                {
                    Logger.LogError(ex, "Error occurred while adding product");
                    ModelState.AddModelError("", "An error occurred while adding the product. Please try again later.");
                }
            }
            return View(model);
        }

        private List<ProductViewModel> ReadProductsFromXml()
        {
            List<ProductViewModel> products = new List<ProductViewModel>();

            if (System.IO.File.Exists(xmlFilePath))
            {
                using (var reader = new StreamReader(xmlFilePath))
                {
                    var serializer = new XmlSerializer(typeof(List<ProductViewModel>));
                    products = (List<ProductViewModel>)serializer.Deserialize(reader);
                }
            }

            return products;
        }
        private void WriteProductsToXml(List<ProductViewModel> products)
        {
            using (var writer = new StreamWriter(xmlFilePath))
            {
                var serializer = new XmlSerializer(typeof(List<ProductViewModel>));
                serializer.Serialize(writer, products);
            }
        }


    }
}
