using System;
using System.Collections.Generic;

namespace WebDatBan.Models
{
    public partial class Discount
    {
        public string Id { get; set; } = null!;
        public int? NumPercent { get; set; }
        public int? Quantity { get; set; }
    }
}
