using Microsoft.AspNetCore.Mvc;
using NVH_K65_NetCoreMVC.Models;
using System.Diagnostics;

namespace NVH_K65_NetCoreMVC.Controllers
{
    public class Home : Controller
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
