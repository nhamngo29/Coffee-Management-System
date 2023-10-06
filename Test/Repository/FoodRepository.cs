using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Test.IRepostory;
using Test.Repository.IRepository;

namespace Test.Repository
{
    internal class FoodRepository : Repository<Food>,IFoodRepository
    {
        private readonly CoffeeEntities _db;
        public FoodRepository(CoffeeEntities db) : base(db)
        {
            _db = db;
            //_db.products.Include(u => u.Brand);

        }
        public void Update(Food food)
        {
            _db.Foods.Remove(food);
            _db.Foods.Add(food);
        }
    }
}
