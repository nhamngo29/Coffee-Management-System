using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Repository.IRepository;

namespace Test.IRepostory
{ 
    public interface IUnitOfWork
    {
       IFoodRepository Food { get; }
        void Save();
    }
}
