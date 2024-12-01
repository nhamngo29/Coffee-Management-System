using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Discount
    {
        public string ID { get; set; }
        public int NumPercent { get; set; }
        public int Quantity { get; set; }
        public Discount() { }

        public Discount(string id, int numPercent,int quantity)
        {
            this.ID = id;
            NumPercent = numPercent;
            Quantity = quantity;
        }

        public Discount(DataRow row)
        {
            ID = row["ID"].ToString();
            NumPercent = (int)row["NumPercent"];
            Quantity = (int)row["Quantity"];
        }
    }
}
