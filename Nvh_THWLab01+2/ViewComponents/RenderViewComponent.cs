using Microsoft.AspNetCore.Mvc;
using Nvh_THWLab01.Models;

namespace Nvh_THWLab01.ViewComponents
{
    public class RenderViewComponent: ViewComponent
    {
        private List<MenuItem> mn = new List<MenuItem>();
        public RenderViewComponent() {
            mn = new List<MenuItem>
            {
                new MenuItem() { Id = 1,Name = "Branchs", Link="Branchs/List"},
                new MenuItem() { Id = 2, Name = "Students", Link = "Students/List" },
                new MenuItem() { Id = 3, Name = "Subjects", Link = "Subjects/List" },
                new MenuItem() { Id = 4, Name = "Courses", Link = "Courses/List" },
            };
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderLeftMenu", mn);
        }
    }
}
