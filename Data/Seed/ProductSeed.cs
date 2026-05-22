using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data.Seed;

public static class ProductSeed
{
  public static Product[] Products => new[]
    {
        new Product { Id = 1, Name = "iPhone 15", Description = "Apple smartphone", Price = 59999, StockQuantity = 10, ImageUrl = "", CategoryId = 1 },
        new Product { Id = 2, Name = "Samsung Galaxy S24", Description = "Android flagship smartphone", Price = 54999, StockQuantity = 12, ImageUrl = "", CategoryId = 1 },
        new Product { Id = 3, Name = "Google Pixel 8", Description = "Google AI smartphone", Price = 39999, StockQuantity = 8, ImageUrl = "", CategoryId = 1 },
        new Product { Id = 4, Name = "Xiaomi 14", Description = "High-performance Android phone", Price = 32999, StockQuantity = 15, ImageUrl = "", CategoryId = 1 },
        new Product { Id = 5, Name = "OnePlus 12", Description = "Fast charging flagship phone", Price = 45999, StockQuantity = 9, ImageUrl = "", CategoryId = 1 },

        new Product { Id = 6, Name = "MacBook Air M3", Description = "Lightweight Apple laptop", Price = 69999, StockQuantity = 7, ImageUrl = "", CategoryId = 2 },
        new Product { Id = 7, Name = "Dell XPS 13", Description = "Premium Windows ultrabook", Price = 74999, StockQuantity = 6, ImageUrl = "", CategoryId = 2 },
        new Product { Id = 8, Name = "Lenovo ThinkPad X1 Carbon", Description = "Business laptop", Price = 89999, StockQuantity = 5, ImageUrl = "", CategoryId = 2 },
        new Product { Id = 9, Name = "ASUS ROG Zephyrus G14", Description = "Gaming laptop", Price = 94999, StockQuantity = 4, ImageUrl = "", CategoryId = 2 },
        new Product { Id = 10, Name = "Acer Swift Go 14", Description = "Portable productivity laptop", Price = 39999, StockQuantity = 11, ImageUrl = "", CategoryId = 2 },

        new Product { Id = 11, Name = "Mechanical Keyboard", Description = "RGB keyboard", Price = 3500, StockQuantity = 25, ImageUrl = "", CategoryId = 3 },
        new Product { Id = 12, Name = "Wireless Mouse", Description = "Ergonomic wireless mouse", Price = 1200, StockQuantity = 40, ImageUrl = "", CategoryId = 3 },
        new Product { Id = 13, Name = "USB-C Hub", Description = "Multi-port USB-C adapter", Price = 1800, StockQuantity = 30, ImageUrl = "", CategoryId = 3 },
        new Product { Id = 14, Name = "Laptop Stand", Description = "Aluminum adjustable stand", Price = 1500, StockQuantity = 20, ImageUrl = "", CategoryId = 3 },
        new Product { Id = 15, Name = "Noise Cancelling Headphones", Description = "Wireless over-ear headphones", Price = 8999, StockQuantity = 14, ImageUrl = "", CategoryId = 3 },
        new Product { Id = 16, Name = "Bluetooth Speaker", Description = "Portable speaker", Price = 2500, StockQuantity = 18, ImageUrl = "", CategoryId = 3 },
        new Product { Id = 17, Name = "Webcam 1080p", Description = "Full HD webcam", Price = 2200, StockQuantity = 22, ImageUrl = "", CategoryId = 3 },
        new Product { Id = 18, Name = "External SSD 1TB", Description = "Portable high-speed SSD", Price = 6500, StockQuantity = 16, ImageUrl = "", CategoryId = 3 },
        new Product { Id = 19, Name = "Power Bank 20000mAh", Description = "Fast-charging power bank", Price = 2000, StockQuantity = 28, ImageUrl = "", CategoryId = 3 },
        new Product { Id = 20, Name = "27-inch Monitor", Description = "QHD productivity monitor", Price = 12999, StockQuantity = 10, ImageUrl = "", CategoryId = 3 }
    };
}