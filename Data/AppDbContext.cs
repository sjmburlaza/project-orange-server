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
	public DbSet<Site> Sites => Set<Site>();
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
		modelBuilder.Entity<Site>().HasData(SiteSeed.Sites);

		modelBuilder.Entity<Site>()
			.Property(s => s.Code)
			.HasMaxLength(8);

		modelBuilder.Entity<Site>()
			.Property(s => s.CountryName)
			.HasMaxLength(128);

		modelBuilder.Entity<Site>()
			.Property(s => s.Locale)
			.HasMaxLength(16);

		modelBuilder.Entity<Site>()
			.Property(s => s.Currency)
			.HasMaxLength(8);

		modelBuilder.Entity<Site>()
			.Property(s => s.DefaultLanguage)
			.HasMaxLength(16);

		modelBuilder.Entity<Site>()
			.Property(s => s.SupportedLanguages)
			.HasMaxLength(128);

		modelBuilder.Entity<Site>()
			.HasIndex(s => s.Code)
			.IsUnique();

		modelBuilder.Entity<Category>()
			.Property(c => c.SiteId)
			.HasDefaultValue(SiteSeed.DefaultId);

		modelBuilder.Entity<Category>()
			.HasOne(c => c.Site)
			.WithMany(s => s.Categories)
			.HasForeignKey(c => c.SiteId)
			.OnDelete(DeleteBehavior.Restrict);

		modelBuilder.Entity<Category>()
			.HasIndex(c => new { c.SiteId, c.Name })
			.IsUnique();

		modelBuilder.Entity<Product>()
			.Property(p => p.SiteId)
			.HasDefaultValue(SiteSeed.DefaultId);

		modelBuilder.Entity<Product>()
			.HasOne(p => p.Site)
			.WithMany(s => s.Products)
			.HasForeignKey(p => p.SiteId)
			.OnDelete(DeleteBehavior.Restrict);

		modelBuilder.Entity<Product>()
			.HasIndex(p => new { p.SiteId, p.CategoryId });

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

		modelBuilder.Entity<Cart>()
			.Property(c => c.SiteId)
			.HasDefaultValue(SiteSeed.DefaultId);

		modelBuilder.Entity<Cart>()
			.HasOne(c => c.Site)
			.WithMany(s => s.Carts)
			.HasForeignKey(c => c.SiteId)
			.OnDelete(DeleteBehavior.Restrict);

		modelBuilder.Entity<Cart>()
			.HasIndex(c => new { c.SiteId, c.Code })
			.IsUnique();

		modelBuilder.Entity<Cart>()
			.HasIndex(c => new { c.SiteId, c.UserId });

		modelBuilder.Entity<Order>()
			.Property(o => o.SiteId)
			.HasDefaultValue(SiteSeed.DefaultId);

		modelBuilder.Entity<Order>()
			.HasOne(o => o.Site)
			.WithMany(s => s.Orders)
			.HasForeignKey(o => o.SiteId)
			.OnDelete(DeleteBehavior.Restrict);

		modelBuilder.Entity<Order>()
			.HasIndex(o => o.SiteId);

		modelBuilder.Entity<AuthSession>()
			.HasOne(s => s.User)
			.WithMany(u => u.AuthSessions)
			.HasForeignKey(s => s.UserId)
			.OnDelete(DeleteBehavior.Cascade);

		modelBuilder.Entity<AuthSession>()
			.HasIndex(s => s.UserId);

		modelBuilder.Entity<AuthSession>()
			.HasIndex(s => s.ExpiresAtUtc);

		modelBuilder.Entity<AuthSession>()
			.Property(s => s.SiteId)
			.HasDefaultValue(SiteSeed.DefaultId);

		modelBuilder.Entity<AuthSession>()
			.HasOne(s => s.Site)
			.WithMany(site => site.AuthSessions)
			.HasForeignKey(s => s.SiteId)
			.OnDelete(DeleteBehavior.Restrict);

		modelBuilder.Entity<AuthSession>()
			.HasIndex(s => new { s.SiteId, s.UserId });

		modelBuilder.Entity<CartItem>()
			.HasMany(i => i.Addons)
			.WithOne(a => a.CartItem)
			.HasForeignKey(a => a.CartItemId)
			.OnDelete(DeleteBehavior.Cascade);

		modelBuilder.Entity<Category>().HasData(CategorySeed.Categories);

		modelBuilder.Entity<Product>().HasData(ProductSeed.Products);
		modelBuilder.Entity<ProductSpec>().HasData(ProductSpecSeed.ProductSpecs);
	}
}
