using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class OrderStatus
    {
        public Guid Id { get; set; }
        public Guid? OrderId { get; set; }
        public string Name { get; set; } = null!;
        public string Color { get; set; } = null!;
        public DateTime? Date { get; set; }

        public virtual Order? Order { get; set; }
    }
}
