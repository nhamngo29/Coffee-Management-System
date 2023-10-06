using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BookingDAO
    {
        private static BookingDAO instance;
        public static BookingDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BookingDAO();
                return BookingDAO.instance;
            }
        }

        private BookingDAO() { }

        public DataTable GetAllCategory()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("select * from Booking");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
