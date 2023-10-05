using System;
using System.Collections.Generic;

namespace WebDatBan.Models
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public int? Quantity { get; set; }
        public DateTime? Time { get; set; }
        public string? Status { get; set; }
        public int? IdTable { get; set; }
        public int? IdSataff { get; set; }

        public virtual staff? IdSataffNavigation { get; set; }
        public virtual TableCoffee? IdTableNavigation { get; set; }
    }
}
