using System;
using System.Collections.Generic;

namespace WebDatBan.Models
{
    public partial class TypeFood
    {
        public TypeFood()
        {
            Foods = new HashSet<Food>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? IdCategory { get; set; }

        public virtual CategoryFood? IdCategoryNavigation { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
