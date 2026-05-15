using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();

    public DbSet<Cart> Carts => Set<Cart>();
    public DbSet<CartItem> CartItems => Set<CartItem>();
    public DbSet<CartItemAddon> CartItemAddons => Set<CartItemAddon>();
    public DbSet<CartVoucher> CartVouchers => Set<CartVoucher>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
        .Property(p => p.Price)
        .HasPrecision(18, 2);

        modelBuilder.Entity<CartItem>()
          .Property(c => c.Price)
          .HasPrecision(18, 2);

        modelBuilder.Entity<Order>()
          .Property(o => o.TotalAmount)
          .HasPrecision(18, 2);

        modelBuilder.Entity<OrderItem>()
          .Property(o => o.Price)
          .HasPrecision(18, 2);

        modelBuilder.Entity<Cart>()
          .HasMany(c => c.Entries)
          .WithOne(i => i.Cart)
          .HasForeignKey(i => i.CartId)
          .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Cart>()
          .HasMany(c => c.AppliedVouchers)
          .WithOne(v => v.Cart)
          .HasForeignKey(v => v.CartId)
          .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CartItem>()
          .HasMany(i => i.Addons)
          .WithOne(a => a.CartItem)
          .HasForeignKey(a => a.CartItemId)
          .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Category>().HasData(
          new Category { Id = 1, Name = "Phones" },
          new Category { Id = 2, Name = "Laptops" },
          new Category { Id = 3, Name = "Accessories" }
        );

        modelBuilder.Entity<Product>().HasData(
          new Product
          {
              Id = 1,
              Name = "iPhone 15",
              Description = "Apple smartphone",
              Price = 59999,
              StockQuantity = 10,
              ImageUrl = "",
              CategoryId = 1
          },
          new Product
          {
              Id = 2,
              Name = "Mechanical Keyboard",
              Description = "RGB keyboard",
              Price = 3500,
              StockQuantity = 25,
              ImageUrl = "",
              CategoryId = 3
          }
        );
    }
}
