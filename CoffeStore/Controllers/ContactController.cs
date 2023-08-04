using CoffeStore.BL.Concreate;
using CoffeStore.DL.EFDal;
using CoffeStore.EL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeStore.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EFContactDAl());
        NewsLetterManager nm = new NewsLetterManager(new EFNewsLetterDAl());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.Status = true;
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            contactManager.TInsert(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult NewsLetter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewsLetter(NewsLetter p)
        {
            p.Status = true;
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            nm.TInsert(p);
            return RedirectToAction("Index", "Home");
        }
    }
}
