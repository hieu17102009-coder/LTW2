using Microsoft.AspNetCore.Mvc;
using NVH_NETCORE_MVC_BTLab05.Models;

namespace NVH_NETCORE_MVC_BTLab05.Controllers
{
    public class ProductController : Controller
    {
        private static List<string> ban = new List<string> { "dead", "admin", "love" };
        private static readonly List<Product> products = new List<Product>{
            new Product
            {
                Id = 1,
                Name = "iPhone 15 Pro Max",
                Image = "/images/Products/iphone15promax.jpg",
                Price = 29990000,
                SalePrice = 27000000,
                Description = "Điện thoại cao cấp với thiết kế sang trọng, hiệu năng mạnh mẽ và camera chất lượng cao.",
                CategoryId = 1
            },

            new Product
            {
                Id = 2,
                Name = "Samsung Galaxy S24 Ultra",
                Image = "/images/Products/s24ultra.jpg",
                Price = 27990000,
                SalePrice = 25000000,
                Description = "Điện thoại flagship Samsung với màn hình lớn, camera chuyên nghiệp và hiệu năng mạnh.",
                CategoryId = 1
            },

            new Product
            {
                Id = 3,
                Name = "Xiaomi Redmi Note 13",
                Image = "/images/Products/redminote13.jpg",
                Price = 5990000,
                SalePrice = 5500000,
                Description = "Điện thoại tầm trung với màn hình đẹp, pin dung lượng cao và hiệu năng ổn định.",
                CategoryId = 1
            },

            new Product
            {
                Id = 4,
                Name = "MacBook Air M3",
                Image = "/images/Products/macbookairm3.jpg",
                Price = 24990000,
                SalePrice = 23000000,
                Description = "Laptop mỏng nhẹ sử dụng chip Apple M3, phù hợp cho học tập và công việc.",
                CategoryId = 2
            },

            new Product
            {
                Id = 5,
                Name = "Dell Inspiron 15",
                Image = "/images/Products/dellinspiron15.jpg",
                Price = 15990000,
                SalePrice = 14500000,
                Description = "Laptop phổ thông với màn hình lớn, hiệu năng ổn định cho học tập và văn phòng.",
                CategoryId = 2
            },

            new Product
            {
                Id = 6,
                Name = "iPad Air M2",
                Image = "/images/Products/ipadairm2.jpg",
                Price = 16990000,
                SalePrice = 15500000,
                Description = "Máy tính bảng thiết kế mỏng nhẹ, màn hình sắc nét và hiệu năng mạnh mẽ.",
                CategoryId = 3
            },

            new Product
            {
                Id = 7,
                Name = "Samsung Galaxy Tab S9",
                Image = "/images/tabs9.png",
                Price = 18990000,
                SalePrice = 17500000,
                Description = "Máy tính bảng cao cấp với màn hình chất lượng cao và thời lượng pin tốt.",
                CategoryId = 3
            },

            new Product
            {
                Id = 8,
                Name = "AirPods Pro 2",
                Image = "/images/Products/airpodspro2.jpg",
                Price = 5990000,
                SalePrice = 5500000,
                Description = "Tai nghe không dây hỗ trợ chống ồn chủ động và mang lại chất lượng âm thanh tốt.",
                CategoryId = 4
            },

            new Product
            {
                Id = 9,
                Name = "Sony WH-1000XM5",
                Image = "/images/Products/sonywh1000xm5.webp",
                Price = 8990000,
                SalePrice = 8200000,
                Description = "Tai nghe chụp tai cao cấp với khả năng chống ồn và âm thanh chất lượng cao.",
                CategoryId = 4
            },

            new Product
            {
                Id = 10,
                Name = "Sạc nhanh Anker 65W",
                Image = "/images/Products/anker65w.webp",
                Price = 1290000,
                SalePrice = 1100000,
                Description = "Củ sạc nhanh công suất 65W, hỗ trợ nhiều thiết bị và có thiết kế nhỏ gọn.",
                CategoryId = 5
            }
    };
        
        [AcceptVerbs("GET", "POST")]
        public IActionResult SalePriceCheck(float SalePrice, float Price)
        {
            if (SalePrice <= Price * 0.9)
            {
                return Json(true);
            }
            else
            {
                return Json("Giá sale phải nhỏ hơn giá chuẩn 10% ");
            }
        }
        [AcceptVerbs("GET", "POST")]
        public IActionResult DescriptionCheck(string Description)
        {
            foreach (var b in ban)
            {
                if (Description.Contains(b, StringComparison.OrdinalIgnoreCase))
                {
                    return Json($"Mô tả của bạn có chứa từ khóa nhạy cảm : {b}");
                }
            }
            return Json(true);
        }
        [AcceptVerbs("GET", "POST")]
        public IActionResult CategoryIdCheck(int CategoryId)
        {
            foreach (var c in Category.Instance)
            {
                if (c.Id == CategoryId)
                {
                    return Json(true);
                }
            }
            return Json($"CategoryId ({CategoryId}) không có sẵn!!!");
        }
        public IActionResult Index()
        {
            return View(products);
        }
        public IActionResult Create()
        {
            Product product = new Product();
            return View(product);
        }
        [HttpPost]
        public IActionResult Create(Product product) {
            try
            {
                if (ModelState.IsValid)
                {
                    product.Id = products.Count() + 1;
                    products.Add(product);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(product);
                }
            }
            catch{
                return View(product);
            }
        }
    }
}
