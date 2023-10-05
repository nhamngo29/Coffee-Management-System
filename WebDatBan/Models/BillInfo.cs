using System;
using System.Collections.Generic;

namespace WebDatBan.Models
{
    public partial class BillInfo
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int FoodId { get; set; }
        public int Amount { get; set; }

        public virtual Bill Bill { get; set; } = null!;
        public virtual Food Food { get; set; } = null!;
    }
}
