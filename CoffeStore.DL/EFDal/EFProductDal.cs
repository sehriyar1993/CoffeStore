using CoffeStore.DL.Abstract;
using CoffeStore.EL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeStore.DL.EFDal
{
    public class EFProductDal:GenericRepository<Product>, IProductDal
    {
        public Product GetProductWithID(int id)
        {
            using (var c = new Context())
            {
                return c.Products.Where(x => x.ProductId == id).Include(x => x.Category).FirstOrDefault();
            }
        }
    }
}
