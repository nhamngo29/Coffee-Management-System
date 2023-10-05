using System;
using System.Collections.Generic;

namespace WebDatBan.Models
{
    public partial class Food
    {
        public Food()
        {
            BillInfos = new HashSet<BillInfo>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Type { get; set; }
        public int Price { get; set; }
        public string? Image { get; set; }
        public string? Describe { get; set; }

        public virtual TypeFood TypeNavigation { get; set; } = null!;
        public virtual ICollection<BillInfo> BillInfos { get; set; }
    }
}
