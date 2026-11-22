using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnTapLtw.Models;
using System.Diagnostics;

namespace OnTapLtw.Controllers
{
    public class HomeController : Controller
    {
        private readonly QlhangHoaContext _context;
        public HomeController(QlhangHoaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.HangHoas.ToListAsync();
            var models = data.Where(x => x.Gia >= 100);
            return View(models);
        }

        public IActionResult Create()
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
