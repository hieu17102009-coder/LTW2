using Microsoft.AspNetCore.Mvc;

namespace THWeb1.Controllers
{
    public class DemoControler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
