using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class AddMultiSiteSupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "AuthSessions",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Locale = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    DefaultLanguage = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    SupportedLanguages = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    InsuranceEnabled = table.Column<bool>(type: "bit", nullable: false),
                    TradeInEnabled = table.Column<bool>(type: "bit", nullable: false),
                    VouchersEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "SiteId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "SiteId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Sites",
                columns: new[] { "Id", "Code", "CountryName", "Currency", "DefaultLanguage", "InsuranceEnabled", "IsActive", "Locale", "SupportedLanguages", "TradeInEnabled", "VouchersEnabled" },
                values: new object[,]
                {
                    { 1, "ph", "Philippines", "PHP", "en", true, true, "en-PH", "en", true, true },
                    { 2, "fr", "France", "EUR", "fr", true, true, "fr-FR", "fr", false, true },
                    { 3, "cn", "China", "CNY", "zh", true, true, "zh-CN", "zh", true, true },
                    { 4, "jp", "Japan", "JPY", "ja", true, true, "ja-JP", "ja", true, true }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "SiteId" },
                values: new object[,]
                {
                    { 4, "Phones", 2 },
                    { 5, "Laptops", 2 },
                    { 6, "Accessories", 2 },
                    { 7, "Phones", 3 },
                    { 8, "Laptops", 3 },
                    { 9, "Accessories", 3 },
                    { 10, "Phones", 4 },
                    { 11, "Laptops", 4 },
                    { 12, "Accessories", 4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "SiteId", "StockQuantity" },
                values: new object[,]
                {
                    { 21, 4, "Apple smartphone", "", "iPhone 15", 999.98m, 2, 10 },
                    { 22, 4, "Android flagship smartphone", "", "Samsung Galaxy S24", 916.65m, 2, 12 },
                    { 23, 4, "Google AI smartphone", "", "Google Pixel 8", 666.65m, 2, 8 },
                    { 24, 4, "High-performance Android phone", "", "Xiaomi 14", 549.98m, 2, 15 },
                    { 25, 4, "Fast charging flagship phone", "", "OnePlus 12", 766.65m, 2, 9 },
                    { 26, 5, "Lightweight Apple laptop", "", "MacBook Air M3", 1166.65m, 2, 7 },
                    { 27, 5, "Premium Windows ultrabook", "", "Dell XPS 13", 1249.98m, 2, 6 },
                    { 28, 5, "Business laptop", "", "Lenovo ThinkPad X1 Carbon", 1499.98m, 2, 5 },
                    { 29, 5, "Gaming laptop", "", "ASUS ROG Zephyrus G14", 1583.32m, 2, 4 },
                    { 30, 5, "Portable productivity laptop", "", "Acer Swift Go 14", 666.65m, 2, 11 },
                    { 31, 6, "RGB keyboard", "", "Mechanical Keyboard", 58.33m, 2, 25 },
                    { 32, 6, "Ergonomic wireless mouse", "", "Wireless Mouse", 20m, 2, 40 },
                    { 33, 6, "Multi-port USB-C adapter", "", "USB-C Hub", 30m, 2, 30 },
                    { 34, 6, "Aluminum adjustable stand", "", "Laptop Stand", 25m, 2, 20 },
                    { 35, 6, "Wireless over-ear headphones", "", "Noise Cancelling Headphones", 149.98m, 2, 14 },
                    { 36, 6, "Portable speaker", "", "Bluetooth Speaker", 41.67m, 2, 18 },
                    { 37, 6, "Full HD webcam", "", "Webcam 1080p", 36.67m, 2, 22 },
                    { 38, 6, "Portable high-speed SSD", "", "External SSD 1TB", 108.33m, 2, 16 },
                    { 39, 6, "Fast-charging power bank", "", "Power Bank 20000mAh", 33.33m, 2, 28 },
                    { 40, 6, "QHD productivity monitor", "", "27-inch Monitor", 216.65m, 2, 10 },
                    { 41, 7, "Apple smartphone", "", "iPhone 15", 7692.18m, 3, 10 },
                    { 42, 7, "Android flagship smartphone", "", "Samsung Galaxy S24", 7051.15m, 3, 12 },
                    { 43, 7, "Google AI smartphone", "", "Google Pixel 8", 5128.08m, 3, 8 },
                    { 44, 7, "High-performance Android phone", "", "Xiaomi 14", 4230.64m, 3, 15 },
                    { 45, 7, "Fast charging flagship phone", "", "OnePlus 12", 5897.31m, 3, 9 },
                    { 46, 8, "Lightweight Apple laptop", "", "MacBook Air M3", 8974.23m, 3, 7 },
                    { 47, 8, "Premium Windows ultrabook", "", "Dell XPS 13", 9615.26m, 3, 6 },
                    { 48, 8, "Business laptop", "", "Lenovo ThinkPad X1 Carbon", 11538.33m, 3, 5 },
                    { 49, 8, "Gaming laptop", "", "ASUS ROG Zephyrus G14", 12179.36m, 3, 4 },
                    { 50, 8, "Portable productivity laptop", "", "Acer Swift Go 14", 5128.08m, 3, 11 },
                    { 51, 9, "RGB keyboard", "", "Mechanical Keyboard", 448.72m, 3, 25 },
                    { 52, 9, "Ergonomic wireless mouse", "", "Wireless Mouse", 153.85m, 3, 40 },
                    { 53, 9, "Multi-port USB-C adapter", "", "USB-C Hub", 230.77m, 3, 30 },
                    { 54, 9, "Aluminum adjustable stand", "", "Laptop Stand", 192.31m, 3, 20 },
                    { 55, 9, "Wireless over-ear headphones", "", "Noise Cancelling Headphones", 1153.72m, 3, 14 },
                    { 56, 9, "Portable speaker", "", "Bluetooth Speaker", 320.51m, 3, 18 },
                    { 57, 9, "Full HD webcam", "", "Webcam 1080p", 282.05m, 3, 22 },
                    { 58, 9, "Portable high-speed SSD", "", "External SSD 1TB", 833.33m, 3, 16 },
                    { 59, 9, "Fast-charging power bank", "", "Power Bank 20000mAh", 256.41m, 3, 28 },
                    { 60, 9, "QHD productivity monitor", "", "27-inch Monitor", 1666.54m, 3, 10 },
                    { 61, 10, "Apple smartphone", "", "iPhone 15", 161997m, 4, 10 },
                    { 62, 10, "Android flagship smartphone", "", "Samsung Galaxy S24", 148497m, 4, 12 },
                    { 63, 10, "Google AI smartphone", "", "Google Pixel 8", 107997m, 4, 8 },
                    { 64, 10, "High-performance Android phone", "", "Xiaomi 14", 89097m, 4, 15 },
                    { 65, 10, "Fast charging flagship phone", "", "OnePlus 12", 124197m, 4, 9 },
                    { 66, 11, "Lightweight Apple laptop", "", "MacBook Air M3", 188997m, 4, 7 },
                    { 67, 11, "Premium Windows ultrabook", "", "Dell XPS 13", 202497m, 4, 6 },
                    { 68, 11, "Business laptop", "", "Lenovo ThinkPad X1 Carbon", 242997m, 4, 5 },
                    { 69, 11, "Gaming laptop", "", "ASUS ROG Zephyrus G14", 256497m, 4, 4 },
                    { 70, 11, "Portable productivity laptop", "", "Acer Swift Go 14", 107997m, 4, 11 },
                    { 71, 12, "RGB keyboard", "", "Mechanical Keyboard", 9450m, 4, 25 },
                    { 72, 12, "Ergonomic wireless mouse", "", "Wireless Mouse", 3240m, 4, 40 },
                    { 73, 12, "Multi-port USB-C adapter", "", "USB-C Hub", 4860m, 4, 30 },
                    { 74, 12, "Aluminum adjustable stand", "", "Laptop Stand", 4050m, 4, 20 },
                    { 75, 12, "Wireless over-ear headphones", "", "Noise Cancelling Headphones", 24297m, 4, 14 },
                    { 76, 12, "Portable speaker", "", "Bluetooth Speaker", 6750m, 4, 18 },
                    { 77, 12, "Full HD webcam", "", "Webcam 1080p", 5940m, 4, 22 },
                    { 78, 12, "Portable high-speed SSD", "", "External SSD 1TB", 17550m, 4, 16 },
                    { 79, 12, "Fast-charging power bank", "", "Power Bank 20000mAh", 5400m, 4, 28 },
                    { 80, 12, "QHD productivity monitor", "", "27-inch Monitor", 35097m, 4, 10 }
                });

            migrationBuilder.InsertData(
                table: "ProductSpecs",
                columns: new[] { "Id", "Name", "ProductId", "Value" },
                values: new object[,]
                {
                    { 101, "Storage", 21, "128GB" },
                    { 102, "Color", 21, "Black" },
                    { 103, "Storage", 22, "256GB" },
                    { 104, "Color", 22, "Gray" },
                    { 105, "Storage", 23, "128GB" },
                    { 106, "Color", 23, "Obsidian" },
                    { 107, "Storage", 24, "256GB" },
                    { 108, "Color", 24, "Green" },
                    { 109, "Storage", 25, "256GB" },
                    { 110, "Color", 25, "Silver" },
                    { 111, "Memory", 26, "8GB" },
                    { 112, "Storage", 26, "256GB" },
                    { 113, "Color", 26, "Midnight" },
                    { 114, "Memory", 27, "16GB" },
                    { 115, "Storage", 27, "512GB" },
                    { 116, "Color", 27, "Silver" },
                    { 117, "Memory", 28, "16GB" },
                    { 118, "Storage", 28, "1TB" },
                    { 119, "Color", 28, "Black" },
                    { 120, "Memory", 29, "32GB" },
                    { 121, "Storage", 29, "1TB" },
                    { 122, "Color", 29, "White" },
                    { 123, "Memory", 30, "16GB" },
                    { 124, "Storage", 30, "512GB" },
                    { 125, "Color", 30, "Gray" },
                    { 126, "Connection", 31, "USB-C" },
                    { 127, "Color", 31, "Black" },
                    { 128, "Connection", 32, "Bluetooth" },
                    { 129, "Color", 32, "White" },
                    { 130, "Ports", 33, "7-in-1" },
                    { 131, "Color", 33, "Space Gray" },
                    { 132, "Material", 34, "Aluminum" },
                    { 133, "Color", 34, "Silver" },
                    { 134, "Connection", 35, "Bluetooth" },
                    { 135, "Color", 35, "Black" },
                    { 136, "Connection", 36, "Bluetooth" },
                    { 137, "Color", 36, "Blue" },
                    { 138, "Resolution", 37, "1080p" },
                    { 139, "Color", 37, "Black" },
                    { 140, "Storage", 38, "1TB" },
                    { 141, "Color", 38, "Black" },
                    { 142, "Capacity", 39, "20000mAh" },
                    { 143, "Color", 39, "White" },
                    { 144, "Size", 40, "27-inch" },
                    { 145, "Resolution", 40, "QHD" },
                    { 146, "Color", 40, "Black" },
                    { 201, "Storage", 41, "128GB" },
                    { 202, "Color", 41, "Black" },
                    { 203, "Storage", 42, "256GB" },
                    { 204, "Color", 42, "Gray" },
                    { 205, "Storage", 43, "128GB" },
                    { 206, "Color", 43, "Obsidian" },
                    { 207, "Storage", 44, "256GB" },
                    { 208, "Color", 44, "Green" },
                    { 209, "Storage", 45, "256GB" },
                    { 210, "Color", 45, "Silver" },
                    { 211, "Memory", 46, "8GB" },
                    { 212, "Storage", 46, "256GB" },
                    { 213, "Color", 46, "Midnight" },
                    { 214, "Memory", 47, "16GB" },
                    { 215, "Storage", 47, "512GB" },
                    { 216, "Color", 47, "Silver" },
                    { 217, "Memory", 48, "16GB" },
                    { 218, "Storage", 48, "1TB" },
                    { 219, "Color", 48, "Black" },
                    { 220, "Memory", 49, "32GB" },
                    { 221, "Storage", 49, "1TB" },
                    { 222, "Color", 49, "White" },
                    { 223, "Memory", 50, "16GB" },
                    { 224, "Storage", 50, "512GB" },
                    { 225, "Color", 50, "Gray" },
                    { 226, "Connection", 51, "USB-C" },
                    { 227, "Color", 51, "Black" },
                    { 228, "Connection", 52, "Bluetooth" },
                    { 229, "Color", 52, "White" },
                    { 230, "Ports", 53, "7-in-1" },
                    { 231, "Color", 53, "Space Gray" },
                    { 232, "Material", 54, "Aluminum" },
                    { 233, "Color", 54, "Silver" },
                    { 234, "Connection", 55, "Bluetooth" },
                    { 235, "Color", 55, "Black" },
                    { 236, "Connection", 56, "Bluetooth" },
                    { 237, "Color", 56, "Blue" },
                    { 238, "Resolution", 57, "1080p" },
                    { 239, "Color", 57, "Black" },
                    { 240, "Storage", 58, "1TB" },
                    { 241, "Color", 58, "Black" },
                    { 242, "Capacity", 59, "20000mAh" },
                    { 243, "Color", 59, "White" },
                    { 244, "Size", 60, "27-inch" },
                    { 245, "Resolution", 60, "QHD" },
                    { 246, "Color", 60, "Black" },
                    { 301, "Storage", 61, "128GB" },
                    { 302, "Color", 61, "Black" },
                    { 303, "Storage", 62, "256GB" },
                    { 304, "Color", 62, "Gray" },
                    { 305, "Storage", 63, "128GB" },
                    { 306, "Color", 63, "Obsidian" },
                    { 307, "Storage", 64, "256GB" },
                    { 308, "Color", 64, "Green" },
                    { 309, "Storage", 65, "256GB" },
                    { 310, "Color", 65, "Silver" },
                    { 311, "Memory", 66, "8GB" },
                    { 312, "Storage", 66, "256GB" },
                    { 313, "Color", 66, "Midnight" },
                    { 314, "Memory", 67, "16GB" },
                    { 315, "Storage", 67, "512GB" },
                    { 316, "Color", 67, "Silver" },
                    { 317, "Memory", 68, "16GB" },
                    { 318, "Storage", 68, "1TB" },
                    { 319, "Color", 68, "Black" },
                    { 320, "Memory", 69, "32GB" },
                    { 321, "Storage", 69, "1TB" },
                    { 322, "Color", 69, "White" },
                    { 323, "Memory", 70, "16GB" },
                    { 324, "Storage", 70, "512GB" },
                    { 325, "Color", 70, "Gray" },
                    { 326, "Connection", 71, "USB-C" },
                    { 327, "Color", 71, "Black" },
                    { 328, "Connection", 72, "Bluetooth" },
                    { 329, "Color", 72, "White" },
                    { 330, "Ports", 73, "7-in-1" },
                    { 331, "Color", 73, "Space Gray" },
                    { 332, "Material", 74, "Aluminum" },
                    { 333, "Color", 74, "Silver" },
                    { 334, "Connection", 75, "Bluetooth" },
                    { 335, "Color", 75, "Black" },
                    { 336, "Connection", 76, "Bluetooth" },
                    { 337, "Color", 76, "Blue" },
                    { 338, "Resolution", 77, "1080p" },
                    { 339, "Color", 77, "Black" },
                    { 340, "Storage", 78, "1TB" },
                    { 341, "Color", 78, "Black" },
                    { 342, "Capacity", 79, "20000mAh" },
                    { 343, "Color", 79, "White" },
                    { 344, "Size", 80, "27-inch" },
                    { 345, "Resolution", 80, "QHD" },
                    { 346, "Color", 80, "Black" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SiteId_CategoryId",
                table: "Products",
                columns: new[] { "SiteId", "CategoryId" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SiteId",
                table: "Orders",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SiteId_Name",
                table: "Categories",
                columns: new[] { "SiteId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_SiteId_Code",
                table: "Carts",
                columns: new[] { "SiteId", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_SiteId_UserId",
                table: "Carts",
                columns: new[] { "SiteId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AuthSessions_SiteId_UserId",
                table: "AuthSessions",
                columns: new[] { "SiteId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Sites_Code",
                table: "Sites",
                column: "Code",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthSessions_Sites_SiteId",
                table: "AuthSessions",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Sites_SiteId",
                table: "Carts",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Sites_SiteId",
                table: "Categories",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Sites_SiteId",
                table: "Orders",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sites_SiteId",
                table: "Products",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthSessions_Sites_SiteId",
                table: "AuthSessions");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Sites_SiteId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Sites_SiteId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Sites_SiteId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sites_SiteId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.DropIndex(
                name: "IX_Products_SiteId_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SiteId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SiteId_Name",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Carts_SiteId_Code",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_SiteId_UserId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_AuthSessions_SiteId_UserId",
                table: "AuthSessions");

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "AuthSessions");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
