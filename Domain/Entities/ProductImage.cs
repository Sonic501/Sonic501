using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ProductImage
    {
        public ProductImage()
        {
            Products = new HashSet<Product>();
        }

        public Guid Id { get; set; }
        public string Url { get; set; } = null!;
        public string Type { get; set; } = null!;
        public Guid? ProductId { get; set; }

        public virtual Product? Product { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
