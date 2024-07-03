using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
            OrderStatuses = new HashSet<OrderStatus>();
            Payments = new HashSet<Payment>();
            ShippingDetails = new HashSet<ShippingDetail>();
        }

        public Guid Id { get; set; }
        public string Reference { get; set; } = null!;
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal? Discount { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public Guid? AccountId { get; set; }

        public virtual Account? Account { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<OrderStatus> OrderStatuses { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<ShippingDetail> ShippingDetails { get; set; }
    }
}
