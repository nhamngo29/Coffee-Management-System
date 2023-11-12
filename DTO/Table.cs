using System.Data;

namespace DTO
{
    public class Table
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public Table(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Status = row["Status"].ToString();
        }
    }
}