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
    public class CategoryManager : ICategoryServices
    {
        ICategoryDal _cat;

        public CategoryManager(ICategoryDal cat)
        {
            _cat = cat;
        }

        public void TDelete(Category t)
        {
            _cat.Delete(t);
        }

        public List<Category> TGetAll()
        {
            return _cat.GetAll();
        }

        public Category TGetByID(int id)
        {
           return _cat.GetByID(id);
        }

        public void TInsert(Category t)
        {
            _cat.Insert(t);
        }

        public List<Category> TListForFilter(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Category t)
        {
            _cat.Update(t);
        }
    }
}
