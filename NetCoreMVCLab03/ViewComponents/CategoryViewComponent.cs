using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCLab03.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Category> categories = new List<Category>()
            {
                new Category(1,"Dien tu"),
                new Category(2,"Dien lanh"),
                new Category(3,"Do gia dung"),
                new Category(4,"Tien ich"),
            };
            return View(categories);
        }
    }
}
