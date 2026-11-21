using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ontapb3.Models;

namespace Ontapb3.ViewComponents.MenuViewComponent
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly QltaiSanContext _context;
        public  MenuViewComponent(QltaiSanContext context){
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ds = await _context.LoaiTaiSans.ToListAsync();
            return View(ds);
        }
    }
}
