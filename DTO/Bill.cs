using System;
using System.Data;

namespace DTO
{
    public class Bill
    {
        public int ID { get; set; }
        public DateTime CheckIn { get; set; }
        public int Status { get; set; }
        public int Discount { get; set; }

        public Bill(int id, DateTime checkIn, int status, int discount = 0)
        {
            this.ID = id;
            this.CheckIn = checkIn;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.CheckIn = (DateTime)row["checkIn"];

            this.Status = (int)row["status"];

            if (row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];
        }
    }
}