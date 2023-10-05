using System;
using System.Collections.Generic;

namespace WebDatBan.Models
{
    public partial class Booking
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? NumberPhone { get; set; }
        public int? Quantity { get; set; }
        public DateTime? BookingTime { get; set; }
        public string? Note { get; set; }
    }
}
