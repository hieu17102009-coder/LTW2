using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab05.Models;
using System.Text.RegularExpressions;

namespace NetCoreMVCLab05.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        private static readonly List<Account> accounts = new List<Account>();
        public ActionResult Index()
        {     
            return View(accounts);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            Account account = new Account();
            return View(account);
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Account model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Id = accounts.Count() + 1;
                    accounts.Add(model);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [AcceptVerbs("GET","POST")]
        public IActionResult VerifyPhone(string phone)
        {
            Regex is_phone = new Regex(@"^\(?([0-9]{3})\)?{-.}?([0-9]{3})?[-.]?([0-9]{4})$");
            if (!is_phone.IsMatch(phone)){
                return Json($"So dien thoai {phone} sai dinh dang,vd: 0938638222 hoac 092.863.8222");
            }
            else {
                return Json(true);
            }
        }
    }
}
