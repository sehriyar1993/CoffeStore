using CoffeStore.BL.Concreate;
using CoffeStore.DL.EFDal;
using Microsoft.AspNetCore.Mvc;

namespace CoffeStore.ViewComponents
{
    public class LastOrder : ViewComponent
    {
        ProductManager order = new ProductManager(new EFProductDal());
        public IViewComponentResult Invoke()
        {
            var values = order.TGetAll();
            return View(values);
        }
    }
}
