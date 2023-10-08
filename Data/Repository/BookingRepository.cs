using Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BookingRepository : Repository<Booking>, IBookingRepository
    {
        private readonly CoffeeEntitie _db;
        public BookingRepository(CoffeeEntitie db) : base(db)
        {
            _db.Bookings.ToList();
            _db = db;
        }

        public void Update(Booking booking)
        {
            
        }
    }
}
