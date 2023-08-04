using CoffeStore.BL.Concreate;
using CoffeStore.DL.EFDal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeStore.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        AboutManager a = new AboutManager(new EFAboutDal());
        public IActionResult Index()
        {
            var values = a.TGetAll();
            return View(values);
        }
    }
}
