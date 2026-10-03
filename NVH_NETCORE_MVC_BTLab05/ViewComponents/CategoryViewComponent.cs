using Microsoft.AspNetCore.Mvc;
using NVH_NETCORE_MVC_BTLab05.Models;

namespace NVH_NETCORE_MVC_BTLab05.ViewComponents 
{
    public class CategoryViewComponent : ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            List<Category> categories = Category.Instance;
            return View(categories);
        }
    }
}
