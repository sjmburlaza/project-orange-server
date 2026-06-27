using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data.Seeds;

public static class ProductSpecSeed
{
	private static readonly ProductSpec[] BaseProductSpecs =
	[
		new ProductSpec { Id = 1, ProductId = 1, Name = "Storage", Value = "128GB" },
		new ProductSpec { Id = 2, ProductId = 1, Name = "Color", Value = "Black" },

		new ProductSpec { Id = 3, ProductId = 2, Name = "Storage", Value = "256GB" },
		new ProductSpec { Id = 4, ProductId = 2, Name = "Color", Value = "Gray" },

		new ProductSpec { Id = 5, ProductId = 3, Name = "Storage", Value = "128GB" },
		new ProductSpec { Id = 6, ProductId = 3, Name = "Color", Value = "Obsidian" },

		new ProductSpec { Id = 7, ProductId = 4, Name = "Storage", Value = "256GB" },
		new ProductSpec { Id = 8, ProductId = 4, Name = "Color", Value = "Green" },

		new ProductSpec { Id = 9, ProductId = 5, Name = "Storage", Value = "256GB" },
		new ProductSpec { Id = 10, ProductId = 5, Name = "Color", Value = "Silver" },

		new ProductSpec { Id = 11, ProductId = 6, Name = "Memory", Value = "8GB" },
		new ProductSpec { Id = 12, ProductId = 6, Name = "Storage", Value = "256GB" },
		new ProductSpec { Id = 13, ProductId = 6, Name = "Color", Value = "Midnight" },

		new ProductSpec { Id = 14, ProductId = 7, Name = "Memory", Value = "16GB" },
		new ProductSpec { Id = 15, ProductId = 7, Name = "Storage", Value = "512GB" },
		new ProductSpec { Id = 16, ProductId = 7, Name = "Color", Value = "Silver" },

		new ProductSpec { Id = 17, ProductId = 8, Name = "Memory", Value = "16GB" },
		new ProductSpec { Id = 18, ProductId = 8, Name = "Storage", Value = "1TB" },
		new ProductSpec { Id = 19, ProductId = 8, Name = "Color", Value = "Black" },

		new ProductSpec { Id = 20, ProductId = 9, Name = "Memory", Value = "32GB" },
		new ProductSpec { Id = 21, ProductId = 9, Name = "Storage", Value = "1TB" },
		new ProductSpec { Id = 22, ProductId = 9, Name = "Color", Value = "White" },

		new ProductSpec { Id = 23, ProductId = 10, Name = "Memory", Value = "16GB" },
		new ProductSpec { Id = 24, ProductId = 10, Name = "Storage", Value = "512GB" },
		new ProductSpec { Id = 25, ProductId = 10, Name = "Color", Value = "Gray" },

		new ProductSpec { Id = 26, ProductId = 11, Name = "Connection", Value = "USB-C" },
		new ProductSpec { Id = 27, ProductId = 11, Name = "Color", Value = "Black" },

		new ProductSpec { Id = 28, ProductId = 12, Name = "Connection", Value = "Bluetooth" },
		new ProductSpec { Id = 29, ProductId = 12, Name = "Color", Value = "White" },

		new ProductSpec { Id = 30, ProductId = 13, Name = "Ports", Value = "7-in-1" },
		new ProductSpec { Id = 31, ProductId = 13, Name = "Color", Value = "Space Gray" },

		new ProductSpec { Id = 32, ProductId = 14, Name = "Material", Value = "Aluminum" },
		new ProductSpec { Id = 33, ProductId = 14, Name = "Color", Value = "Silver" },

		new ProductSpec { Id = 34, ProductId = 15, Name = "Connection", Value = "Bluetooth" },
		new ProductSpec { Id = 35, ProductId = 15, Name = "Color", Value = "Black" },

		new ProductSpec { Id = 36, ProductId = 16, Name = "Connection", Value = "Bluetooth" },
		new ProductSpec { Id = 37, ProductId = 16, Name = "Color", Value = "Blue" },

		new ProductSpec { Id = 38, ProductId = 17, Name = "Resolution", Value = "1080p" },
		new ProductSpec { Id = 39, ProductId = 17, Name = "Color", Value = "Black" },

		new ProductSpec { Id = 40, ProductId = 18, Name = "Storage", Value = "1TB" },
		new ProductSpec { Id = 41, ProductId = 18, Name = "Color", Value = "Black" },

		new ProductSpec { Id = 42, ProductId = 19, Name = "Capacity", Value = "20000mAh" },
		new ProductSpec { Id = 43, ProductId = 19, Name = "Color", Value = "White" },

		new ProductSpec { Id = 44, ProductId = 20, Name = "Size", Value = "27-inch" },
		new ProductSpec { Id = 45, ProductId = 20, Name = "Resolution", Value = "QHD" },
		new ProductSpec { Id = 46, ProductId = 20, Name = "Color", Value = "Black" },
		new ProductSpec { Id = 47, ProductId = 20, Name = "Refresh Rate", Value = "75Hz" },
		new ProductSpec { Id = 48, ProductId = 20, Name = "Panel", Value = "IPS" },

		new ProductSpec { Id = 49, ProductId = 21, Name = "Size", Value = "24-inch" },
		new ProductSpec { Id = 50, ProductId = 21, Name = "Resolution", Value = "FHD" },
		new ProductSpec { Id = 51, ProductId = 21, Name = "Refresh Rate", Value = "75Hz" },
		new ProductSpec { Id = 52, ProductId = 21, Name = "Panel", Value = "IPS" },

		new ProductSpec { Id = 53, ProductId = 22, Name = "Size", Value = "32-inch" },
		new ProductSpec { Id = 54, ProductId = 22, Name = "Resolution", Value = "4K UHD" },
		new ProductSpec { Id = 55, ProductId = 22, Name = "HDR", Value = "HDR10" },
		new ProductSpec { Id = 56, ProductId = 22, Name = "Panel", Value = "IPS" },

		new ProductSpec { Id = 57, ProductId = 23, Name = "Size", Value = "34-inch" },
		new ProductSpec { Id = 58, ProductId = 23, Name = "Resolution", Value = "UWQHD" },
		new ProductSpec { Id = 59, ProductId = 23, Name = "Refresh Rate", Value = "144Hz" },
		new ProductSpec { Id = 60, ProductId = 23, Name = "Panel", Value = "VA" }
	];

	public static ProductSpec[] ProductSpecs =>
		SiteSeed.Sites
			.SelectMany((site, siteIndex) =>
				BaseProductSpecs.Select(spec => new ProductSpec
				{
					Id = (siteIndex * 100) + spec.Id,
					ProductId = ProductSeed.GetProductId(site.Id, spec.ProductId),
					Name = spec.Name,
					Value = spec.Value
				}))
			.ToArray();
}
