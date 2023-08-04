using CoffeStore.BL.Concreate;
using CoffeStore.DL;
using CoffeStore.DL.EFDal;
using CoffeStore.EL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing;
using X.PagedList;

namespace CoffeStore.Controllers
{
    public class AdminPruductController : Controller
    {
        ProductManager productManager = new ProductManager(new EFProductDal());
        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
       

        public async Task<IActionResult> Search(string searchString, int page = 1)
        {

            if (searchString != null)
                searchString = searchString.ToLower();
            ViewData["CurrentFilter"] = searchString;
            var values = from x in productManager.TGetAll().OrderByDescending(x => x.ProductId) select x;
            if (!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(y => y.Name.ToLower().Contains(searchString));
            }
            return View(values.ToPagedList(page, 12));

        }

        public IActionResult Index(int page = 1)
        {
            var values = productManager.TGetAll();
            return View(values.ToPagedList(page, 12));
        }
        public IActionResult GetProductsByCategoryId(int id, int page = 1)
        {
            var values = productManager.TListForFilter(x => x.CategoryId == id);
            return View(values.ToPagedList(page, 12));
        }
        [HttpGet]
        public IActionResult AddProduct()
        {

            List<SelectListItem> values1 = (from x in categoryManager.TGetAll()
                                            select new SelectListItem
                                            {
                                                Text = x.Name,
                                                Value = x.CategoryId.ToString()
                                            }).ToList();
            ViewBag.v = values1;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            p.Status = true;
            productManager.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            var values = productManager.TGetByID(id);
            productManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]

        public IActionResult UpdateProduct(int id)
        {
            List<SelectListItem> values1 = (from x in categoryManager.TGetAll()
                                            select new SelectListItem
                                            {
                                                Text = x.Name,
                                                Value = x.CategoryId.ToString()
                                            }).ToList();
            ViewBag.v1 = values1;
            var values = productManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]

        public IActionResult UpdateProduct(Product p)
        {
            productManager.TUpdate(p);
            return RedirectToAction("Index");
        }
      
        public IActionResult ProductSıngle(int id)
        {

            var values = productManager.TGetProductWithID(id);
            return View(values);
        }
    }
}
