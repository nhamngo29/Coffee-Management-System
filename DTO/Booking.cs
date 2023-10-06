using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Booking
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string NumberPhone { get; set; }
        public int? Quantity { get; set; }
        public DateTime? BookingTime { get; set; }
        public string Note { get; set; }

        public Booking(int id, string fullName, string email, string numberPhone, int? quantity, DateTime? bookingTime, string note)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            NumberPhone = numberPhone;
            Quantity = quantity;
            BookingTime = bookingTime;
            Note = note;
        }
        public Booking(DataRow row)
        {
            Id = (int)row["id"];
            FullName = row["FullName"].ToString();
            Email = row["Email"].ToString();
            NumberPhone = row["FullName"].ToString();
            Quantity= (int)row["Quantity"];
            BookingTime = (DateTime)row["BookingTime"];
            Note= row["Note"].ToString();
        }
    }
}
