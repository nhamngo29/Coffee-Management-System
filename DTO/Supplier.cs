using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Supplier
    {
        public int ID { get; set; }
        public string IdSupplier { get; set; }
        public string Name { get; set; }

        public Supplier(int iD, string idSupplier, string name)
        {
            ID = iD;
            IdSupplier = idSupplier;
            Name = name;
        }
        public Supplier(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.IdSupplier = row["IdSupplier"].ToString();
        }

        public override string ToString()
        {
            return IdSupplier+"-"+Name;
        }
    }
}
