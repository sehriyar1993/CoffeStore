using CoffeStore.BL.Concreate;
using CoffeStore.DL.EFDal;
using Microsoft.AspNetCore.Mvc;

namespace CoffeStore.ViewComponents
{
    public class NletterMailSend : ViewComponent
    {
        NewsLetterManager nm = new NewsLetterManager(new EFNewsLetterDAl());
        public IViewComponentResult Invoke()
        {
            var values = nm.TGetAll();
            return View(values);
        }
    }
}
