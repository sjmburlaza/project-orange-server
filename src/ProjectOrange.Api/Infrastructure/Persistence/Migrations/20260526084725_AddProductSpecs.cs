using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class AddProductSpecs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductSpecs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSpecs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductSpecs",
                columns: new[] { "Id", "Name", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, "Storage", 1, "128GB" },
                    { 2, "Color", 1, "Black" },
                    { 3, "Storage", 2, "256GB" },
                    { 4, "Color", 2, "Gray" },
                    { 5, "Storage", 3, "128GB" },
                    { 6, "Color", 3, "Obsidian" },
                    { 7, "Storage", 4, "256GB" },
                    { 8, "Color", 4, "Green" },
                    { 9, "Storage", 5, "256GB" },
                    { 10, "Color", 5, "Silver" },
                    { 11, "Memory", 6, "8GB" },
                    { 12, "Storage", 6, "256GB" },
                    { 13, "Color", 6, "Midnight" },
                    { 14, "Memory", 7, "16GB" },
                    { 15, "Storage", 7, "512GB" },
                    { 16, "Color", 7, "Silver" },
                    { 17, "Memory", 8, "16GB" },
                    { 18, "Storage", 8, "1TB" },
                    { 19, "Color", 8, "Black" },
                    { 20, "Memory", 9, "32GB" },
                    { 21, "Storage", 9, "1TB" },
                    { 22, "Color", 9, "White" },
                    { 23, "Memory", 10, "16GB" },
                    { 24, "Storage", 10, "512GB" },
                    { 25, "Color", 10, "Gray" },
                    { 26, "Connection", 11, "USB-C" },
                    { 27, "Color", 11, "Black" },
                    { 28, "Connection", 12, "Bluetooth" },
                    { 29, "Color", 12, "White" },
                    { 30, "Ports", 13, "7-in-1" },
                    { 31, "Color", 13, "Space Gray" },
                    { 32, "Material", 14, "Aluminum" },
                    { 33, "Color", 14, "Silver" },
                    { 34, "Connection", 15, "Bluetooth" },
                    { 35, "Color", 15, "Black" },
                    { 36, "Connection", 16, "Bluetooth" },
                    { 37, "Color", 16, "Blue" },
                    { 38, "Resolution", 17, "1080p" },
                    { 39, "Color", 17, "Black" },
                    { 40, "Storage", 18, "1TB" },
                    { 41, "Color", 18, "Black" },
                    { 42, "Capacity", 19, "20000mAh" },
                    { 43, "Color", 19, "White" },
                    { 44, "Size", 20, "27-inch" },
                    { 45, "Resolution", 20, "QHD" },
                    { 46, "Color", 20, "Black" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecs_ProductId",
                table: "ProductSpecs",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSpecs");
        }
    }
}
