using DAO;
using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BusBooking
    {
        BookingData a;
        private static BusBooking instance;

        public static BusBooking Instance
        {
            get
            {
                if (instance == null)
                    instance = new BusBooking();
                return BusBooking.instance;
            }
        }
        private BusBooking() {
            a = new BookingData();
        }

        public DataTable GetAllCategory()
        {
            return a.getall();
        }
    }
}
