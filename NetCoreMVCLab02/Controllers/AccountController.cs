using BTT2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection;
using System.Xml.Linq;
namespace BTT2.Controllers
{
    public class AccountController : Controller
    {
        [Route("Tai-khoan",Name = "account")]
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>()
            {
                new Account()
                {
                    Id = 1,
                    Name = "Hoang Anh",
                    Email = "anh@gmail.com",
                    Phone = "0911010123",
                    Address = "Ha Noi",
                    Avatar = Url.Content("/AVARTAR/OIP (1).jpg"),
                    Gender = 1, Bio = "My name is small",
                    Birthday = new DateTime(1988,7,15)
                },
                new Account(){
                    Id = 2,
                    Name = "Truong Giang",
                    Email = "giang@gmail.com",
                    Phone = "0911789789",
                    Address = "Ha Noi",
                    Avatar = Url.Content("/AVARTAR/OIP (2).jpg"),
                    Gender = 1, Bio = "My name is small",
                    Birthday = new DateTime(1988,7,15)
                },
                new Account(){
                    Id = 3,
                    Name = "Hoang Thuy",
                    Email = "thuy@gmail.com",
                    Phone = "0936789789",
                    Address = "Ha Noi",
                    Avatar = Url.Content("/AVARTAR/OIP (3).jpg"),
                    Gender = 1, Bio = "My name is small",
                    Birthday = new DateTime(1988,7,15)
                },
                
            };
            ViewBag.Accounts = accounts;
            return View();
        }
        [Route("ho-so-cua-toi", Name= "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>()
            {
                new Account()
                {
                    Id = 1,
                    Name = "Hoang Anh",
                    Email = "anh@gmail.com",
                    Phone = "0911010123",
                    Address = "Ha Noi",
                    Avatar = Url.Content("/AVARTAR/OIP (1).jpg"),
                    Gender = 1, Bio = "My name is small",
                    Birthday = new DateTime(1988,7,15)
                },
                new Account(){
                    Id = 2,
                    Name = "Truong Giang",
                    Email = "giang@gmail.com",
                    Phone = "0911789789",
                    Address = "Ha Noi",
                    Avatar = Url.Content("/AVARTAR/OIP (2).jpg"),
                    Gender = 1, Bio = "My name is small",
                    Birthday = new DateTime(1988,7,15)
                },
                new Account(){
                    Id = 3,
                    Name = "Hoang Thuy",
                    Email = "thuy@gmail.com",
                    Phone = "0936789789",
                    Address = "Ha Noi",
                    Avatar = Url.Content("/AVARTAR/OIP (3).jpg"),
                    Gender = 1, Bio = "My name is small",
                    Birthday = new DateTime(1988,7,15)
                },

            };
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            ViewBag.account = account;
            return View();
        }
    }
}
