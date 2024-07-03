using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ShippingDetail
    {
        public Guid Id { get; set; }
        public Guid? OrderId { get; set; }
        public string? Tracking { get; set; }
        public string? Carrier { get; set; }
        public string? Weight { get; set; }
        public decimal? Fee { get; set; }
        public DateTime? Date { get; set; }

        public virtual Order? Order { get; set; }
    }
}
