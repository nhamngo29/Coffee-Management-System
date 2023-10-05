using System;
using System.Collections.Generic;

namespace WebDatBan.Models
{
    public partial class TableCoffee
    {
        public TableCoffee()
        {
            Bills = new HashSet<Bill>();
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Status { get; set; } = null!;

        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
