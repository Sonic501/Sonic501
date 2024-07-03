using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Account
    {
        public Account()
        {
            Addresses = new HashSet<Address>();
            Comments = new HashSet<Comment>();
            Orders = new HashSet<Order>();
            Ratings = new HashSet<Rating>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Avatar { get; set; }
        public string? Company { get; set; }
        public string? JobTitle { get; set; }
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string Role { get; set; } = null!;

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
