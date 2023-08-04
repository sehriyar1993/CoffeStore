using CoffeStore.BL.Concreate;
using CoffeStore.DL;
using CoffeStore.DL.EFDal;
using Microsoft.AspNetCore.Mvc;

namespace CoffeStore.ViewComponents
{
    public class CategoryList : ViewComponent
    {

        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
        public IViewComponentResult Invoke()
        {
            var values = categoryManager.TGetAll();
            return View(values);

        }
    }
}
