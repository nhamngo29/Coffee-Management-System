using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ViewModel
{
    public class ViewModelBillInfo
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public int Amnout {  get; set; }
        public double Price {  get; set; }
        public double Total {  get; set; }

        public ViewModelBillInfo(int iD, string name, int amnout, double price, double total)
        {
            ID = iD;
            Name = name;
            Amnout = amnout;
            Price = price;
            Total = total;
        }
        public ViewModelBillInfo(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Amnout = (int)row["Amount"];
            this.Price = (int)row["Price"];
            this.Total = (int)row["TongTien"];
            
        }
    }
}
