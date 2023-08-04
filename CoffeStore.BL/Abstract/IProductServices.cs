using CoffeStore.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeStore.BL.Abstract
{
    public interface IProductServices:IGenericServices<Product>
    {
        public Product TGetProductWithID(int id);
    }
}
