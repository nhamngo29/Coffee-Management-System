using System;
using System.Collections.Generic;

namespace WebDatBan.Models
{
    public partial class staff
    {
        public staff()
        {
            Accounts = new HashSet<Account>();
            Bills = new HashSet<Bill>();
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? Dob { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
