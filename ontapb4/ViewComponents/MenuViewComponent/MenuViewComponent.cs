using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ontapb4.Models;

namespace ontapb4.ViewComponents.MenuViewComponent
{
    public class MenuViewComponent :ViewComponent
    {
        private readonly QltaiSanContext _context;
        public MenuViewComponent(QltaiSanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _context.LoaiTaiSans.ToListAsync();
            return View(data);
        }
    }
}
