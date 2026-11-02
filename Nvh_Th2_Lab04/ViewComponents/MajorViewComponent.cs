using Microsoft.AspNetCore.Mvc;
using Nvh_Th2_Lab04.Data;
using Nvh_Th2_Lab04.Models;

namespace Nvh_Th2_Lab04.ViewComponents
{
    public class MajorViewComponent: ViewComponent
    {
        SchoolContext db;
        List<Major> lst;
        public MajorViewComponent(SchoolContext _context)
        {
            db = _context;
            lst = db.Majors.ToList();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderMajor", lst);
        }
    }
}
