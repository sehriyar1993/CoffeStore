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
    public class ContactManager:IContactServices
    {
        IContactDal _dal;

        public ContactManager(IContactDal dal)
        {
            _dal = dal;
        }

        public void TDelete(Contact t)
        {
            _dal.Delete(t);
        }

        public List<Contact> TGetAll()
        {
            return _dal.GetAll();   
        }

        public Contact TGetByID(int id)
        {
            return _dal.GetByID(id);
        }

        public void TInsert(Contact t)
        {
            _dal.Insert(t);
        }

        public List<Contact> TListForFilter(Expression<Func<Contact, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            _dal.Update(t);
        }
    }
}
