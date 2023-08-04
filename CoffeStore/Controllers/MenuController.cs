using CoffeStore.BL.Concreate;
using CoffeStore.DL.EFDal;
using CoffeStore.EL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeStore.Controllers
{
    [AllowAnonymous]
    public class MenuController : Controller
    {
        ProductManager product = new ProductManager(new EFProductDal());
        public IActionResult Index(int id)
        {
            var values = product.TListForFilter(x=>x.CategoryId == id);
            return View(values);
        }
    }
}
