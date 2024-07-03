using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Product
    {
        public Product()
        {
            Comments = new HashSet<Comment>();
            OrderProducts = new HashSet<OrderProduct>();
            ProductImages = new HashSet<ProductImage>();
            Ratings = new HashSet<Rating>();
            Categories = new HashSet<Category>();
            Tags = new HashSet<Tag>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Handle { get; set; } = null!;
        public string? Description { get; set; }
        public Guid? FeaturedImageId { get; set; }
        public decimal PriceTaxExcl { get; set; }
        public decimal PriceTaxIncl { get; set; }
        public decimal TaxRate { get; set; }
        public decimal? ComparedPrice { get; set; }
        public int Quantity { get; set; }
        public string Sku { get; set; } = null!;
        public string? Width { get; set; }
        public string? Height { get; set; }
        public string? Depth { get; set; }
        public string? Weight { get; set; }
        public decimal? ExtraShippingFee { get; set; }
        public bool? Active { get; set; }

        public virtual ProductImage? FeaturedImage { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
