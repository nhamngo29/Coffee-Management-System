using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.IRepostory;
using Test.Repository;

namespace Test
{
    public class FoodBus
    {
        CoffeeEntities a = new CoffeeEntities();
        public void test()
        {
            var d = a.Foods.ToList();
        }
    }
}
