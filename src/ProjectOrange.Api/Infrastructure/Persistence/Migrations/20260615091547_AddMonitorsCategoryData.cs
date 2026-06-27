using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectOrangeApi.Migrations
{
    /// <inheritdoc />
    public partial class AddMonitorsCategoryData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "SiteId" },
                values: new object[,]
                {
                    { 13, "Monitors", 1 },
                    { 14, "Monitors", 2 },
                    { 15, "Monitors", 3 },
                    { 16, "Monitors", 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductSpecs",
                columns: new[] { "Id", "Name", "ProductId", "Value" },
                values: new object[,]
                {
                    { 47, "Refresh Rate", 20, "75Hz" },
                    { 48, "Panel", 20, "IPS" },
                    { 147, "Refresh Rate", 40, "75Hz" },
                    { 148, "Panel", 40, "IPS" },
                    { 247, "Refresh Rate", 60, "75Hz" },
                    { 248, "Panel", 60, "IPS" },
                    { 347, "Refresh Rate", 80, "75Hz" },
                    { 348, "Panel", 80, "IPS" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CategoryId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { 14, "Écran QHD polyvalent avec dalle IPS pour le travail quotidien.", "Moniteur 27 pouces QHD", 299m, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 15, "27英寸 2K显示器" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "Description", "Name", "Price" },
                values: new object[] { 16, "作業効率を高める高解像度 QHD ディスプレイ。", "27インチ QHD モニター", 44800m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "SiteId", "StockQuantity" },
                values: new object[,]
                {
                    { 81, 13, "Compact Full HD monitor for study and office desks.", "", "24-inch FHD Monitor", 7999m, 1, 14 },
                    { 82, 14, "Écran bureautique Full HD avec pied réglable.", "", "Moniteur 24 pouces FHD", 179m, 2, 10 },
                    { 83, 15, "紧凑全高清显示器，适合学习和日常办公。", "", "24英寸 全高清显示器", 799m, 3, 18 },
                    { 84, 16, "省スペースで使えるフル HD ディスプレイ。", "", "24インチ FHD モニター", 24800m, 4, 14 },
                    { 85, 13, "Large UHD display with HDR support for creative work.", "", "32-inch 4K Monitor", 24999m, 1, 8 },
                    { 86, 14, "Grand écran UHD avec HDR pour création et multitâche.", "", "Moniteur 32 pouces 4K", 449m, 2, 7 },
                    { 87, 15, "大尺寸 UHD 显示屏，适合创作和多任务处理。", "", "32英寸 4K显示器", 2499m, 3, 8 },
                    { 88, 16, "制作作業や動画視聴に適した大画面 4K ディスプレイ。", "", "32インチ 4K モニター", 69800m, 4, 7 },
                    { 89, 13, "Curved ultrawide display for multitasking and immersive setups.", "", "34-inch Ultrawide Monitor", 27999m, 1, 6 },
                    { 90, 14, "Écran incurvé UWQHD pour le multitâche et les configurations immersives.", "", "Moniteur Ultrawide 34 pouces", 549m, 2, 6 },
                    { 91, 15, "曲面 UWQHD 宽屏显示器，适合多任务处理和沉浸式体验。", "", "34英寸 带鱼屏显示器", 2999m, 3, 6 },
                    { 92, 16, "マルチタスクに便利な曲面 UWQHD ディスプレイ。", "", "34インチ ウルトラワイドモニター", 79800m, 4, 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductSpecs",
                columns: new[] { "Id", "Name", "ProductId", "Value" },
                values: new object[,]
                {
                    { 49, "Size", 81, "24-inch" },
                    { 50, "Resolution", 81, "FHD" },
                    { 51, "Refresh Rate", 81, "75Hz" },
                    { 52, "Panel", 81, "IPS" },
                    { 53, "Size", 85, "32-inch" },
                    { 54, "Resolution", 85, "4K UHD" },
                    { 55, "HDR", 85, "HDR10" },
                    { 56, "Panel", 85, "IPS" },
                    { 57, "Size", 89, "34-inch" },
                    { 58, "Resolution", 89, "UWQHD" },
                    { 59, "Refresh Rate", 89, "144Hz" },
                    { 60, "Panel", 89, "VA" },
                    { 149, "Size", 82, "24-inch" },
                    { 150, "Resolution", 82, "FHD" },
                    { 151, "Refresh Rate", 82, "75Hz" },
                    { 152, "Panel", 82, "IPS" },
                    { 153, "Size", 86, "32-inch" },
                    { 154, "Resolution", 86, "4K UHD" },
                    { 155, "HDR", 86, "HDR10" },
                    { 156, "Panel", 86, "IPS" },
                    { 157, "Size", 90, "34-inch" },
                    { 158, "Resolution", 90, "UWQHD" },
                    { 159, "Refresh Rate", 90, "144Hz" },
                    { 160, "Panel", 90, "VA" },
                    { 249, "Size", 83, "24-inch" },
                    { 250, "Resolution", 83, "FHD" },
                    { 251, "Refresh Rate", 83, "75Hz" },
                    { 252, "Panel", 83, "IPS" },
                    { 253, "Size", 87, "32-inch" },
                    { 254, "Resolution", 87, "4K UHD" },
                    { 255, "HDR", 87, "HDR10" },
                    { 256, "Panel", 87, "IPS" },
                    { 257, "Size", 91, "34-inch" },
                    { 258, "Resolution", 91, "UWQHD" },
                    { 259, "Refresh Rate", 91, "144Hz" },
                    { 260, "Panel", 91, "VA" },
                    { 349, "Size", 84, "24-inch" },
                    { 350, "Resolution", 84, "FHD" },
                    { 351, "Refresh Rate", 84, "75Hz" },
                    { 352, "Panel", 84, "IPS" },
                    { 353, "Size", 88, "32-inch" },
                    { 354, "Resolution", 88, "4K UHD" },
                    { 355, "HDR", 88, "HDR10" },
                    { 356, "Panel", 88, "IPS" },
                    { 357, "Size", 92, "34-inch" },
                    { 358, "Resolution", 92, "UWQHD" },
                    { 359, "Refresh Rate", 92, "144Hz" },
                    { 360, "Panel", 92, "VA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ProductSpecs",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "Description", "Name", "Price", "StockQuantity" },
                values: new object[] { 6, "Écran bureautique Full HD avec pied réglable.", "Moniteur 24 pouces FHD", 179m, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 9, "27-inch 2K Monitor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "Description", "Name", "Price" },
                values: new object[] { 12, "作業効率を高める高解像度 4K ディスプレイ。", "27-inch 4K Monitor", 54800m });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
