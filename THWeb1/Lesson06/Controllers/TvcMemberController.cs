using Lesson06.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson06.Controllers
{
    public class TvcMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail (){
            var tvcMember = new TvcMember("Nguyen Van Hieu", Guid.NewGuid().ToString());
            return View(tvcMember);
        }
    }
}
