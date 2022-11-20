using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DuzceUni.DataAccess.Abstract
{
    //Aynı işlemleri yapan diğer interfacelerde implement edilmek üzere genel,generic bir interface oluşturduk
    //Örneğin; IAnnoncumentDAL 
    public interface IGenericDAL<T> where T : class
    {
        void Insert(T t);        
        void Delete(T t);        
        void Update(T t);        
        T GetById(int id);
        List<T> GetListAll();
        
        List<T> GetListAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes);
        List<T> GetListAll(Expression<Func<T,bool>> filter);
        
    }
}