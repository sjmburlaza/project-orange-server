using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { 1, "Android flagship smartphone", "Samsung Galaxy S24", 54999m, 12 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 3, 1, "Google AI smartphone", "", "Google Pixel 8", 39999m, 8 },
                    { 4, 1, "High-performance Android phone", "", "Xiaomi 14", 32999m, 15 },
                    { 5, 1, "Fast charging flagship phone", "", "OnePlus 12", 45999m, 9 },
                    { 6, 2, "Lightweight Apple laptop", "", "MacBook Air M3", 69999m, 7 },
                    { 7, 2, "Premium Windows ultrabook", "", "Dell XPS 13", 74999m, 6 },
                    { 8, 2, "Business laptop", "", "Lenovo ThinkPad X1 Carbon", 89999m, 5 },
                    { 9, 2, "Gaming laptop", "", "ASUS ROG Zephyrus G14", 94999m, 4 },
                    { 10, 2, "Portable productivity laptop", "", "Acer Swift Go 14", 39999m, 11 },
                    { 11, 3, "RGB keyboard", "", "Mechanical Keyboard", 3500m, 25 },
                    { 12, 3, "Ergonomic wireless mouse", "", "Wireless Mouse", 1200m, 40 },
                    { 13, 3, "Multi-port USB-C adapter", "", "USB-C Hub", 1800m, 30 },
                    { 14, 3, "Aluminum adjustable stand", "", "Laptop Stand", 1500m, 20 },
                    { 15, 3, "Wireless over-ear headphones", "", "Noise Cancelling Headphones", 8999m, 14 },
                    { 16, 3, "Portable speaker", "", "Bluetooth Speaker", 2500m, 18 },
                    { 17, 3, "Full HD webcam", "", "Webcam 1080p", 2200m, 22 },
                    { 18, 3, "Portable high-speed SSD", "", "External SSD 1TB", 6500m, 16 },
                    { 19, 3, "Fast-charging power bank", "", "Power Bank 20000mAh", 2000m, 28 },
                    { 20, 3, "QHD productivity monitor", "", "27-inch Monitor", 12999m, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { 3, "RGB keyboard", "Mechanical Keyboard", 3500m, 25 });
        }
    }
}
