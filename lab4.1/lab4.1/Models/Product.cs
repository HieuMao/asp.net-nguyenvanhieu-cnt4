using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace lab4._1.Models
{
    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Product")]
        public List<Product> ProductList { get; set; }
    }
    public class Product
    {
        [XmlElement("ProductId")]
        public string ProductId { get; set; }

        [XmlElement("ProductName")]
        public string ProductName { get; set; }

        [XmlElement("Unit")]
        public string Unit { get; set; }

        [XmlElement("Price")]
        public decimal Price { get; set; }
    }
}