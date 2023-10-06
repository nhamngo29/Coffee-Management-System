using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Test.IRepostory;

namespace Test.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CoffeeEntities _db;
        public DbSet<T> Dbset;
        public Repository(CoffeeEntities db)
        {
            _db = db;
            Dbset = _db.Set<T>();
        }
        public void Add(T entity)
        {
            Dbset.Add(entity);
        }

        public void Delete(T entity)
        {
            Dbset.Remove(entity);
        }


        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = Dbset;
            return query.ToList();
        }

        public IEnumerable<T> GetFilter(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = Dbset;
            query = query.Where(filter);
            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = Dbset;

            query = query.Where(filter);
            return query.FirstOrDefault();
        }

       
    }
}
