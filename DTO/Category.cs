using System.Data;

namespace DTO
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Category() { }

        public Category(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public Category(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
        }
    }
}