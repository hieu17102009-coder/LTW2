using Microsoft.AspNetCore.Mvc;
using NVH_NETCORE_MVC_BTLab05.Models;
using System.Diagnostics;

namespace NVH_NETCORE_MVC_BTLab05.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
