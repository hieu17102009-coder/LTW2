using DemoCuaThay.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace DemoCuaThay.Controllers
{
    public class SVController : Controller
    {
        public IActionResult Index()
        {
            return View(SV.ListSV);
        }
        public IActionResult Details(string id) {
            SV sv = new SV();
            foreach(var item in SV.ListSV)
            {
                if(Equals(item.SvId, id))
                {
                    sv = item;
                    break;
                }
            }
            
            return View(sv);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SV sv) {
            sv.SvId = Guid.NewGuid().ToString();
            SV.ListSV.Add(sv);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(string id)
        {
            SV sv = new SV();
            sv = SV.ListSV.FirstOrDefault(x => x.SvId == id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult Edit(string id,SV sv) 
        {
            sv.SvId = id;
            for (int i = 0; i < SV.ListSV.Count();i++ )
            {
                if (SV.ListSV[i].SvId == sv.SvId)
                {
                    SV.ListSV[i] = sv;
                    break;
                }
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(string id) 
        {
            SV sv = SV.ListSV.FirstOrDefault(sv => sv.SvId ==id);
            return View(sv);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(string SvId) 
        {
            SV sv = SV.ListSV.FirstOrDefault(x => x.SvId == SvId);
            SV.ListSV.Remove(sv);
            return RedirectToAction("Index");
        }
    }
}
