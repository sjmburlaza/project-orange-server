using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Controllers;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;
using ProjectOrangeApi.Tests.Support;
using Xunit;

namespace ProjectOrangeApi.Tests.Integration;

public class AdminProductEndpointTests
{
    [Fact]
    public async Task CreateProduct_WithConfigurableOptions_CreatesProductGraph()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"admin-products-create-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        var category = SeedCategory(db, site);
        await db.SaveChangesAsync();

        var controller = new AdminProductsController(db, siteContext);

        var response = await controller.CreateProduct(CreateConfigurableProductRequest(category.Id));

        var created = Assert.IsType<CreatedAtActionResult>(response.Result);
        var product = Assert.IsType<ProductConfigureDto>(created.Value);
        Assert.Equal(nameof(AdminProductsController.GetProduct), created.ActionName);
        Assert.Equal("Admin Test Phone", product.Name);
        Assert.Equal(4.6m, product.ReviewRating);
        Assert.Equal(246, product.ReviewCount);
        Assert.Equal("Phones", product.CategoryName);
        Assert.Equal("Flagship", product.SubcategoryName);
        Assert.Equal(["Fast chip", "Bright display"], product.Features);
        Assert.Equal(2, product.OptionGroups.Count);
        Assert.Equal(2, product.Variants.Count);
        Assert.Equal(7, product.StockQuantity);

        var savedProduct = await db.Products
            .Include(candidate => candidate.ItemSpecs)
            .Include(candidate => candidate.OptionGroups)
                .ThenInclude(group => group.Options)
            .Include(candidate => candidate.Variants)
                .ThenInclude(variant => variant.VariantOptions)
                    .ThenInclude(variantOption => variantOption.ProductOption)
                        .ThenInclude(option => option.ProductOptionGroup)
            .SingleAsync(candidate => candidate.Id == product.Id);

