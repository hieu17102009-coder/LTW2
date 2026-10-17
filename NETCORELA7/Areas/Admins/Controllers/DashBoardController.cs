using Microsoft.AspNetCore.Mvc;

namespace NETCORELA7.Areas.Admins.Controllers
{
    public class DashBoardController : Controller
    {
        [Area("Admins")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
