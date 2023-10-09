using System;

using System.Data;
using System.Collections.Generic;

using DTO;
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
        public int GetMaxID()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM Booking");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetCountUnCheck()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT Count(ID) FROM Booking where status is null");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Booking GetByID(int id)
        {
            Booking b = new Booking();
            string query = "select * from Booking where ID = " + id;
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow row in table.Rows)
            {
                b = new Booking(row);
                return b;
            }
            return b;
        }

        public bool Insert(Booking booking)
        {
            string query = string.Format("insert into Booking values (N'{0}',{1},{2},{3},{4},N'{5},{6})", booking.FullName, booking.Email, booking.NumberPhone, booking.Quantity, booking.BookingTime, booking.Note, booking.status);
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        //public bool Update(Booking booking)
        //{

        //    string query = string.Format("update CategoryFood set Name = N'{0}' where ID = {1}", name, id);
        //    int result;
        //    try
        //    {
        //        result = DataProvider.Instance.ExecuteNonQuery(query);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return result > 0;
        //}

        public bool DeteleCategory(int id)
        {
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery("SP_DeleteBooking @ID", new object[] { id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        //public List<Category> SearchCategoryByName(string name)
        //{
        //    List<Category> listCategory = new List<Category>();
        //    string query = string.Format("select * from CategoryFood where dbo.fuConvertToUnsign1(Name) like N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

        //    DataTable table = new DataTable();
        //    try
        //    {
        //        table = DataProvider.Instance.ExecuteQuery(query);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    foreach (DataRow row in table.Rows)
        //    {
        //        Category category = new Category(row);
        //        listCategory.Add(category);
        //    }
        //    return listCategory;
        //}
    }
}