        Assert.Equal(2, savedProduct.ItemSpecs.Count);
        Assert.Equal(2, savedProduct.OptionGroups.Count);
        Assert.Equal(3, savedProduct.OptionGroups.Sum(group => group.Options.Count));
        Assert.Equal(2, savedProduct.Variants.Count);
        Assert.All(savedProduct.Variants, variant => Assert.Equal(2, variant.VariantOptions.Count));
    }

    [Fact]
    public async Task UpdateProduct_ReplacesChildCollections()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"admin-products-update-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        var category = SeedCategory(db, site);
        await db.SaveChangesAsync();

        var controller = new AdminProductsController(db, siteContext);
        var createResponse = await controller.CreateProduct(CreateConfigurableProductRequest(category.Id));
        var created = Assert.IsType<ProductConfigureDto>(
            Assert.IsType<CreatedAtActionResult>(createResponse.Result).Value);

        var updateResponse = await controller.UpdateProduct(created.Id, new AdminProductRequest
        {
            Name = "Updated Admin Product",
            Description = "Updated product description.",
            Price = 1800m,
            ReviewRating = 4.2m,
            ReviewCount = 84,
            StockQuantity = 3,
            ImageUrl = "/images/products/updated-admin-product.png",
            CategoryId = category.Id,
            SubcategoryName = "Updated",
            Features = ["Updated feature"],
            WhatsInTheBox = ["Updated Admin Product"],
            ItemSpecs =
            [
                new ProductSpecDto
                {
                    Name = "Weight",
                    Value = "200g"
                }
            ],
            OptionGroups =
            [
                new AdminProductOptionGroupRequest
                {
                    Code = "finish",
                    Label = "Finish",
                    SortOrder = 1,
                    Options =
                    [
                        new AdminProductOptionRequest
                        {
                            Code = "matte",
                            Label = "Matte",
                            SortOrder = 1
                        }
                    ]
                }
            ],
            Variants =
            [
                new AdminProductVariantRequest
                {
                    Sku = "ADMIN-UPDATED-MATTE",
                    Price = 1800m,
                    StockQuantity = 3,
                    ImageUrl = "/images/products/updated-admin-product.png",
                    Options = new Dictionary<string, string>
                    {
                        ["finish"] = "matte"
                    }
                }
            ]
        });

        var ok = Assert.IsType<OkObjectResult>(updateResponse.Result);
        var updated = Assert.IsType<ProductConfigureDto>(ok.Value);
        Assert.Equal("Updated Admin Product", updated.Name);
        Assert.Equal(4.2m, updated.ReviewRating);
        Assert.Equal(84, updated.ReviewCount);
        Assert.Equal(["Updated feature"], updated.Features);
        Assert.Single(updated.ItemSpecs);
        Assert.Single(updated.OptionGroups);
        Assert.Single(updated.Variants);

        var savedProduct = await db.Products
            .Include(candidate => candidate.ItemSpecs)
            .Include(candidate => candidate.OptionGroups)
                .ThenInclude(group => group.Options)
            .Include(candidate => candidate.Variants)
                .ThenInclude(variant => variant.VariantOptions)
                    .ThenInclude(variantOption => variantOption.ProductOption)
            .SingleAsync(candidate => candidate.Id == created.Id);

        Assert.Equal("Updated", savedProduct.SubcategoryName);
        Assert.DoesNotContain(savedProduct.OptionGroups, group => group.Code == "color");
        var finishGroup = Assert.Single(savedProduct.OptionGroups);
        Assert.Equal("finish", finishGroup.Code);
        Assert.Equal("matte", Assert.Single(finishGroup.Options).Code);
        Assert.Equal("ADMIN-UPDATED-MATTE", Assert.Single(savedProduct.Variants).Sku);
    }

    [Fact]
    public async Task DeleteProduct_WhenProductIsReferenced_ReturnsConflict()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"admin-products-delete-conflict-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        var category = SeedCategory(db, site);
        var product = CreateProduct(site, category);
        db.Products.Add(product);
        await db.SaveChangesAsync();

        db.OrderItems.Add(new OrderItem
        {
            ProductId = product.Id,
            Product = product,
            ProductName = product.Name,
            CategoryName = category.Name,
            ImageUrl = product.ImageUrl,
            Quantity = 1,
            Price = product.Price
        });
        await db.SaveChangesAsync();

        var controller = new AdminProductsController(db, siteContext);

        var response = await controller.DeleteProduct(product.Id);

        Assert.IsType<ConflictObjectResult>(response);
        Assert.True(await db.Products.AnyAsync(candidate => candidate.Id == product.Id));
    }

    [Fact]
    public async Task DeleteProduct_WhenProductIsNotReferenced_RemovesProductGraph()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"admin-products-delete-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        var category = SeedCategory(db, site);
        await db.SaveChangesAsync();

        var controller = new AdminProductsController(db, siteContext);
        var createResponse = await controller.CreateProduct(CreateConfigurableProductRequest(category.Id));
        var created = Assert.IsType<ProductConfigureDto>(
            Assert.IsType<CreatedAtActionResult>(createResponse.Result).Value);

        var response = await controller.DeleteProduct(created.Id);

        Assert.IsType<NoContentResult>(response);
        Assert.False(await db.Products.AnyAsync(product => product.Id == created.Id));
        Assert.Empty(await db.ProductOptionGroups.ToListAsync());
        Assert.Empty(await db.ProductOptions.ToListAsync());
        Assert.Empty(await db.ProductVariants.ToListAsync());
        Assert.Empty(await db.ProductVariantOptions.ToListAsync());
        Assert.Empty(await db.ProductSpecs.ToListAsync());
    }

    private static Category SeedCategory(AppDbContext db, Site site)
    {
        var category = new Category
        {
            Id = 100,
            SiteId = site.Id,
            Site = site,
            Name = "Phones",
            Subcategories = ["Flagship", "Updated"]
        };

        db.Sites.Add(site);
        db.Categories.Add(category);

        return category;
    }

    private static AdminProductRequest CreateConfigurableProductRequest(int categoryId)
    {
        return new AdminProductRequest
        {
            Name = "Admin Test Phone",
            Description = "A phone created through the admin API.",
            Price = 999m,
            ReviewRating = 4.6m,
            ReviewCount = 246,
            StockQuantity = 10,
            ImageUrl = "/images/products/admin-test-phone.png",
            CategoryId = categoryId,
            SubcategoryName = "Flagship",
            Features = ["Fast chip", "Bright display"],
            WhatsInTheBox = ["Admin Test Phone", "USB-C cable"],
            ItemSpecs =
            [
                new ProductSpecDto
                {
                    Name = "Display",
                    Value = "6.1-inch"
                },
                new ProductSpecDto
                {
                    Name = "Storage",
                    Value = "128GB"
                }
            ],
            OptionGroups =
            [
                new AdminProductOptionGroupRequest
                {
                    Code = "color",
                    Label = "Color",
                    SortOrder = 1,
                    Options =
                    [
                        new AdminProductOptionRequest
                        {
                            Code = "black",
                            Label = "Black",
                            Hex = "#111827",
                            SortOrder = 1
                        },
                        new AdminProductOptionRequest
                        {
                            Code = "blue",
                            Label = "Blue",
                            Hex = "#2563eb",
                            ImageUrl = "/images/products/admin-test-phone-blue.png",
                            SortOrder = 2
                        }
                    ]
                },
                new AdminProductOptionGroupRequest
                {
                    Code = "storage",
                    Label = "Storage",
                    SortOrder = 2,
                    Options =
                    [
                        new AdminProductOptionRequest
                        {
                            Code = "128gb",
                            Label = "128GB",
                            SortOrder = 1
                        }
                    ]
                }
            ],
            Variants =
            [
                new AdminProductVariantRequest
                {
                    Sku = "ADMIN-PHONE-BLACK-128GB",
                    Price = 999m,
                    StockQuantity = 5,
                    ImageUrl = "/images/products/admin-test-phone.png",
                    Options = new Dictionary<string, string>
                    {
                        ["color"] = "black",
                        ["storage"] = "128gb"
                    }
                },
                new AdminProductVariantRequest
                {
                    Sku = "ADMIN-PHONE-BLUE-128GB",
                    Price = 1099m,
                    StockQuantity = 2,
                    ImageUrl = "/images/products/admin-test-phone-blue.png",
                    Options = new Dictionary<string, string>
                    {
                        ["color"] = "blue",
                        ["storage"] = "128gb"
                    }
                }
            ]
        };
    }

    private static Product CreateProduct(Site site, Category category)
    {
        return new Product
        {
            SiteId = site.Id,
            Site = site,
            Name = "Referenced Product",
            Description = "A product that cannot be deleted.",
            Price = 500m,
            StockQuantity = 3,
            ImageUrl = "/images/products/referenced-product.png",
            CategoryId = category.Id,
            Category = category
        };
    }

    private static Site CloneSite(Site site)
    {
        return new Site
        {
            Id = site.Id,
            Code = site.Code,
            CountryName = site.CountryName,
            Locale = site.Locale,
            Currency = site.Currency,
            DefaultLanguage = site.DefaultLanguage,
            SupportedLanguages = site.SupportedLanguages,
            InsuranceEnabled = site.InsuranceEnabled,
            TradeInEnabled = site.TradeInEnabled,
            VouchersEnabled = site.VouchersEnabled,
            IsActive = site.IsActive
        };
    }
}
