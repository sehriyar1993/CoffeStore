using CoffeStore.DL;
using Microsoft.AspNetCore.Mvc;

namespace CoffeStore.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            ViewBag.g = 256;
            ViewBag.t = 99;
            ViewBag.m = 65;
            return View();
        }
    }
}
