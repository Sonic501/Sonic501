using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Tag
    {
        public Tag()
        {
            Products = new HashSet<Product>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; }
    }
}
