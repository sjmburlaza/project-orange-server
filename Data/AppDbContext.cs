using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ProjectOrangeApi.Models;
using ProjectOrangeApi.Data.Seeds;

namespace ProjectOrangeApi.Data;

public class AppDbContext : IdentityDbContext<AppUser>
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
	public DbSet<ProductSpec> ProductSpecs => Set<ProductSpec>();
	public DbSet<AuthSession> AuthSessions => Set<AuthSession>();


	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<IdentityRole>().HasData(RoleSeed.Roles);

		modelBuilder.Entity<Product>()
			.Property(p => p.Price)
			.HasPrecision(18, 2);

		modelBuilder.Entity<CartItem>()
			.Property(c => c.Price)
			.HasPrecision(18, 2);

		modelBuilder.Entity<CartItemAddon>()
			.Property(a => a.Amount)
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

		modelBuilder.Entity<Cart>()
			.Property(c => c.ShippingPrice)
			.HasColumnType("decimal(18,2)");

		modelBuilder.Entity<AuthSession>()
			.HasOne(s => s.User)
			.WithMany(u => u.AuthSessions)
			.HasForeignKey(s => s.UserId)
			.OnDelete(DeleteBehavior.Cascade);

		modelBuilder.Entity<AuthSession>()
			.HasIndex(s => s.UserId);

		modelBuilder.Entity<AuthSession>()
			.HasIndex(s => s.ExpiresAtUtc);

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

		modelBuilder.Entity<Product>().HasData(ProductSeed.Products);
		modelBuilder.Entity<ProductSpec>().HasData(ProductSpecSeed.ProductSpecs);
	}
}
