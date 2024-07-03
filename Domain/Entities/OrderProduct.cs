using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class OrderProduct
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
