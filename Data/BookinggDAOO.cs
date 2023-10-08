using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BookinggDAOO
    {
        //private static BookinggDAO instance;
        //DataClasses1DataContext db;
        //public static BookinggDAO Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new BookinggDAO();
        //        return BookinggDAO.instance;
        //    }
        //}

        //private BookinggDAO()
        //{
        //    db = new DataClasses1DataContext();
        //}

        //public DataTable GetAll()
        //{
        //    try
        //    {
        //        DataTable dataTable = new DataTable();
        //        using (var reader = ObjectReader.Create(db.Bookings.ToList()))
        //        {
        //            dataTable.Load(reader);
        //        }
        //        return dataTable;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public bool InsertCategory(BookinggDAO booking)
        //{
        //    string query = string.Format("insert into Booking values (N'{0}',{1},{2},{3},{4},N'{5},{6})", booking.FullName, booking.Email, booking.NumberPhone, booking.Quantity, booking.BookingTime, booking.Note, booking.status);
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
        ////public Booking GetByID(int id)
        ////{
        ////    Booking booking = new Booking();
        ////    string query = "select * from Booking where ID = " + id;
        ////    DataTable table = new DataTable();
        ////    try
        ////    {
        ////        table = DataProvider.Instance.ExecuteQuery(query);
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        throw ex;
        ////    }

        ////    foreach (DataRow row in table.Rows)
        ////    {
        ////        booking = new Booking(row);
        ////        return booking;
        ////    }
        ////    return booking;
        ////}
        //public BookinggDAO GetByID(int id)
        //{
        //    return db.Bookings.FirstOrDefault(t => t.ID == id);
        //}
        //public bool Update(BookinggDAO a)
        //{
        //    BookinggDAO b = GetByID(a.ID);
        //    if (b != null)
        //    {
        //        b.FullName = a.FullName;
        //        b.Email = a.Email;
        //        b.NumberPhone = a.NumberPhone;
        //        b.Quantity = a.Quantity;
        //        b.BookingTime = a.BookingTime;
        //        b.Note = a.Note;
        //        b.status = a.status;
        //        return true;
        //    }
        //    return false;

        //}
    }
}
