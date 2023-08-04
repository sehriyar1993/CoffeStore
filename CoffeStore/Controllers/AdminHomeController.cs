using CoffeStore.BL.Concreate;
using CoffeStore.DL;
using CoffeStore.DL.EFDal;
using CoffeStore.EL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoffeStore.Controllers
{
    public class AdminHomeController : Controller
    {
        HomeManager homeManager = new HomeManager(new EFHomeDal());

        public IActionResult Index(int page = 1)
        {
            var values = homeManager.TGetAll();
            return View(values);
        }
       
        [HttpGet]
        public IActionResult Add()
        {

           
            return View();
        }
        [HttpPost]
        public IActionResult Add(HomeClass p)
        {
            p.Status = true;
            homeManager.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var values = homeManager.TGetByID(id);
            homeManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]

        public IActionResult Update(int id)
        {
         
            var values = homeManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]

        public IActionResult Update(HomeClass p)
        {
            homeManager.TUpdate(p);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToTrue(int id)
        {
            Context c = new Context();
            var values = c.HomeClasses.Find(id);
            values.Status = true;
            c.Update(values);
            c.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult ChangeToFalse(int id)
        {
            Context c = new Context();
            var values = c.HomeClasses.Find(id);
            values.Status = false;
            c.Update(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
