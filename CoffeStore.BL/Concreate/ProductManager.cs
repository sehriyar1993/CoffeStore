using CoffeStore.BL.Abstract;
using CoffeStore.DL.Abstract;
using CoffeStore.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoffeStore.BL.Concreate
{
    public class ProductManager:IProductServices
    {
        IProductDal _pro;

        public ProductManager(IProductDal pro)
        {
            _pro = pro;
        }

        public void TDelete(Product t)
        {
            _pro.Delete(t);
        }

        public List<Product> TGetAll()
        {
            return _pro.GetAll();
        }

        public Product TGetByID(int id)
        {
            return _pro.GetByID(id);
        }

        public Product TGetProductWithID(int id)
        {
            return _pro.GetProductWithID(id);
        }

        public void TInsert(Product t)
        {
            _pro.Insert(t);
        }

        public List<Product> TListForFilter(Expression<Func<Product, bool>> filter)
        {
            return _pro.ListForFilter(filter);
        }

        public void TUpdate(Product t)
        {
            _pro.Update(t);
        }
    }
}
