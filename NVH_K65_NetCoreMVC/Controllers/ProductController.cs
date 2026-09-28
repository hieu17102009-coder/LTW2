using Microsoft.AspNetCore.Mvc;

namespace NVH_K65_NetCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
