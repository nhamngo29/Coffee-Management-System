using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TypeID { get; set; }
        public int Price { get; set; }
        public string Describe { get; set; }
        public byte[] ImageFood { get; set; }=null;
        public Food(string name, int typeID, int price, string describe, byte[] imageFood)
        {
            Name = name;
            TypeID = typeID;
            Price = price;
            Describe = describe;
            ImageFood = imageFood;
        }

        public Food(int id, string name, int typeID, int price, string describe, byte[] imageFood)
        {
            ID = id;
            Name = name;
            TypeID = typeID;
            Price = price;
            Describe = describe;
            ImageFood = imageFood;
        }

        public Food(DataRow row)
        {
            ID = (int)row["ID"];
            Name = row["Name"].ToString();
            TypeID = (int)row["Type"];
            Price = (int)row["Price"];
            Describe = (string)row["Describe"].ToString();
            ImageFood = (byte[])row["ImageFood"];
        }
    }
}
