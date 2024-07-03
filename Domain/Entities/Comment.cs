using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Comment
    {
        public Guid Id { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? AccountId { get; set; }
        public string Content { get; set; } = null!;
        public DateTime Date { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Product? Product { get; set; }
    }
}
