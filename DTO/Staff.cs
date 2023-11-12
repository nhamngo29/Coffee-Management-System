using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Staff
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public DateTime BOB {  get; set; }

        public Staff(int id, string name, DateTime bOB)
        {
            Id = id;
            Name = name;
            BOB = bOB;
        }

        public Staff()
        {
        }
        public Staff(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["Name"].ToString();
            this.BOB = (DateTime)row["DOB"];


        }
    }
}
