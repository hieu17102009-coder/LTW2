using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ontapb4.Models;
using System.Diagnostics;

namespace ontapb4.Controllers
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
            var model = data.Where(x => x.NguyenGia!= null && x.NguyenGia>=20);
            return View(model);
        }

        public  async Task<IActionResult> Locsp(int id)
        {
            var data = await _context.TaiSans.ToListAsync();
            var loai = await _context.LoaiTaiSans.ToListAsync();
            var tenl = loai.FirstOrDefault(x => x.MaLoai == id).TenLoai;
            ViewBag.TenLoai = tenl;
            var model = data.Where(x => x.MaLoai == id && x.NguyenGia != null && x.NguyenGia >= 20);
            return PartialView(model);
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
