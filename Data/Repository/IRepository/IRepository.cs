using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepository<T> where T : class
    {
        DataTable GetAll();
        void Delete(T entity);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetFilter(Expression<Func<T, bool>> filter);
        bool Insert(T entity);
    }
}
