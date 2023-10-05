using System;
using System.Collections.Generic;

namespace WebDatBan.Models
{
    public partial class Account
    {
        public string UserName { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int TypeId { get; set; }
        public int? IdSataff { get; set; }

        public virtual staff? IdSataffNavigation { get; set; }
        public virtual AccountType Type { get; set; } = null!;
    }
}
