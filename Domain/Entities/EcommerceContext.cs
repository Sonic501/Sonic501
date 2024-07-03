using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Domain.Entities
{
    public partial class EcommerceContext : DbContext
    {
        public EcommerceContext()
        {
        }

        public EcommerceContext(DbContextOptions<EcommerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderProduct> OrderProducts { get; set; } = null!;
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductImage> ProductImages { get; set; } = null!;
        public virtual DbSet<Rating> Ratings { get; set; } = null!;
        public virtual DbSet<ShippingDetail> ShippingDetails { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:sonic123.database.windows.net,1433;Initial Catalog=Ecommerce;Persist Security Info=False;User ID=Sonic221;Password=Sa123456@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.HasIndex(e => e.Email, "UQ__Account__AB6E61642674D11C")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(255)
                    .HasColumnName("avatar");

                entity.Property(e => e.Company)
                    .HasMaxLength(255)
                    .HasColumnName("company");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("firstName");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(255)
                    .HasColumnName("jobTitle");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("lastName");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .HasColumnName("role");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.Lat)
                    .HasColumnType("decimal(10, 8)")
                    .HasColumnName("lat");

                entity.Property(e => e.Lng)
                    .HasColumnType("decimal(11, 8)")
                    .HasColumnName("lng");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Address__account__787EE5A0");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.HasIndex(e => e.Name, "UQ__Category__72E12F1B9EA0A759")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Comment__account__0D7A0286");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Comment__product__0C85DE4D");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.HasIndex(e => e.Reference, "UQ__Order__FD90DA993A4CBD7E")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Reference)
                    .HasMaxLength(255)
                    .HasColumnName("reference");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("subtotal");

                entity.Property(e => e.Tax)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("tax");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Order__accountId__7C4F7684");
            });

            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("PK__OrderPro__BAD83E4BD44744CE");

                entity.ToTable("OrderProduct");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderProd__order__7F2BE32F");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__OrderProd__produ__00200768");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderStatuses)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__OrderStat__order__02FC7413");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__Payment__9B57CF724F70B88E");

                entity.ToTable("Payment");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("transactionId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Method)
                    .HasMaxLength(50)
                    .HasColumnName("method");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Payment__orderId__05D8E0BE");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasIndex(e => e.Sku, "UQ__Product__DDDF4BE725473DA9")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ComparedPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("comparedPrice");

                entity.Property(e => e.Depth)
                    .HasMaxLength(50)
                    .HasColumnName("depth");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.ExtraShippingFee)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("extraShippingFee");

                entity.Property(e => e.FeaturedImageId).HasColumnName("featuredImageId");

                entity.Property(e => e.Handle)
                    .HasMaxLength(255)
                    .HasColumnName("handle");

                entity.Property(e => e.Height)
                    .HasMaxLength(50)
                    .HasColumnName("height");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.PriceTaxExcl)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("priceTaxExcl");

                entity.Property(e => e.PriceTaxIncl)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("priceTaxIncl");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Sku)
                    .HasMaxLength(100)
                    .HasColumnName("sku");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("taxRate");

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .HasColumnName("weight");

                entity.Property(e => e.Width)
                    .HasMaxLength(50)
                    .HasColumnName("width");

                entity.HasOne(d => d.FeaturedImage)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.FeaturedImageId)
                    .HasConstraintName("FK__Product__feature__17036CC0");

                entity.HasMany(d => d.Categories)
                    .WithMany(p => p.Products)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProductCategory",
                        l => l.HasOne<Category>().WithMany().HasForeignKey("CategoryId").HasConstraintName("FK__ProductCa__categ__6C190EBB"),
                        r => r.HasOne<Product>().WithMany().HasForeignKey("ProductId").HasConstraintName("FK__ProductCa__produ__6B24EA82"),
                        j =>
                        {
                            j.HasKey("ProductId", "CategoryId").HasName("PK__ProductC__BF2C7E77321DD02C");

                            j.ToTable("ProductCategory");

                            j.IndexerProperty<Guid>("ProductId").HasColumnName("productId");

                            j.IndexerProperty<Guid>("CategoryId").HasColumnName("categoryId");
                        });

                entity.HasMany(d => d.Tags)
                    .WithMany(p => p.Products)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProductTag",
                        l => l.HasOne<Tag>().WithMany().HasForeignKey("TagId").HasConstraintName("FK__ProductTa__tagId__72C60C4A"),
                        r => r.HasOne<Product>().WithMany().HasForeignKey("ProductId").HasConstraintName("FK__ProductTa__produ__71D1E811"),
                        j =>
                        {
                            j.HasKey("ProductId", "TagId").HasName("PK__ProductT__481F117F8BC7B752");

                            j.ToTable("ProductTag");

                            j.IndexerProperty<Guid>("ProductId").HasColumnName("productId");

                            j.IndexerProperty<Guid>("TagId").HasColumnName("tagId");
                        });
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.ToTable("ProductImage");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ProductIm__produ__656C112C");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("Rating");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Rating1).HasColumnName("rating");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Rating__accountI__1332DBDC");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Rating__productI__123EB7A3");
            });

            modelBuilder.Entity<ShippingDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Carrier)
                    .HasMaxLength(255)
                    .HasColumnName("carrier");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("fee");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.Tracking)
                    .HasMaxLength(255)
                    .HasColumnName("tracking");

                entity.Property(e => e.Weight)
                    .HasMaxLength(50)
                    .HasColumnName("weight");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ShippingDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__ShippingD__order__08B54D69");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tag");

                entity.HasIndex(e => e.Name, "UQ__Tag__72E12F1BC88E3754")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
