using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nvh_Th2_Lab04.Data;
using Nvh_Th2_Lab04.Models;

namespace Nvh_Th2_Lab04.Controllers
{
    public class LearnerController : Controller
    {
        private SchoolContext db;
        private int pageSize =3;
        public LearnerController(SchoolContext context)
        {
            db = context;
        }
        public IActionResult Index(int? mid)
        {
            var learners = (IQueryable<Learner>)db.Learners.Include(m => m.Major);
            if(mid!= null)
            {
                learners = (IQueryable<Learner>)db.Learners.Where(l => l.MajorID == mid).Include(m => m.MajorID).ToList();
            }
            int pageNum = (int)Math.Ceiling(learners.Count()/(float)pageSize);
            ViewBag.PageNum = pageNum;
            var result = learners.Take(pageSize).ToList();
            return View(result);
         }
        public IActionResult LearnerFilter(int? mid, string? keyword, int? pageIndex)
        {
            var learners = (IQueryable<Learner>) db.Learners;
            int page = (int)(pageIndex == null || pageIndex <= 0 ? 1 : pageIndex);
            if(mid!= null)
            {
                learners = learners.Where(l => l.MajorID==mid);
                ViewBag.mid = mid;
            }
            if(keyword!= null)
            {
                learners = learners.Where(l => l.FirstMidName.ToLower().Contains(keyword.ToLower()));
            }
            ViewBag.keyword = keyword;
            int pageNum = (int)Math.Ceiling(learners.Count() / (float)pageSize);
            ViewBag.pageNum = pageNum;
            var result = learners.Skip(pageSize* (page-1)).Take(pageSize).ToList();
            return PartialView("LearnerTable", result);
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
