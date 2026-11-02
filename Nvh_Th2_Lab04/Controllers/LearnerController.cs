using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nvh_Th2_Lab04.Data;

namespace Nvh_Th2_Lab04.Controllers
{
    public class LearnerController : Controller
    {
        private SchoolContext db;
        public LearnerController(SchoolContext context)
        {
            db = context;
        }
        public IActionResult Index(int mid)
        {
            {
                var learners = db.Learners.Include(m => m.Major).ToList();
                return View(learners);
            }
         }
          
        public IActionResult LearnerByMajorId(int mid)
        {
            var learners = db.Learners.Where(l => l.MajorID == mid).Include(m => m.Major).ToList();
            return PartialView("LearnerTable",learners);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
