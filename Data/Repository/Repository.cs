using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CoffeeEntitie _db;
        public DbSet<T> Dbset;

        public Repository(CoffeeEntitie db)
        {
            _db = db;
            Dbset=_db.Set<T>();
        }

        public void Delete(T entity)
        {
            Dbset.Remove(entity);
        }


        public DataTable GetAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var reader = ObjectReader.Create(Dbset.ToList()))
                {
                    dataTable.Load(reader);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetFilter(Expression<Func<T, bool>> filter)
        {
            return Dbset.Where(filter).ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            return Dbset.Where(filter).FirstOrDefault();
        }

        public bool Insert(T entity)
        {
            try
            {
                Dbset.Add(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
