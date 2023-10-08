using Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class TableRepository : Repository<TableCoffee>, ITableRepository
    {
        private readonly CoffeeEntitie _db;
        public TableRepository(CoffeeEntitie db) : base(db)
        {
            _db.Bookings.ToList();
            _db = db;
        }
    }
}
