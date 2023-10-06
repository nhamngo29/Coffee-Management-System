using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.IRepostory;

namespace Test.Repository.IRepository
{
    public interface IFoodRepository:IRepository<Food>
    {
        void Update(Food food);
    }
}
