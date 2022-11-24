using DuzceUni.DataAccess.Abstract;
using DuzceUni.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DuzceUni.DataAccess.EntityFramework
{
    public class EFAccountRepository : IAccountDAL
    {
        public void Delete(Announcement t)
        {
            throw new NotImplementedException();
        }

        public Announcement GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Announcement> GetListAll()
        {
            throw new NotImplementedException();
        }

        public List<Announcement> GetListAll(Expression<Func<Announcement, bool>> filter = null, Func<IQueryable<Announcement>, IOrderedQueryable<Announcement>> orderBy = null, params Expression<Func<Announcement, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public List<Announcement> GetListAll(Expression<Func<Announcement, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void Update(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
