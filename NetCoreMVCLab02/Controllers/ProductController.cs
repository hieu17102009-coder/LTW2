using Microsoft.AspNetCore.Mvc;
using BTT2.Models;
namespace BTT2.Controllers
{
    public class ProductController : Controller
    {
        [Route("danh-sach-san-pham",Name ="product")]
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Bộ đồ bơi cho trẻ em nam ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2006,10,17),
                    Type = 1,
                    Img = Url.Content("/IMG/OIP.jpg")
                },
                new Product()
                {
                    Id = 2,
                    Name = "Bộ đồ bơi cho trẻ em nu ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2026,11,2),
                    Type =1,
                    Img =Url.Content("/IMG/OIP (4).jpg"),
                },
                new Product()
                {
                    Id = 3,
                    Name = "Bộ đồ bơi cho trẻ em từ 3 đến 5 tuổi ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2021,5,20),
                    Type = 1,
                    Img =Url.Content("/IMG/OIP (5).jpg")
                },
                new Product()
                {
                    Id = 4,
                    Name = "Bộ đồ bơi cho trẻ em thoi trang ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2021,5,20),
                    Type = 1,
                    Img =Url.Content("/IMG/OIP (6).jpg")
                },
                new Product()
                {
                    Id = 5,
                    Name = "Túi thời trang mẫu mới 2021 ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2021,5,20),
                    Type = 2,
                    Img =Url.Content("/IMG/OIP (7).jpg")
                },
                new Product()
                {
                    Id = 6,
                    Name = "Túi thời trang da cá sấu ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2021,5,20),
                    Type = 2,
                    Img =Url.Content("/IMG/OIP (8).jpg")
                }
            };
            ViewBag.Products = products;
            return View();
        }
        [Route("Tìm-kiếm-theo-loại-đồ)", Name = "Type")]
        public IActionResult Typee(int type)
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Bộ đồ bơi cho trẻ em nam ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2006, 10, 17),
                    Type = 1,
                    Img = Url.Content("/IMG/OIP.jpg")
                },
                new Product()
                {
                    Id = 2,
                    Name = "Bộ đồ bơi cho trẻ em nu ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2026, 11, 2),
                    Type = 1,
                    Img = Url.Content("/IMG/OIP (4).jpg")
                },
                new Product()
                {
                    Id = 3,
                    Name = "Bộ đồ bơi cho trẻ em từ 3 đến 5 tuổi ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2021, 5, 20),
                    Type = 1,
                    Img = Url.Content("/IMG/OIP (5).jpg")
                },
                new Product()
                {
                    Id = 4,
                    Name = "Bộ đồ bơi cho trẻ em thoi trang ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2021, 5, 20),
                    Type = 1,
                    Img = Url.Content("/IMG/OIP (6).jpg")
                },
                new Product()
                {
                    Id = 5,
                    Name = "Túi thời trang mẫu mới 2021 ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2021, 5, 20),
                    Type = 2,
                    Img = Url.Content("/IMG/OIP (7).jpg")
                },
                new Product()
                {
                    Id = 6,
                    Name = "Túi thời trang da cá sấu ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2021, 5, 20),
                    Type = 2,
                    Img = Url.Content("/IMG/OIP (8).jpg")
                }
            };
            ViewBag.ProductT = products.Where(pr => pr.Type == type).ToList();
            return View();
        }
        [Route("Chi-tiết-sản-phẩm",Name = "Detail" )]
        public IActionResult Detail(int id)
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Bộ đồ bơi cho trẻ em nam ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2006, 10, 17),
                    Type = 1,
                    Img = Url.Content("/IMG/OIP.jpg")
                },
                new Product()
                {
                    Id = 2,
                    Name = "Bộ đồ bơi cho trẻ em nu ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2026, 11, 2),
                    Type = 1,
                    Img = Url.Content("/IMG/OIP (4).jpg")
                },
                new Product()
                {
                    Id = 3,
                    Name = "Bộ đồ bơi cho trẻ em từ 3 đến 5 tuổi ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2021, 5, 20),
                    Type = 1,
                    Img = Url.Content("/IMG/OIP (5).jpg")
                },
                new Product()
                {
                    Id = 4,
                    Name = "Bộ đồ bơi cho trẻ em thoi trang ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2021, 5, 20),
                    Type = 1,
                    Img = Url.Content("/IMG/OIP (6).jpg")
                },
                new Product()
                {
                    Id = 5,
                    Name = "Túi thời trang mẫu mới 2021 ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2021, 5, 20),
                    Type = 2,
                    Img = Url.Content("/IMG/OIP (7).jpg")
                },
                new Product()
                {
                    Id = 6,
                    Name = "Túi thời trang da cá sấu ",
                    Price = 500000,
                    discount = 150000,
                    Info = "Lorem ipsum dolor sit amet consectetur adipisicing elit ab accusantium aliquid architecto aspernatur at atque beatae blanditiis commodi consequatur consequuntur corporis cumque cupiditate debitis delectus deleniti deserunt dicta dignissimos distinctio.",
                    Availbe = true,
                    Datepost = new DateTime(2021, 5, 20),
                    Type = 2,
                    Img = Url.Content("/IMG/OIP (8).jpg")
                }
            };
            var product = products.FirstOrDefault(pro => pro.Id == id);
            ViewBag.Product1 = product;
            return View();
        }
    }
}
