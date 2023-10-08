using Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ICateogryRepository Category { get;private set; }
        public IFoodRepository Food { get;private set; }
        private readonly CoffeeEntitie _db = new CoffeeEntitie();
        public UnitOfWork()
        {
            Category = new CateogryRepository(_db);
            Food= new FoodRepository(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
