using Microsoft.AspNetCore.Mvc;
using NVHLesson07.Models;

namespace NVHLesson07.Controllers
{
    public class NvhMemberController : Controller
    {
        private static List<NVHMember> lst = new List<NVHMember>();
        public IActionResult Index()
        {
            return View(lst);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(NVHMember nVHMember)
        {
            try
            {
                if (ModelState.IsValid)
            {
                Console.WriteLine("Dep trei nhat the gioi da den");
                nVHMember.Id = Guid.NewGuid().ToString();
                lst.Add(nVHMember);
                
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in ModelState)
                {
                    foreach (var error in item.Value.Errors)
                    {
                        Console.WriteLine(
                            $"Field: {item.Key} - Error: {error.ErrorMessage}"
                        );
                    }
                }
                Console.WriteLine("Dep trai nhi the gioi da den");
                return View(nVHMember);
            }
            }
            catch
            {
                return View();
            }
        }
        public IActionResult Edit(string id)
        {
            NVHMember nvh = lst.FirstOrDefault(x => x.Id == id);
            return View(nvh);
        }
        [HttpPost] 
        public IActionResult Edit(NVHMember nvhMember) {
            NVHMember nVHMember = lst.FirstOrDefault(x =>x.Id == nvhMember.Id);
            nVHMember = nvhMember;
            return RedirectToAction("Index");
        }
    }
}
