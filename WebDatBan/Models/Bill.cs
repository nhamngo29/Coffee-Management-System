using System;
using System.Collections.Generic;

namespace WebDatBan.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillInfos = new HashSet<BillInfo>();
        }

        public int Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public int TableId { get; set; }
        public int Discount { get; set; }
        public int? TotalPrice { get; set; }
        public int Status { get; set; }
        public int? IdSataff { get; set; }

        public virtual staff? IdSataffNavigation { get; set; }
        public virtual TableCoffee Table { get; set; } = null!;
        public virtual ICollection<BillInfo> BillInfos { get; set; }
    }
}
