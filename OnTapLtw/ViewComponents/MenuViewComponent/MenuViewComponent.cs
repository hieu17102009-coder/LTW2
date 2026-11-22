using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnTapLtw.Models;

namespace OnTapLtw.ViewComponents.MenuViewComponent
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly QlhangHoaContext _context;
        public MenuViewComponent(QlhangHoaContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _context.LoaiHangs.ToListAsync();
            return View(data);
        }
    }
}
