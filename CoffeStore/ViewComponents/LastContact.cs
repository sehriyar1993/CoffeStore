using CoffeStore.BL.Concreate;
using CoffeStore.DL.EFDal;
using Microsoft.AspNetCore.Mvc;

namespace CoffeStore.ViewComponents
{
    public class LastContact : ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EFContactDAl());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetAll();
            return View(values);
        }
    }
}
