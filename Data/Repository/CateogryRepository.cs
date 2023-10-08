using Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CateogryRepository : Repository<CategoryFood>, ICateogryRepository
    {
        private readonly CoffeeEntitie _db=new CoffeeEntitie();
        public CateogryRepository(CoffeeEntitie db) : base(db)
        {
            _db.Bookings.ToList();
            _db = db;
        }

        public void update(CategoryFood categoryFood)
        {
            CategoryFood a=_db.CategoryFoods.FirstOrDefault(t=>t.ID==categoryFood.ID);
            a.Name= categoryFood.Name;
        }
        public List<CategoryFood> SearchCategoryByName(string name)
        {
            return _db.CategoryFoods.Where(t=>t.Name.Equals(name)).ToList();
        }
    }
}
