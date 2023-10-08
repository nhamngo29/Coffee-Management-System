using Data.Repository;
using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BookingData
    {
        CoffeeEntitie e;
        BookingRepository booking;
        public BookingData() { 
            e=new CoffeeEntitie();
            e.Bookings.ToList();
            booking = new BookingRepository(e);
            
        }
        public DataTable getall()
        {
            return booking.GetAll();
        }
    }
}
