using Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class AccountTypeRepository : Repository<AccountType>, IAccountTypeRepository
    {
        private readonly CoffeeEntitie _db;
        public AccountTypeRepository(CoffeeEntitie db) : base(db)
        {
            _db.Bookings.ToList();
            _db = db;
        }
    }
}
