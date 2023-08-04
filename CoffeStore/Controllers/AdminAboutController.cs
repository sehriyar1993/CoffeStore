using CoffeStore.BL.Abstract;
using CoffeStore.BL.Concreate;
using CoffeStore.DL;
using CoffeStore.DL.EFDal;
using CoffeStore.EL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CoffeStore.Controllers
{
    public class AdminAboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDal());
        public IActionResult AdminIndex()
        {
            var values = aboutManager.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
       

        [HttpPost]
        public IActionResult Add(About bag)
        {
            bag.Status = true;
            aboutManager.TInsert(bag);
            return RedirectToAction("AdminIndex");
        }
        

        public IActionResult Delete(int id)
        {
            var values = aboutManager.TGetByID(id);
            aboutManager.TDelete(values);
            return RedirectToAction("AdminIndex");

        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var values = aboutManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(About bag)
        {
            aboutManager.TUpdate(bag);
            return RedirectToAction("AdminIndex");
        }
        public IActionResult ChangeToTrue(int id)
        {
            Context c = new Context();
            var values = c.Categories.Find(id);
            values.Status = true;
            c.Update(values);
            c.SaveChanges();

            return RedirectToAction("AdminIndex");
        }
       

        public IActionResult ChangeToFalse(int id)
        {
            Context c = new Context();
            var values = c.Categories.Find(id);
            values.Status = false;
            c.Update(values);
            c.SaveChanges();
            return RedirectToAction("AdminIndex");
        }
    }
}
