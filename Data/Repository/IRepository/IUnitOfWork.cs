using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICateogryRepository Category { get; }
        IFoodRepository Food { get; }
        void Save();
    }
}
