using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ontapb3.Models;
using System.Diagnostics;

namespace Ontapb3.Controllers
{
    public class HomeController : Controller
    {
        private readonly QltaiSanContext _context;
        public HomeController(QltaiSanContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.TaiSans.ToListAsync();
            return View(data);
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
        public async Task<IActionResult> TaSanTheoLoai(int maLoai)
        {
            var data = await _context.TaiSans.FindAsync(maLoai);
            return PartialView(data);
        }
    }
}
