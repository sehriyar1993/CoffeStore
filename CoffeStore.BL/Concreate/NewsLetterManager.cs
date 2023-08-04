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
    public class NewsLetterManager:INewsLetterServices
    {
        INewsletterDal _dal;

        public NewsLetterManager(INewsletterDal dal)
        {
            _dal = dal;
        }

        public void TDelete(NewsLetter t)
        {
            _dal.Delete(t);
        }

        public List<NewsLetter> TGetAll()
        {
            return _dal.GetAll();
        }

        public NewsLetter TGetByID(int id)
        {
            return _dal.GetByID(id);
        }

        public void TInsert(NewsLetter t)
        {
            _dal.Insert(t);
        }

        public List<NewsLetter> TListForFilter(Expression<Func<NewsLetter, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(NewsLetter t)
        {
            _dal.Update(t);
        }
    }
}
