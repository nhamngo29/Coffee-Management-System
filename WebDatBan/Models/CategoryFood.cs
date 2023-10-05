using System;
using System.Collections.Generic;

namespace WebDatBan.Models
{
    public partial class CategoryFood
    {
        public CategoryFood()
        {
            TypeFoods = new HashSet<TypeFood>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<TypeFood> TypeFoods { get; set; }
    }
}
