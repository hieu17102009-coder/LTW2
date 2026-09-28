using Bai2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai2.Controllers
{
    public class NVHProduct : Controller
    {
        public IActionResult Index()
        {
            ViewBag.hello = "Chuyen du lieu bang ViewBag";
            ViewData["hello"] = "Chuyen du lieu thanh cong bang viewdata";
            TempData["hello"] = "Chuyen du lieu thanh cong bang tempdata";
            Product product = new Product()
            {
               Id = 1,
               Name = "Hieu",
               YearRelease = 2036,
            };
            ViewBag.product = product;
            ViewData["product"] = product;
            return View();
        }
        public IActionResult GetAllProducts()
        {
            List<Product> products = new List<Product>() {
                new Product() { Id = 2, Name = "Khanh", YearRelease=2026},
                new Product() { Id = 2, Name = "Khanh", YearRelease=2026},
                new Product() { Id = 2, Name = "Khanh", YearRelease=2026},
                new Product() { Id = 2, Name = "Khanh", YearRelease=2026},
            };
            ViewBag.products = products;
            return View("Products");
        }
    }
}
