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
    public class HomeManager:IHomeServices
    {
        IHomeDal _home;

        public HomeManager(IHomeDal home)
        {
            _home = home;
        }

        public void TDelete(HomeClass t)
        {
            _home.Delete(t);
        }

        public List<HomeClass> TGetAll()
        {
            return _home.GetAll();
        }

        public HomeClass TGetByID(int id)
        {
            return _home.GetByID(id);
        }

        public void TInsert(HomeClass t)
        {
           _home.Insert(t);
        }

        public List<HomeClass> TListForFilter(Expression<Func<HomeClass, bool>> filter)
        {
            return _home.ListForFilter(filter);
        }

        public void TUpdate(HomeClass t)
        {
            _home.Update(t);
        }
    }
}
