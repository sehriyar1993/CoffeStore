using CoffeStore.DL;
using Microsoft.AspNetCore.Mvc;

namespace CoffeStore.ViewComponents
{
    public class AppuserAdminNAv : ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            var name = User.Identity.Name;
            ViewBag.name = c.Users.Where(x => x.UserName == name).Select(y => y.NameSurname).FirstOrDefault();
            var usermail = c.Users.Where(x => x.UserName == name).Select(y => y.Email).FirstOrDefault();
            ViewBag.ImageUrlAdmin = c.Users.Where(x => x.UserName == name).Select(y => y.Image).FirstOrDefault();
            ViewBag.EmailAdmin = usermail;
            return View();
        }
    }
}
