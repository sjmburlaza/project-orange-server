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
	public DbSet<AnalyticsEvent> AnalyticsEvents => Set<AnalyticsEvent>();
	public DbSet<AnalyticsEventItem> AnalyticsEventItems => Set<AnalyticsEventItem>();


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

		modelBuilder.Entity<Order>()
			.Property(o => o.OrderNumber)
			.HasMaxLength(32);

		modelBuilder.Entity<Order>()
			.Property(o => o.PaymentStatus)
			.HasMaxLength(32);

		modelBuilder.Entity<Order>()
			.Property(o => o.OrderStatus)
			.HasMaxLength(32);

		modelBuilder.Entity<Order>()
			.Property(o => o.RecipientName)
			.HasMaxLength(256);

		modelBuilder.Entity<Order>()
			.Property(o => o.MobileNumber)
			.HasMaxLength(32);

		modelBuilder.Entity<Order>()
			.Property(o => o.AddressLine1)
			.HasMaxLength(512);

		modelBuilder.Entity<Order>()
			.Property(o => o.AddressLine2)
			.HasMaxLength(512);

		modelBuilder.Entity<Order>()
			.Property(o => o.Barangay)
			.HasMaxLength(128);

		modelBuilder.Entity<Order>()
			.Property(o => o.City)
			.HasMaxLength(128);

		modelBuilder.Entity<Order>()
			.Property(o => o.Region)
			.HasMaxLength(128);

		modelBuilder.Entity<Order>()
			.Property(o => o.PostalCode)
			.HasMaxLength(32);

		modelBuilder.Entity<Order>()
			.Property(o => o.Country)
			.HasMaxLength(128);

		modelBuilder.Entity<Order>()
			.Property(o => o.DeliveryEstimate)
			.HasMaxLength(64);

		modelBuilder.Entity<Order>()
			.Property(o => o.CheckoutDataJson)
			.HasColumnType("nvarchar(max)");

		modelBuilder.Entity<OrderItem>()
			.Property(o => o.Price)
			.HasPrecision(18, 2);

		modelBuilder.Entity<OrderItem>()
			.Property(o => o.ProductName)
			.HasMaxLength(256);

		modelBuilder.Entity<OrderItem>()
			.Property(o => o.ImageUrl)
			.HasMaxLength(1024);

		modelBuilder.Entity<OrderItem>()
			.Property(o => o.CategoryName)
			.HasMaxLength(128);

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

		modelBuilder.Entity<Order>()
			.HasIndex(o => new { o.SiteId, o.OrderNumber })
			.IsUnique();

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

		modelBuilder.Entity<AnalyticsEvent>()
			.HasKey(e => e.Id);

		modelBuilder.Entity<AnalyticsEvent>()
			.Property(e => e.Id)
			.HasMaxLength(128);

		modelBuilder.Entity<AnalyticsEvent>()
			.Property(e => e.SiteId)
			.HasDefaultValue(SiteSeed.DefaultId);

		modelBuilder.Entity<AnalyticsEvent>()
			.HasOne(e => e.Site)
			.WithMany(site => site.AnalyticsEvents)
			.HasForeignKey(e => e.SiteId)
			.OnDelete(DeleteBehavior.Restrict);

		modelBuilder.Entity<AnalyticsEvent>()
			.Property(e => e.Type)
			.HasMaxLength(32);

		modelBuilder.Entity<AnalyticsEvent>()
			.Property(e => e.VisitorId)
			.HasMaxLength(128);

		modelBuilder.Entity<AnalyticsEvent>()
			.Property(e => e.SessionId)
			.HasMaxLength(128);

		modelBuilder.Entity<AnalyticsEvent>()
			.Property(e => e.ProductName)
			.HasMaxLength(256);

		modelBuilder.Entity<AnalyticsEvent>()
			.Property(e => e.CategoryName)
			.HasMaxLength(128);

		modelBuilder.Entity<AnalyticsEvent>()
			.Property(e => e.Value)
			.HasPrecision(18, 2);

		modelBuilder.Entity<AnalyticsEvent>()
			.Property(e => e.OrderNumber)
			.HasMaxLength(64);

		modelBuilder.Entity<AnalyticsEvent>()
			.Property(e => e.FailureReason)
			.HasMaxLength(256);

		modelBuilder.Entity<AnalyticsEvent>()
			.HasIndex(e => new { e.SiteId, e.Type, e.OccurredAt });

		modelBuilder.Entity<AnalyticsEvent>()
			.HasIndex(e => new { e.SiteId, e.OrderNumber })
			.HasFilter("[OrderNumber] IS NOT NULL AND [Type] = 'purchase'");

		modelBuilder.Entity<AnalyticsEventItem>()
			.Property(i => i.AnalyticsEventId)
			.HasMaxLength(128);

		modelBuilder.Entity<AnalyticsEventItem>()
			.Property(i => i.ProductName)
			.HasMaxLength(256);

		modelBuilder.Entity<AnalyticsEventItem>()
			.Property(i => i.CategoryName)
			.HasMaxLength(128);

		modelBuilder.Entity<AnalyticsEventItem>()
			.Property(i => i.Price)
			.HasPrecision(18, 2);

		modelBuilder.Entity<AnalyticsEventItem>()
			.HasOne(i => i.AnalyticsEvent)
			.WithMany(e => e.Items)
			.HasForeignKey(i => i.AnalyticsEventId)
			.OnDelete(DeleteBehavior.Cascade);

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
