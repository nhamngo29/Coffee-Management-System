using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BookingBUS
    {
        private static BookingBUS instance;

        public static BookingBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BookingBUS();
                return BookingBUS.instance;
            }
        }

        private BookingBUS() { }
        public DataTable GetAllCategory()
        {
            try
            {
                return BookingDAO.Instance.GetAllCategory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetMaxID()
        {
            try
            {
                return BookingDAO.Instance.GetMaxID();
            }
            catch (Exception ex)
            {
                return 0;
                throw ex;

            }
        }
        public int GetCountUnCheck()
        {
            try
            {
                return (int)BookingDAO.Instance.GetCountUnCheck();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Booking GetByID(int id)
        {
            try
            {
                return BookingDAO.Instance.GetByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertCategory(Booking booking)
        {
            try
            {
                return BookingDAO.Instance.Insert(booking);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeteleCategory(int id)
        {
            try
            {
                return BookingDAO.Instance.DeteleCategory(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
