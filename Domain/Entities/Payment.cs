using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Payment
    {
        public Guid TransactionId { get; set; }
        public Guid? OrderId { get; set; }
        public decimal Amount { get; set; }
        public string Method { get; set; } = null!;
        public DateTime Date { get; set; }

        public virtual Order? Order { get; set; }
    }
}
