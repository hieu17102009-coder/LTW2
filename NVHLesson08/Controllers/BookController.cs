using Microsoft.AspNetCore.Mvc;

namespace NVHLesson08.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
