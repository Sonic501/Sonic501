using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Address
    {
        public Guid Id { get; set; }
        public Guid? AccountId { get; set; }
        public string Address1 { get; set; } = null!;
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
        public string Type { get; set; } = null!;

        public virtual Account? Account { get; set; }
    }
}
