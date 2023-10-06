using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Test.IRepostory
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetFilter(Expression<Func<T, bool>> filter);
    }
}
