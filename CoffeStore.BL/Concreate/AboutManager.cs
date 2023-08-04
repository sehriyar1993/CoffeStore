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
    public class AboutManager:IAboutServices
    {
        IAboutDal _dal;

        public AboutManager(IAboutDal dal)
        {
            _dal = dal;
        }

        public void TDelete(About t)
        {
            _dal.Delete(t);
        }

        public List<About> TGetAll()
        {
            return _dal.GetAll();
        }

        public About TGetByID(int id)
        {
            return _dal.GetByID(id);
        }

        public void TInsert(About t)
        {
            _dal.Insert(t);
        }

        public List<About> TListForFilter(Expression<Func<About, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            _dal.Update(t);
        }
    }
}
