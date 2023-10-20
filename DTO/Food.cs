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
        public string Image { get; set; }
        public string Describe { get; set; }
        public Food(string name, int typeID, int price, string image, string describe)
        {
            Name = name;
            TypeID = typeID;
            Price = price;
            Image = image;
            Describe = describe;
        }

        public Food(int id, string name, int typeID, int price, string image, string describe)
        {
            ID = id;
            Name = name;
            TypeID = TypeID;
            Price = price;
            Image = image;
            Describe = describe;
        }

        public Food(DataRow row)
        {
            ID = (int)row["ID"];
            Name = row["Name"].ToString();
            TypeID = (int)row["Type"];
            Price = (int)row["Price"];
            Image = (string)row["Image"].ToString();
            Describe = (string)row["Describe"].ToString();

        }
    }
}
