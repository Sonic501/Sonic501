using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Rating
    {
        public Guid Id { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? AccountId { get; set; }
        public int Rating1 { get; set; }
        public DateTime Date { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Product? Product { get; set; }
    }
}
