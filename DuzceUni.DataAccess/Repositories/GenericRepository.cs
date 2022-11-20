using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DuzceUni.DataAccess.Abstract;
using DuzceUni.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {

        public void Insert(T t)
        {
            using (var context = new Context())
            {
                context.Add(t);
                context.SaveChanges();
            }
        }

        public void Update(T t)
        {
            using (var context = new Context())
            {
                context.Update(t);
                context.SaveChanges();
            }
        }
        public void Delete(T t)
        {
            using (var context = new Context())
            {
                context.Remove(t);
                context.SaveChanges();
            }
        }

        public T GetById(int id)
        {
            using (var context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public List<T> GetListAll()
        {
            using (var context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using (var context = new Context())
            {
                return context.Set<T>().Where(filter).ToList();
            }

        }
        public List<T> GetListAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes)
        {
            using (var context = new Context())
            {
                IQueryable<T> query = context.Set<T>();
                if (filter != null)
                {
                    query = query.Where(filter);
                }
                if (orderBy != null)
                {
                    return orderBy(query).ToList();
                }
                if (includes != null)
                {
                    foreach (Expression<Func<T, object>> include in includes)
                    {
                        query = query.Include(include);
                    }
                }
                return query.ToList();
            }

        }
    }
}